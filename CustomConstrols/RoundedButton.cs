using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;

namespace Gym.CustomControls
{
    public class RoundedButton : Button
    {
        private PropertyInfo _parentFillColorProp;

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            _parentFillColorProp = null;

            if (Parent != null)
            {
                Type parentType = Parent.GetType();
                _parentFillColorProp = parentType.GetProperty("FillColor");
            }
            InvalidateWithSurroundings();
        }

        //===============================================================================================

        private int borderRadius = 15;
        private int borderThickness = 0;
        private Color borderColor = Color.DodgerBlue;

        private Color fillColor = Color.MediumSlateBlue;
        private Color fillColor2 = Color.RoyalBlue;

        private Color hoverFillColor = Color.FromArgb(140, 120, 255);
        private Color hoverFillColor2 = Color.FromArgb(75, 130, 255);
        private Color pressedFillColor = Color.SlateBlue;
        private Color pressedFillColor2 = Color.MediumBlue;

        private Color selectedFillColor = Color.MediumSlateBlue;
        private Color selectedFillColor2 = Color.RoyalBlue;
        private Color disabledFillColor = Color.LightGray;
        private Color disabledFillColor2 = Color.Gray;
        private Color disabledForeColor = Color.White;

        private LinearGradientMode gradientMode = LinearGradientMode.Horizontal;
        private bool isHover = false;
        private bool isPressed = false;
        private bool isSelected = false;

        private Size customImageSize = Size.Empty;
        private bool c_iconColorMode = false;
        private Color c_iconColor = Color.White;

        private bool IsRtl => RightToLeft == RightToLeft.Yes;

        //-----------------------------------------------------------------------------------------------------



        // ==================================== نظام الكاش الفعلي للموارد ===================================

        private LinearGradientBrush _cachedBrush;
        private GraphicsPath _cachedPath;
        private Rectangle _cachedRect;
        private Color _cachedC1, _cachedC2;

        private GraphicsPath _cachedBorderPath;
        private int _cachedThickness;

        private void InvalidateCache()
        {
            _cachedBrush?.Dispose();
            _cachedBrush = null;

            _cachedPath?.Dispose();
            _cachedPath = null;

            _cachedBorderPath?.Dispose();       // 🌟 تنظيف مسار الإطار
            _cachedBorderPath = null;
        }

        //-----------------------------------------------------------------------------------------------------

