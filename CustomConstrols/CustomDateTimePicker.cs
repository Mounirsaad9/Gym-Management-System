using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class CustomDateTimePicker : DateTimePicker
    {
        // المتغيرات الداخلية (أصبحت قيم افتراضية فقط ويمكن تغييرها)
        private Color _skinColor = Color.FromArgb(28, 33, 43);
        private Color _textColor = Color.White;
        private Color _borderColor = Color.CornflowerBlue;
        private int _borderSize = 2;
        private Color _iconColor = Color.CornflowerBlue;
        private int _borderRadius = 12;

        // 🌟 الحل السحري للحواف السوداء: خاصية نتحكم بها بلون الحاوية الخارجية
        private Color _containerBackColor = Color.FromArgb(18, 22, 30);

        private string _placeholderText = "Select Date...";
        private bool _showPlaceholder = true;
        private Color _placeholderColor = Color.Gray;

        #region ─── الخصائص العلنية (تظهر في الـ Properties) ───

        [Category("Custom Design")]
        [Description("لون الخلفية الداخلية للكنترول")]
        public Color SkinColor
        {
            get => _skinColor;
            set { _skinColor = value; this.Invalidate(); }
        }

        [Category("Custom Design")]
        [Description("لون النص المعروض للتاريخ")]
        public Color TextColor
        {
            get => _textColor;
            set { _textColor = value; this.Invalidate(); }
        }

        [Category("Custom Design")]
        [Description("لون الإطار الخارجي")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; this.Invalidate(); }
        }

        [Category("Custom Design")]
        [Description("حجم أو سماكة الإطار")]
        public int BorderSize
        {
            get => _borderSize;
            set { _borderSize = value; this.Invalidate(); }
        }

        [Category("Custom Design")]
        [Description("درجة انحناء وتدوير الحواف")]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; this.Invalidate(); }
        }

        [Category("Custom Design")]
        [Description("لون أيقونة السهم")]
        public Color IconColor
        {
            get => _iconColor;
            set { _iconColor = value; this.Invalidate(); }
        }

        [Category("Custom Design")]
        [Description("🌟 لون الحاوية أو البانيل الموجود فيه الكنترول (اجعله مطابخ للبانيل لتختفي الحواف السوداء)")]
        public Color ContainerBackColor
        {
            get => _containerBackColor;
            set { _containerBackColor = value; this.Invalidate(); }
        }

        [Category("Custom Placeholder")]
        public string PlaceholderText
        {
            get => _placeholderText;
            set { _placeholderText = value; this.Invalidate(); }
        }

        [Category("Custom Placeholder")]
        public bool ShowPlaceholder
        {
            get => _showPlaceholder;
            set { _showPlaceholder = value; this.Invalidate(); }
        }

        #endregion

        public CustomDateTimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font("Segoe UI", 10F);

            this.ValueChanged += CustomDateTimePicker_ValueChanged;
        }

        private void CustomDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (_showPlaceholder)
            {
                _showPlaceholder = false;
                this.Invalidate();
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCPAINT = 0x85;
            const int WM_ERASEBKGND = 0x14;

            if (m.Msg == WM_NCPAINT || m.Msg == WM_ERASEBKGND)
            {
                return;
            }
            base.WndProc(ref m);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        private GraphicsPath GetRoundPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 🌟 هنا نستخدم لون الحاوية المخصص الذي حددته لملء الحواف الخارجية لمنع السواد تماماً
            graphics.Clear(_containerBackColor);

            RectangleF clientArea = new RectangleF(1F, 1F, this.Width - 2F, this.Height - 2F);
            RectangleF iconArea = new RectangleF(this.Width - 35, 1F, 34F, this.Height - 2F);

            using (GraphicsPath pathBorder = GetRoundPath(clientArea, _borderRadius))
            using (Pen penBorder = new Pen(_borderColor, _borderSize))
            using (SolidBrush brushSkin = new SolidBrush(_skinColor))
            using (SolidBrush brushText = new SolidBrush(_textColor))
            using (SolidBrush brushPlaceholder = new SolidBrush(_placeholderColor))
            using (SolidBrush brushIcon = new SolidBrush(_iconColor))
            {
                penBorder.Alignment = PenAlignment.Inset;

                // 1. رسم خلفية الكنترول المنعمة
                graphics.FillPath(brushSkin, pathBorder);

                // 2. رسم النص
                Rectangle textLayout = new Rectangle(10, 0, this.Width - 45, this.Height);
                if (_showPlaceholder)
                {
                    graphics.DrawString(_placeholderText, this.Font, brushPlaceholder, textLayout, new StringFormat { LineAlignment = StringAlignment.Center });
                }
                else
                {
                    graphics.DrawString(this.Value.ToString("dd/MM/yyyy"), this.Font, brushText, textLayout, new StringFormat { LineAlignment = StringAlignment.Center });
                }

                // 3. رسم الأيقونة والسهم
                graphics.SetClip(pathBorder);
                graphics.FillRectangle(brushSkin, iconArea);

                Point[] arrowPoints = new Point[]
                {
                new Point(this.Width - 22, (this.Height / 2) - 3),
                new Point(this.Width - 12, (this.Height / 2) - 3),
                new Point(this.Width - 17, (this.Height / 2) + 3)
                };
                graphics.FillPolygon(brushIcon, arrowPoints);
                graphics.ResetClip();

                // 4. رسم الإطار
                if (_borderSize >= 1)
                {
                    graphics.DrawPath(penBorder, pathBorder);
                }
            }
        }
    }
}
