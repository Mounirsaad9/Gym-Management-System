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

namespace Gym.CustomConstrols
{
    public partial class CustomToggleSwitch : CheckBox
    {
        private Color _onBackColor = Color.FromArgb(46, 204, 113);  // اللون الأخضر عند التفعيل
        private Color _offBackColor = Color.FromArgb(44, 52, 69);   // اللون الداكن عند عدم التفعيل
        private Color _toggleColor = Color.White;                   // لون الدائرة البيضاء
        private Color _containerBackColor = Color.FromArgb(28, 35, 54); // لون البانيل المحيط

        #region ─── الخصائص العلنية (Properties) ───

        [Category("Custom Design")]
        [Description("لون الخلفية عندما يكون التبديل مفعلاً (Checked = True)")]
        public Color OnBackColor
        {
            get => _onBackColor;
            set { _onBackColor = value; this.Invalidate(); }
        }

        [Category("Custom Design")]
        [Description("لون الخلفية عندما يكون التبديل غير مفعل (Checked = False)")]
        public Color OffBackColor
        {
            get => _offBackColor;
            set { _offBackColor = value; this.Invalidate(); }
        }

        [Category("Custom Design")]
        [Description("لون الدائرة المتحركة (المقبض)")]
        public Color ToggleColor
        {
            get => _toggleColor;
            set { _toggleColor = value; this.Invalidate(); }
        }

        [Category("Custom Design")]
        [Description("لون الحاوية أو البانيل الذي توضع الأداة داخله لدمج الحواف تماماً")]
        public Color ContainerBackColor
        {
            get => _containerBackColor;
            set { _containerBackColor = value; this.Invalidate(); }
        }

        // إخفاء خاصية النص الافتراضية لمنع كتابة نصوص مشوهة داخل جسم الـ Switch
        [Browsable(false)]
        public override string Text
        {
            get => base.Text;
            set => base.Text = "";
        }

        #endregion

        public CustomToggleSwitch()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            // 🌟 السر هنا: إلغاء الحجم التلقائي لكي يسمح لك الـ Designer بتكبيره وتصغيره يدوياً كالبوتون تماماً
            this.AutoSize = false;

            // مقاس افتراضي عند السحب أول مرة
            this.Size = new Size(60, 30);
            this.Cursor = Cursors.Hand;
        }

        // إجبار الكنترول على إعادة الرسم فوراً أثناء قيامك بشد الحواف بالماوس في الـ Designer
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        private GraphicsPath GetTogglePath(RectangleF rect)
        {
            GraphicsPath path = new GraphicsPath();
            float arcSize = rect.Height;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, arcSize, arcSize, 90, 180);
            path.AddArc(rect.Right - arcSize, rect.Y, arcSize, arcSize, 270, 180);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            graphics.Clear(_containerBackColor);

            // حساب منطقة الرسم ديناميكياً بناءً على الحجم الذي تحدده أنت بالماوس
            RectangleF baseRect = new RectangleF(1F, 1F, this.Width - 2F, this.Height - 2F);

            // حساب قطر الدائرة ليكون متناسقاً ونشطاً مع الارتفاع المختار يدوياً
            float toggleSize = this.Height - 8F;

            float toggleX;
            if (this.Checked)
            {
                // عند التفعيل: الدائرة تتحرك ديناميكياً إلى نهاية العرض المختار يدوياً
                toggleX = this.Width - toggleSize - 5F;
            }
            else
            {
                toggleX = 5F;
            }

            RectangleF toggleRect = new RectangleF(toggleX, 4F, toggleSize, toggleSize);
            Color currentBackColor = this.Checked ? _onBackColor : _offBackColor;

            using (GraphicsPath pathBase = GetTogglePath(baseRect))
            using (SolidBrush brushBack = new SolidBrush(currentBackColor))
            using (SolidBrush brushToggle = new SolidBrush(_toggleColor))
            {
                graphics.FillPath(brushBack, pathBase);
                graphics.FillEllipse(brushToggle, toggleRect);
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_ERASEBKGND = 0x14;
            if (m.Msg == WM_ERASEBKGND) return;
            base.WndProc(ref m);
        }
    }
}

