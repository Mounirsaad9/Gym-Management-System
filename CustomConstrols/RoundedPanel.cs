using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace Gym.CustomControls
{
    public class RoundedPanel : Panel
    {
        [Flags]
        public enum RoundedCorners
        {
            None = 0,
            TopLeft = 1,
            TopRight = 2,
            BottomRight = 4,
            BottomLeft = 8,
            All = TopLeft | TopRight | BottomRight | BottomLeft
        }

        [Flags]
        public enum enBorderSides
        {
            None = 0,
            Top = 1,
            Bottom = 2,
            Left = 4,
            Right = 8,
            All = Top | Bottom | Left | Right
        }
        private enBorderSides borderSides = enBorderSides.All; // افتراضياً نرسم جميع الحواف

        private int borderRadius = 15;
        private int borderThickness = 1;
        private int underlineThickness = 2;
        private int glowSize = 5;


        private LinearGradientMode gradientMode = LinearGradientMode.Vertical;
        private RoundedCorners roundedCorners = RoundedCorners.All;


        private bool underlineOnly = false;
        private bool isUnderlineFocused = false;
        private bool glowEnabled = false;
        private bool forceGlow = false;


        private Color underlineColor = Color.LightGray;
        private Color underlineFocusColor = Color.DodgerBlue;
        private Color borderColor = Color.Gainsboro;
        private Color fillColor = Color.Transparent;
        private Color fillColor2 = Color.Transparent;
        private Color glowColor = Color.DodgerBlue;


        // ====================================== كاش الأداء العالي لتقليل استهلاك المعالج ===========================
        private GraphicsPath _cachedPath;
        private GraphicsPath _cachedBorderPath;
        private Rectangle _cachedRect;

        private Region _cachedFlatRegion;
        private Rectangle _cachedFlatRect;

        private LinearGradientBrush _cachedBrush;
        private Rectangle _cachedBrushRect;
        private Color _cachedC1, _cachedC2;
        private LinearGradientMode _cachedGradientMode;

        // كاش الـ Reflection لمنع الثقل أثناء الـ Resize
        private PropertyInfo _parentFillColorProp;
        private PropertyInfo _parentFillColor2Prop;
        private bool _parentPropertiesChecked = false;

        //-----------------------------------------------------------------------------------------------------

        public RoundedPanel()
        {
            // تفعيل أنماط الرسم المتقدمة والشفافية بدون قَص الحواف لضمان النعومة الفائقة
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.UserPaint |
                      ControlStyles.OptimizedDoubleBuffer |
                      ControlStyles.ResizeRedraw |
                      ControlStyles.SupportsTransparentBackColor, true);

            DoubleBuffered = true;
            BackColor = Color.Transparent;

            ControlAdded += (s, e) =>
            {
                e.Control.GotFocus += (cs, ce) => { isUnderlineFocused = true; Invalidate(); };
                e.Control.LostFocus += (cs, ce) => { isUnderlineFocused = false; Invalidate(); };
            };
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                InvalidateCache();
                _cachedFlatRegion?.Dispose();
                _cachedFlatRegion = null;
                _cachedBrush?.Dispose();
            }
            base.Dispose(disposing);
        }



        // 🚀 السحر الأول: تفعيل التخزين المؤقت المزدوج على مستوى نظام التشغيل لمنع التقطيش والوميض تماماً أثناء الـ Resize
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            _parentPropertiesChecked = false;
            _parentFillColorProp = null;
            _parentFillColor2Prop = null;
            Invalidate();
        }

        private void InvalidateCache()
        {
            _cachedPath?.Dispose();
            _cachedBorderPath?.Dispose();
            _cachedPath = null;
            _cachedBorderPath = null;

            _cachedBrush?.Dispose();
            _cachedBrush = null;
        }

        private void UpdateCache(Rectangle rect)
        {
            if (_cachedPath != null && rect == _cachedRect)
                return;

            InvalidateCache();

            _cachedRect = rect;

            // 1. حساب مسار التعبئة الداخلي منكمشاً بمقدار 1 بكسل لمنع الـ Bleeding
            Rectangle fillRect = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height);
            _cachedPath = GetRoundedPath(fillRect, borderRadius);

            // 2. 🌟 حساب مسار الإطار الرياضي الموزون لمنع التراكم أو التشوه البصري
            if (borderThickness > 0)
            {
                int offset = (borderThickness == 1) ? 1 : (borderThickness / 2);

                // حساب أبعاد مربع الإطار بناءً على الإزاحة الجديدة لضمان تماثل الحواف الأربعة
                Rectangle bRectInt = new Rectangle(
                    rect.X + offset,
                    rect.Y + offset,
                    rect.Width - (offset * 2),
                    rect.Height - (offset * 2)
                );

                if (borderSides == enBorderSides.All)
                {
                    _cachedBorderPath = GetRoundedPath(bRectInt, borderRadius);
                }
                else
                {
                    // إنشاء مسار مخصص يحتوي فقط على الخطوط والمنحنيات المطلوبة يدوياً
                    _cachedBorderPath = GetSpecificSidesPath(bRectInt, borderRadius, borderSides);
                }
            }
        }

        private GraphicsPath GetSpecificSidesPath(Rectangle rect, int radius, enBorderSides sides)
        {
            GraphicsPath path = new GraphicsPath();

            // 🛡️ فحص أمان لحجم المستطيل
            if (rect.Width <= 0 || rect.Height <= 0) return path;

            int maxD = Math.Min(rect.Width, rect.Height);
            int d = Math.Min(radius * 2, maxD);

            // إذا كانت المساحة ضيقة جداً، نلغي الانحناء مؤقتاً لتفادي خطأ AddArc
            bool canDrawArcs = d >= 2;

            Rectangle topLeftArc = new Rectangle(rect.X, rect.Y, d, d);
            Rectangle topRightArc = new Rectangle(rect.Right - d, rect.Y, d, d);
            Rectangle bottomRightArc = new Rectangle(rect.Right - d, rect.Bottom - d, d, d);
            Rectangle bottomLeftArc = new Rectangle(rect.X, rect.Bottom - d, d, d);

            bool isTopLeftRound = canDrawArcs && (radius > 1) && CornerTopLeft;
            bool isTopRightRound = canDrawArcs && (radius > 1) && CornerTopRight;
            bool isBottomRightRound = canDrawArcs && (radius > 1) && CornerBottomRight;
            bool isBottomLeftRound = canDrawArcs && (radius > 1) && CornerBottomLeft;

            bool drawTopLeftArc = isTopLeftRound && ((sides & enBorderSides.Top) == enBorderSides.Top || (sides & enBorderSides.Left) == enBorderSides.Left);
            bool drawTopRightArc = isTopRightRound && ((sides & enBorderSides.Top) == enBorderSides.Top || (sides & enBorderSides.Right) == enBorderSides.Right);
            bool drawBottomRightArc = isBottomRightRound && ((sides & enBorderSides.Bottom) == enBorderSides.Bottom || (sides & enBorderSides.Right) == enBorderSides.Right);
            bool drawBottomLeftArc = isBottomLeftRound && ((sides & enBorderSides.Bottom) == enBorderSides.Bottom || (sides & enBorderSides.Left) == enBorderSides.Left);

            bool drawTopLine = (sides & enBorderSides.Top) == enBorderSides.Top;
            bool drawRightLine = (sides & enBorderSides.Right) == enBorderSides.Right;
            bool drawBottomLine = (sides & enBorderSides.Bottom) == enBorderSides.Bottom;
            bool drawLeftLine = (sides & enBorderSides.Left) == enBorderSides.Left;

            int topLineStartX = isTopLeftRound ? (rect.X + (d / 2)) : rect.X;
            int topLineEndX = isTopRightRound ? (rect.Right - (d / 2)) : rect.Right;

            int rightLineStartY = isTopRightRound ? (rect.Y + (d / 2)) : rect.Y;
            int rightLineEndY = isBottomRightRound ? (rect.Bottom - (d / 2)) : rect.Bottom;

            int bottomLineStartX = isBottomRightRound ? (rect.Right - (d / 2)) : rect.Right;
            int bottomLineEndX = isBottomLeftRound ? (rect.X + (d / 2)) : rect.X;

            int leftLineStartY = isBottomLeftRound ? (rect.Bottom - (d / 2)) : rect.Bottom;
            int leftLineEndY = isTopLeftRound ? (rect.Y + (d / 2)) : rect.Y;

            var components = new[]
            {
        new { Name = "TopLeftArc",     Enabled = drawTopLeftArc,     Action = new Action(() => path.AddArc(topLeftArc, 180, 90)) },
        new { Name = "TopLine",        Enabled = drawTopLine,        Action = new Action(() => path.AddLine(topLineStartX, rect.Y, topLineEndX, rect.Y)) },
        new { Name = "TopRightArc",    Enabled = drawTopRightArc,    Action = new Action(() => path.AddArc(topRightArc, 270, 90)) },
        new { Name = "RightLine",       Enabled = drawRightLine,       Action = new Action(() => path.AddLine(rect.Right, rightLineStartY, rect.Right, rightLineEndY)) },
        new { Name = "BottomRightArc", Enabled = drawBottomRightArc, Action = new Action(() => path.AddArc(bottomRightArc, 0, 90)) },
        new { Name = "BottomLine",     Enabled = drawBottomLine,     Action = new Action(() => path.AddLine(bottomLineStartX, rect.Bottom, bottomLineEndX, rect.Bottom)) },
        new { Name = "BottomLeftArc",  Enabled = drawBottomLeftArc,  Action = new Action(() => path.AddArc(bottomLeftArc, 90, 90)) },
        new { Name = "LeftLine",       Enabled = drawLeftLine,       Action = new Action(() => path.AddLine(rect.X, leftLineStartY, rect.X, leftLineEndY)) }
    };

            int startIndex = 0;
            for (int i = 0; i < 8; i++)
            {
                int prev = (i - 1 + 8) % 8;
                if (components[i].Enabled && !components[prev].Enabled)
                {
                    startIndex = i;
                    break;
                }
            }

            bool lastWasEnabled = false;

            for (int i = 0; i < 8; i++)
            {
                int currentIndex = (startIndex + i) % 8;
                var comp = components[currentIndex];

                if (comp.Enabled)
                {
                    if (!lastWasEnabled) path.StartFigure();
                    comp.Action();
                    lastWasEnabled = true;
                }
                else
                {
                    lastWasEnabled = false;
                }
            }

            return path;
        }

        //-----------------------------------------------------------------------------------------------------



        // ====================================== Properties ===========================

        [Category("Rounded Panel")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                value = Math.Max(1, value);
                if (borderRadius == value) return;
                borderRadius = value;
                InvalidateCache();
                Invalidate();
            }
        }


        [Category("Rounded Panel")]
        public int BorderThickness
        {
            get => borderThickness;
            set { borderThickness = Math.Max(0, value); Invalidate(); }
        }


        [Category("Rounded Panel")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }


        [Category("Rounded Panel")]
        public Color FillColor
        {
            get => fillColor;
            set { fillColor = value; Invalidate(); }
        }


        [Category("Rounded Panel")]
        public Color FillColor2
        {
            get => fillColor2;
            set { fillColor2 = value; Invalidate(); }
        }


        [Category("Rounded Panel")]
        public LinearGradientMode GradientMode
        {
            get => gradientMode;
            set { gradientMode = value; Invalidate(); }
        }


        [Category("Rounded Panel")]
        public RoundedCorners Corners
        {
            get => roundedCorners;
            set
            {
                if (roundedCorners == value) return;
                roundedCorners = value;
                InvalidateCache();
                Invalidate();
            }
        }


        [Category("Rounded Panel")]
        public bool CornerTopLeft
        {
            get => roundedCorners.HasFlag(RoundedCorners.TopLeft);
            set
            {
                if (value) roundedCorners |= RoundedCorners.TopLeft;
                else roundedCorners &= ~RoundedCorners.TopLeft;
                InvalidateCache();
                Invalidate();
            }
        }


        [Category("Rounded Panel")]
        public bool CornerTopRight
        {
            get => roundedCorners.HasFlag(RoundedCorners.TopRight);
            set
            {
                if (value) roundedCorners |= RoundedCorners.TopRight;
                else roundedCorners &= ~RoundedCorners.TopRight;
                InvalidateCache();
                Invalidate();
            }
        }


        [Category("Rounded Panel")]
        public bool CornerBottomRight
        {
            get => roundedCorners.HasFlag(RoundedCorners.BottomRight);
            set
            {
                if (value) roundedCorners |= RoundedCorners.BottomRight;
                else roundedCorners &= ~RoundedCorners.BottomRight;
                InvalidateCache();
                Invalidate();
            }
        }


        [Category("Rounded Panel")]
        public bool CornerBottomLeft
        {
            get => roundedCorners.HasFlag(RoundedCorners.BottomLeft);
            set
            {
                if (value) roundedCorners |= RoundedCorners.BottomLeft;
                else roundedCorners &= ~RoundedCorners.BottomLeft;
                InvalidateCache();
                Invalidate();
            }
        }


        [Category("Rounded Panel")]
        public bool UnderlineOnly
        {
            get => underlineOnly;
            set { if (underlineOnly == value) return; underlineOnly = value; InvalidateCache(); Invalidate(); }
        }


        [Category("Rounded Panel")]
        public Color UnderlineColor
        {
            get => underlineColor;
            set { underlineColor = value; Invalidate(); }
        }


        [Category("Rounded Panel")]
        public Color UnderlineFocusColor
        {
            get => underlineFocusColor;
            set { underlineFocusColor = value; Invalidate(); }
        }


        [Category("Rounded Panel")]
        public int UnderlineThickness
        {
            get => underlineThickness;
            set { underlineThickness = Math.Max(1, value); Invalidate(); }
        }


        [Category("Rounded Panel")]
        public bool GlowEnabled
        {
            get => glowEnabled;
            set { glowEnabled = value; Invalidate(); }
        }


        [Category("Rounded Panel")]
        public Color GlowColor
        {
            get => glowColor;
            set { glowColor = value; Invalidate(); }
        }


        [Category("Rounded Panel")]
        public int GlowSize
        {
            get => glowSize;
            set { glowSize = Math.Max(1, value); Invalidate(); }
        }


        [Category("Custom Design")]
        public bool ForceGlow
        {
            get => forceGlow;
            set
            {
                forceGlow = value;
                Invalidate(); // إعادة رسم البانيل فوراً لتطبيق التوهج أو إخفائه
            }
        }


        [Category("Custom Design")]
        [Description("تحديد أي من حواف الإطار (Top, Bottom, Left, Right) سيتم رسمها.")]
        public enBorderSides BorderSides
        {
            get => borderSides;
            set
            {
                borderSides = value;
                InvalidateCache(); // إفراغ الكاش لإجبار الأداة على إعادة حساب المسارات برسمها الجديد
                Invalidate();
            }
        }


        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new BorderStyle BorderStyle
        {
            get => BorderStyle.None;
            set => base.BorderStyle = BorderStyle.None;
        }


        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color BackColor
        {
            get => Color.Transparent;
            set => base.BackColor = Color.Transparent;
        }

        //-----------------------------------------------------------------------------------------------------


        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            if (rect.Width <= 0 || rect.Height <= 0) return path;

            // حساب القطر وضمان أنه لا يقل عن 1 ولا يتجاوز أبعاد المستطيل
            int maxD = Math.Min(rect.Width, rect.Height);
            int d = Math.Min(radius * 2, maxD);

            path.StartFigure();

            // 🛡️ إذا كان قطر القوس صغيراً جداً (أقل من 2 بكسل)، نرسم زوايا حادة لتجنب خطأ GDI+
            if (d < 2)
            {
                path.AddRectangle(rect);
                path.CloseFigure();
                return path;
            }

            if (roundedCorners.HasFlag(RoundedCorners.TopLeft))
                path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            else
                path.AddLine(rect.X, rect.Y, rect.X, rect.Y);

            if (roundedCorners.HasFlag(RoundedCorners.TopRight))
                path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            else
                path.AddLine(rect.Right, rect.Y, rect.Right, rect.Y);

            if (roundedCorners.HasFlag(RoundedCorners.BottomRight))
                path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            else
                path.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Bottom);

            if (roundedCorners.HasFlag(RoundedCorners.BottomLeft))
                path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            else
                path.AddLine(rect.X, rect.Bottom, rect.X, rect.Bottom);

            path.CloseFigure();
            return path;

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // تترك فارغة تماماً لمنع مسح الخلفية التقليدي المسبب للوميض
        }

        private Color GetEffectiveParentBackColor()
        {
            Control parent = Parent;
            while (parent != null && parent.BackColor == Color.Transparent)
                parent = parent.Parent;
            return parent?.BackColor ?? SystemColors.Control;
        }

        private (Color c1, Color c2) GetCurrentColors()
        {
            Color c1 = fillColor;
            Color c2 = fillColor2;

            if (c1 == Color.Transparent || c2 == Color.Transparent)
            {
                Color effectiveParentColor = GetEffectiveParentBackColor();

                if (Parent != null)
                {
                    if (!_parentPropertiesChecked)
                    {
                        Type t = Parent.GetType();
                        _parentFillColorProp = t.GetProperty("FillColor");
                        _parentFillColor2Prop = t.GetProperty("FillColor2");
                        _parentPropertiesChecked = true;
                    }

                    if (c1 == Color.Transparent)
                    {
                        if (_parentFillColorProp != null)
                        {
                            Color pColor1 = (Color)_parentFillColorProp.GetValue(Parent, null);
                            c1 = (pColor1 == Color.Transparent) ? effectiveParentColor : pColor1;
                        }
                        else
                        {
                            c1 = effectiveParentColor;
                        }
                    }

                    if (c2 == Color.Transparent)
                    {
                        if (_parentFillColor2Prop != null)
                        {
                            Color pColor2 = (Color)_parentFillColor2Prop.GetValue(Parent, null);
                            c2 = (pColor2 == Color.Transparent) ? effectiveParentColor : pColor2;
                        }
                        else
                        {
                            c2 = effectiveParentColor;
                        }
                    }
                }
                else
                {
                    if (c1 == Color.Transparent) c1 = effectiveParentColor;
                    if (c2 == Color.Transparent) c2 = effectiveParentColor;
                }
            }

            return (c1, c2);
        }

        private LinearGradientBrush GetCachedBrush(Rectangle rect, Color c1, Color c2)
        {
            if (_cachedBrush == null || rect != _cachedBrushRect ||
                c1 != _cachedC1 || c2 != _cachedC2 || gradientMode != _cachedGradientMode)
            {
                _cachedBrush?.Dispose();
                _cachedBrush = new LinearGradientBrush(rect, c1, c2, gradientMode);
                _cachedBrushRect = rect;
                _cachedC1 = c1;
                _cachedC2 = c2;
                _cachedGradientMode = gradientMode;
            }
            return _cachedBrush;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            if (underlineOnly)
            {
                g.SmoothingMode = SmoothingMode.None;
                if (_cachedFlatRegion == null || rect != _cachedFlatRect)
                {
                    _cachedFlatRegion?.Dispose();
                    _cachedFlatRegion = new Region(rect);
                    _cachedFlatRect = rect;
                }
                if (this.Region != _cachedFlatRegion)
                    this.Region = _cachedFlatRegion;

                var (c1, c2) = GetCurrentColors();
                g.FillRectangle(GetCachedBrush(rect, c1, c2), rect);

                using (Pen coverPen = new Pen(c1, 1f))
                {
                    g.DrawRectangle(coverPen, rect.X, rect.Y, rect.Width - 1, rect.Height - 1);
                }

                Color lineColor = isUnderlineFocused ? underlineFocusColor : underlineColor;
                using (Pen pen = new Pen(lineColor, underlineThickness))
                {
                    g.DrawLine(pen,
                        rect.X,
                        rect.Bottom - underlineThickness,
                        rect.Right,
                        rect.Bottom - underlineThickness);
                }
            }
            else
            {
                if (this.Region != null)
                    this.Region = null;

                // 🚀 الرسم المباشر فائق السرعة عبر تحويل مصفوفة الـ Graphics
                if (Parent != null)
                {
                    GraphicsState state = g.Save();
                    g.TranslateTransform(-Left, -Top);
                    g.SetClip(new Rectangle(Left, Top, Width, Height), CombineMode.Replace);
                    using (PaintEventArgs parentPaintArgs = new PaintEventArgs(g, Parent.ClientRectangle))
                    {
                        InvokePaintBackground(Parent, parentPaintArgs);
                        InvokePaint(Parent, parentPaintArgs);
                    }
                    g.Restore(state);
                }

                UpdateCache(rect);
                var (c1, c2) = GetCurrentColors();

                // 1. تعبئة الخلفية بالمسار الداخلي النظيف الموزون
                g.FillPath(GetCachedBrush(rect, c1, c2), _cachedPath);

                // 2. تأثير الوهج الجانبي (Glow) إن وجد
                if (glowEnabled && isUnderlineFocused || glowEnabled && forceGlow)
                {
                    for (int i = 1; i <= glowSize; i++)
                    {
                        int alpha = (int)(60 * (1.0 - (double)(i - 1) / glowSize));
                        Rectangle glowRect = new Rectangle(
                            rect.X + i,
                            rect.Y + i,
                            rect.Width - i * 2,
                            rect.Height - i * 2);
                        using (GraphicsPath glowPath = GetRoundedPath(glowRect, borderRadius))
                        using (Pen pen = new Pen(Color.FromArgb(alpha, glowColor), 1.5f))
                            g.DrawPath(pen, glowPath);
                    }
                }

                // 3. رسم الإطار الفعلي بمحاذاة المنتصف Center لمنع التشوه والزيادة الداخلية
                if (borderThickness > 0 && _cachedBorderPath != null)
                {
                    using (Pen pen = new Pen(borderColor, borderThickness) { Alignment = PenAlignment.Center })
                    {
                        g.DrawPath(pen, _cachedBorderPath);
                    }
                }
            }
        }
    }
}