        public RoundedButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.UserPaint |
                      ControlStyles.OptimizedDoubleBuffer |
                      ControlStyles.ResizeRedraw |
                      ControlStyles.SupportsTransparentBackColor, true);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.CheckedBackColor = Color.Transparent;

            DoubleBuffered = true;
            BackColor = Color.Transparent;
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 13f);

            UseVisualStyleBackColor = false;

            Resize += (s, e) => { InvalidateCache(); InvalidateWithSurroundings(); };
            MouseEnter += (s, e) => { isHover = true; InvalidateCache(); InvalidateWithSurroundings(); };
            MouseLeave += (s, e) => { isHover = false; isPressed = false; InvalidateCache(); InvalidateWithSurroundings(); };
            MouseDown += (s, e) => { if (e.Button == MouseButtons.Left) { isPressed = true; InvalidateCache(); InvalidateWithSurroundings(); } };
            MouseUp += (s, e) => { isPressed = false; InvalidateCache(); InvalidateWithSurroundings(); };
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                InvalidateCache();
            }
            base.Dispose(disposing);
        }


        // ============================================== Properties ============================================

        [Category("Rounded Button")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = Math.Max(1, value); InvalidateCache(); InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public int BorderThickness
        {
            get => borderThickness;
            set { borderThickness = Math.Max(0, value); InvalidateCache(); InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public Color FillColor
        {
            get => fillColor;
            set { fillColor = value; InvalidateCache(); InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public Color FillColor2
        {
            get => fillColor2;
            set { fillColor2 = value; InvalidateCache(); InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public Color HoverFillColor
        {
            get => hoverFillColor;
            set { hoverFillColor = value; InvalidateCache(); InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public Color HoverFillColor2
        {
            get => hoverFillColor2;
            set { hoverFillColor2 = value; InvalidateCache(); InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public Color PressedFillColor
        {
            get => pressedFillColor;
            set { pressedFillColor = value; InvalidateCache(); InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public Color PressedFillColor2
        {
            get => pressedFillColor2;
            set { pressedFillColor2 = value; InvalidateCache(); InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public Color DisabledFillColor
        {
            get => disabledFillColor;
            set { disabledFillColor = value; InvalidateCache(); InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public Color DisabledFillColor2
        {
            get => disabledFillColor2;
            set { disabledFillColor2 = value; InvalidateCache(); InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public Color DisabledForeColor
        {
            get => disabledForeColor;
            set { disabledForeColor = value; InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public LinearGradientMode GradientMode
        {
            get => gradientMode;
            set { gradientMode = value; InvalidateCache(); InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public bool IsSelected
        {
            get => isSelected;
            set
            {
                if (isSelected == value) return;
                isSelected = value;
                InvalidateCache();
                InvalidateWithSurroundings();
            }
        }

        [Category("Rounded Button")]
        public Color SelectedFillColor
        {
            get => selectedFillColor;
            set { selectedFillColor = value; InvalidateCache(); InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public Color SelectedFillColor2
        {
            get => selectedFillColor2;
            set { selectedFillColor2 = value; InvalidateCache(); InvalidateWithSurroundings(); }
        }

        [Category("Rounded Button")]
        public Size ImageSize
        {
            get => customImageSize;
            set { customImageSize = value; InvalidateWithSurroundings(); }
        }

        [Category("Custom Design")]
        public bool ImageColorMode
        {
            get => c_iconColorMode;
            set { c_iconColorMode = value; Invalidate(); }
        }

        [Category("Custom Design")]
        public Color ImageColor
        {
            get => c_iconColor;
            set { c_iconColor = value; Invalidate(); }
        }

        //-----------------------------------------------------------------------------------------------------



        // ============================================== Functions ============================================

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            d = Math.Min(d, Math.Min(rect.Width, rect.Height));

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }

        private (Color c1, Color c2) GetCurrentColors()
        {
            if (!Enabled) return (disabledFillColor, disabledFillColor2);
            if (isPressed) return (pressedFillColor, pressedFillColor2);
            if (isSelected) return (selectedFillColor, selectedFillColor2);
            if (isHover) return (hoverFillColor, hoverFillColor2);

            Color c1 = fillColor;
            Color c2 = fillColor2;

            return (c1, c2);

            //if (c1 == Color.Transparent || c2 == Color.Transparent)
            //{
            //    Control currentParent = this.Parent;
            //    Color foundColor1 = Color.Transparent;
            //    Color foundColor2 = Color.Transparent;

            //    // حلقة التكرار للصعود عبر الحاويات (Parent -> Parent.Parent -> ...)
            //    while (currentParent != null)
            //    {
            //        // أ. التحقق مما إذا كانت الحاوية الحالية مخصصة وتمتلك خصائص التدرج
            //        PropertyInfo propFill1 = currentParent.GetType().GetProperty("FillColor");
            //        PropertyInfo propFill2 = currentParent.GetType().GetProperty("FillColor2");

            //        if (propFill1 != null && propFill2 != null)
            //        {
            //            Color pColor1 = (Color)propFill1.GetValue(currentParent, null);
            //            Color pColor2 = (Color)propFill2.GetValue(currentParent, null);

            //            // إذا كانت ألوان الحاوية المخصصة غير شفافة، نلتقطها ونكسر الحلقة
            //            if (pColor1 != Color.Transparent || pColor2 != Color.Transparent)
            //            {
            //                // حماية: إذا كان أحدهما شفافاً والآخر ملوناً، نعوض النقص
            //                foundColor1 = pColor1 != Color.Transparent ? pColor1 : pColor2;
            //                foundColor2 = pColor2 != Color.Transparent ? pColor2 : pColor1;
            //                break;
            //            }
            //        }

            //        // ب. إذا لم تكن حاوية مخصصة، نتحقق من خاصية BackColor العادية
            //        if (currentParent.BackColor != Color.Transparent)
            //        {
            //            foundColor1 = currentParent.BackColor;
            //            foundColor2 = currentParent.BackColor;
            //            break; // وجدنا حاوية عادية أو فورم غير شفاف، نوقف البحث
            //        }

            //        // ج. الانتقال للحاوية الأب في المستوى الأعلى
            //        currentParent = currentParent.Parent;
            //    }

            //    // 3. تعيين الألوان النهائية للزر (مع توفير لون النظام كحماية أخيرة)
            //    if (c1 == Color.Transparent) c1 = foundColor1 != Color.Transparent ? foundColor1 : SystemColors.Control;
            //    if (c2 == Color.Transparent) c2 = foundColor2 != Color.Transparent ? foundColor2 : SystemColors.Control;
            //}

            //return (c1, c2);
        }

        private Rectangle GetImageBounds(Rectangle content, Image actualImage)
        {
            if (actualImage == null) return Rectangle.Empty;

            Size imgSize = _ImageSize(actualImage);
            if (!string.IsNullOrEmpty(Text) && TextImageRelation != TextImageRelation.Overlay)
            {
                var relation = FlipRelation(TextImageRelation);
                int x = content.X;
                int y = content.Y + (content.Height - imgSize.Height) / 2;
                switch (relation)
                {
                    case TextImageRelation.ImageBeforeText:
                        x = content.X;
                        break;
                    case TextImageRelation.TextBeforeImage:
                        x = content.Right - imgSize.Width;
                        break;
                    case TextImageRelation.ImageAboveText:
                        x = content.X + (content.Width - imgSize.Width) / 2;
                        y = content.Y;
                        break;
                    case TextImageRelation.TextAboveImage:
                        x = content.X + (content.Width - imgSize.Width) / 2;
                        y = content.Bottom - imgSize.Height;
                        break;
                }
                return new Rectangle(x, y, imgSize.Width, imgSize.Height);
            }

            return GetImageBoundsByAlignment(content, imgSize);
        }

        private Rectangle GetImageBoundsByAlignment(Rectangle content, Size imgSize)
        {
            var align = FlipAlignment(ImageAlign);
            int x, y;

            switch (align)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.BottomLeft:
                    x = content.X;
                    break;
                case ContentAlignment.TopRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.BottomRight:
                    x = content.Right - imgSize.Width;
                    break;
                default:
                    x = content.X + (content.Width - imgSize.Width) / 2;
                    break;
            }

            switch (align)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.TopCenter:
                case ContentAlignment.TopRight:
                    y = content.Y;
                    break;
                case ContentAlignment.BottomLeft:
                case ContentAlignment.BottomCenter:
                case ContentAlignment.BottomRight:
                    y = content.Bottom - imgSize.Height;
                    break;
                default:
                    y = content.Y + (content.Height - imgSize.Height) / 2;
                    break;
            }

            return new Rectangle(x, y, imgSize.Width, imgSize.Height);
        }

        private Size _ImageSize(Image img)
        {
            if (customImageSize != Size.Empty && customImageSize.Width > 0 && customImageSize.Height > 0)
                return customImageSize;

            if (img != null)
                return img.Size;
            return Size.Empty;
        }

        private Rectangle GetTextBounds(Rectangle content, Rectangle imgBounds, bool hasImage)
        {
            if (!hasImage)
                return content; // إصلاح: استخدام الأبعاد الآمنة (content) بدلاً من كامل العرض

            var relation = FlipRelation(TextImageRelation);

            switch (relation)
            {
                case TextImageRelation.ImageBeforeText:
                    return new Rectangle(imgBounds.Right + 4, content.Y, content.Right - imgBounds.Right - 4, content.Height);
                case TextImageRelation.TextBeforeImage:
                    return new Rectangle(content.X, content.Y, imgBounds.Left - content.X - 4, content.Height);
                case TextImageRelation.ImageAboveText:
                    return new Rectangle(content.X, imgBounds.Bottom + 2, content.Width, content.Bottom - imgBounds.Bottom - 2);
                case TextImageRelation.TextAboveImage:
                    return new Rectangle(content.X, content.Y, content.Width, imgBounds.Top - content.Y - 2);
                default:
                    return content;
            }
        }

        private TextFormatFlags GetTextFormatFlags()
        {
            TextFormatFlags flags = TextFormatFlags.WordBreak | TextFormatFlags.NoPadding;
            var align = FlipAlignment(TextAlign);

            switch (align)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.BottomLeft:
                    flags |= TextFormatFlags.Left; break;
                case ContentAlignment.TopRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.BottomRight:
                    flags |= TextFormatFlags.Right; break;
                default:
                    flags |= TextFormatFlags.HorizontalCenter; break;
            }

            switch (align)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.TopCenter:
                case ContentAlignment.TopRight:
                    flags |= TextFormatFlags.Top; break;
                case ContentAlignment.BottomLeft:
                case ContentAlignment.BottomCenter:
                case ContentAlignment.BottomRight:
                    flags |= TextFormatFlags.Bottom; break;
                default:
                    flags |= TextFormatFlags.VerticalCenter; break;
            }

            if (!UseMnemonic) flags |= TextFormatFlags.NoPrefix;
            if (IsRtl) flags |= TextFormatFlags.RightToLeft;

            return flags;
        }

        private ContentAlignment FlipAlignment(ContentAlignment align)
        {
            if (!IsRtl) return align;
            switch (align)
            {
                case ContentAlignment.TopLeft: return ContentAlignment.TopRight;
                case ContentAlignment.TopRight: return ContentAlignment.TopLeft;
                case ContentAlignment.MiddleLeft: return ContentAlignment.MiddleRight;
                case ContentAlignment.MiddleRight: return ContentAlignment.MiddleLeft;
                case ContentAlignment.BottomLeft: return ContentAlignment.BottomRight;
                case ContentAlignment.BottomRight: return ContentAlignment.BottomLeft;
                default: return align;
            }
        }

        private TextImageRelation FlipRelation(TextImageRelation relation)
        {
            if (!IsRtl) return relation;
            if (relation == TextImageRelation.ImageBeforeText) return TextImageRelation.TextBeforeImage;
            if (relation == TextImageRelation.TextBeforeImage) return TextImageRelation.ImageBeforeText;
            return relation;
        }

        private Color GetEffectiveParentBackColor()
        {
            Control currentParent = this.Parent;

            while (currentParent != null)
            {
                PropertyInfo propFill = currentParent.GetType().GetProperty("FillColor");
                PropertyInfo propFill2 = currentParent.GetType().GetProperty("FillColor2");

                if (propFill != null && propFill2 != null)
                {
                    Color pColor = (Color)propFill.GetValue(currentParent, null);
                    Color pColor2 = (Color)propFill2.GetValue(currentParent, null);

                    // نأخذ اللون الأول إذا كان غير شفاف، وإلا نأخذ الثاني
                    if (pColor != Color.Transparent) return pColor;
                    if (pColor2 != Color.Transparent) return pColor2;
                }

                if (currentParent.BackColor != Color.Transparent)
                {
                    return currentParent.BackColor;
                }

                currentParent = currentParent.Parent;
            }

            return SystemColors.Control;
        }

        private void InvalidateWithSurroundings()
        {
            if (Parent != null)
            {
                Rectangle rect = Bounds;
                rect.Inflate(3, 3);
                Parent.Invalidate(rect, true);
            }
            Invalidate();
        }

        //-----------------------------------------------------------------------------------------------------


        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if (Parent != null && Width > 0 && Height > 0)
            {
                if (_parentFillColorProp != null || Parent.BackColor == Color.Transparent)
                {
                    // 🌟 رسم خلفية الأب على كامل مساحة الزر (هذا يضمن تغطية الزوايا المربعة الميتة)
                    GraphicsState state = g.Save();
                    g.TranslateTransform(-Left, -Top);

                    // ⚠️ تم إزالة الـ Clip تماماً لكي تصل خلفية الأب إلى الزوايا المربعة خارج التدوير!
                    using (PaintEventArgs parentPaintArgs = new PaintEventArgs(g, Parent.ClientRectangle))
                    {
                        InvokePaintBackground(Parent, parentPaintArgs);
                        InvokePaint(Parent, parentPaintArgs);
                    }
                    g.Restore(state);
                }
                else
                {
                    g.Clear(GetEffectiveParentBackColor());
                }
            }

            Rectangle rect = ClientRectangle;
            var (c1, c2) = GetCurrentColors();

            // 2. تحديث واستخدام الكاش الذكي للفرشاة والمسار الدائري للزر
            if (_cachedBrush == null || _cachedRect != rect || _cachedC1 != c1 || _cachedC2 != c2 || _cachedThickness != borderThickness)
            {
                _cachedBrush?.Dispose();
                _cachedPath?.Dispose();
                _cachedBorderPath?.Dispose();

                _cachedRect = rect;
                _cachedC1 = c1;
                _cachedC2 = c2;
                _cachedThickness = borderThickness;

                // مسار تعبئة الزر
                _cachedPath = GetRoundedPath(rect, borderRadius);

                // مسار الإطار البسيط مع إزاحة متساوية تمنع اقتطاع الحافة العلوية
                if (borderThickness > 0)
                {
                    Rectangle borderRect = rect;
                    borderRect.Inflate(-borderThickness / 2, -borderThickness / 2);
                    _cachedBorderPath = GetRoundedPath(borderRect, borderRadius);
                }

                _cachedBrush = new LinearGradientBrush(rect, c1, c2, gradientMode);
            }

            // رسم التعبئة الجسدية للزر من الكاش
            g.FillPath(_cachedBrush, _cachedPath);

            // 3. رسم الإطار (Border) بطريقة هندسية موزونة
            if (borderThickness > 0 && _cachedBorderPath != null)
            {
                using (Pen pen = new Pen(borderColor, borderThickness) { Alignment = PenAlignment.Center })
                {
                    g.DrawPath(pen, _cachedBorderPath);
                }
            }

            Rectangle content = new Rectangle(Padding.Left, Padding.Top, Width - Padding.Left - Padding.Right, Height - Padding.Top - Padding.Bottom);

            // 4. استخراج الأيقونة ومعالجتها بدون تسريب للذاكرة (Memory Leak Support)
            Image actualImage = null;
            bool isImageClonedFromList = false;

            if (ImageList != null && ImageIndex >= 0 && ImageIndex < ImageList.Images.Count)
            {
                actualImage = ImageList.Images[ImageIndex];
                isImageClonedFromList = true;
            }
            else
            {
                actualImage = Image;
            }

            Rectangle imgBounds = Rectangle.Empty;
            bool hasImage = actualImage != null;

            if (hasImage)
            {
                imgBounds = GetImageBounds(content, actualImage);
                if (!imgBounds.IsEmpty)
                {
                    if (!Enabled)
                    {
                        ControlPaint.DrawImageDisabled(g, actualImage, imgBounds.X, imgBounds.Y, Color.Transparent);
                    }
                    else if (c_iconColorMode)
                    {
                        float r = c_iconColor.R / 255f;
                        float gComponent = c_iconColor.G / 255f;
                        float b = c_iconColor.B / 255f;

                        float[][] colorMatrixElements = {
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {r, gComponent, b, 0, 1}
                };

                        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

                        using (ImageAttributes attributes = new ImageAttributes())
                        {
                            attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                            g.DrawImage(actualImage, imgBounds, 0, 0, actualImage.Width, actualImage.Height, GraphicsUnit.Pixel, attributes);
                        }
                    }
                    else
                    {
                        g.DrawImage(actualImage, imgBounds);
                    }
                }
            }

            // 5. رسم النص مع حماية الهوامش والأبعاد الآمنة (Padding Safe)
            if (!string.IsNullOrEmpty(Text))
            {
                Rectangle textBounds = GetTextBounds(content, imgBounds, hasImage);
                Color foreColor = Enabled ? ForeColor : disabledForeColor;
                TextFormatFlags flags = GetTextFormatFlags();
                TextRenderer.DrawText(g, Text, Font, textBounds, foreColor, flags);
            }

            // 6. رسم إطار التركيز عند التنقل بالـ Keyboard
            if (Focused && ShowFocusCues)
            {
                Rectangle focusRect = new Rectangle(rect.X + 4, rect.Y + 4, rect.Width - 8, rect.Height - 8);
                ControlPaint.DrawFocusRectangle(g, focusRect);
            }

            // التنظيف الفوري والحتمي لمنع تسريب موارد النظام
            if (isImageClonedFromList && actualImage != null)
            {
                actualImage.Dispose();
            }
        }

        // إفراغ الدالة لمنع الرسم المزدوج (Double Rendering) الذي يستهلك المعالج
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // تم الإلغاء الاعتماد الكلي هنا لأننا نرسم خلفية الأب كأول خطوة في OnPaint
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            InvalidateWithSurroundings();
        }


    }   
}