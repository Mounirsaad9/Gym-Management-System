using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class BaseForm : Form
    {
        #region Win32 Interop (لتلوين شريط الويندوز العلوي)

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_CAPTION_COLOR = 35;

        #endregion

        private Color _titleBarColor = Color.Empty;
        private Timer _fadeInTimer;

        [Category("Appearance")]
        [Description("لون شريط العنوان العلوي الأصلي لنظام التشغيل (يعمل على Windows 11+)")]
        public Color TitleBarColor
        {
            get => _titleBarColor;
            set
            {
                _titleBarColor = value;
                ApplyTitleBarColor();
            }
        }

        public BaseForm()
        {
            // البدء بالفورم شفافاً لعمل تأثير الـ Fade In الاحترافي
            this.Opacity = 0;

            // تفعيل التخزين المزدوج لمنع وميض وتأخر رسم العناصر المخصصة (Custom Controls)
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);
            UpdateStyles();

            // الإعداد الافتراضي لإطار شاشات المشروع
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // منع تشغيل التايمر داخل البيئة التصميمية للفيجوال ستوديو
            if (!DesignMode)
            {
                InitAndStartFadeIn();
            }
        }

        private void InitAndStartFadeIn()
        {
            _fadeInTimer = new Timer();
            _fadeInTimer.Interval = 15; // تأثير سلس جداً متوافق مع الشاشات السريعة
            _fadeInTimer.Tick += (s, e) =>
            {
                if (this.Opacity < 1.0)
                {
                    this.Opacity += 0.15;
                }
                else
                {
                    this.Opacity = 1.0;
                    StopAndDisposeTimer();
                }
            };
            _fadeInTimer.Start();
        }

        private void StopAndDisposeTimer()
        {
            if (_fadeInTimer != null)
            {
                _fadeInTimer.Stop();
                _fadeInTimer.Dispose();
                _fadeInTimer = null;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            StopAndDisposeTimer();
            base.OnFormClosed(e);
        }

        // دالة احترافية للاختفاء السلس عند إغلاق النافذة
        protected async void CloseWithFadeOut()
        {
            try
            {
                StopAndDisposeTimer();

                for (double op = this.Opacity; op > 0; op -= 0.15)
                {
                    this.Opacity = op;
                    await Task.Delay(15);
                }

                this.Opacity = 0;
                this.Close();
            }
            catch
            {
                this.Close(); // لضمان الإغلاق في حال حدوث أي خطأ طارئ
            }
        }

        // 🌟 الدالة المطلوبة لتدوير حواف الفورم
        protected void ApplyRoundedCorners()
        {
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int r = 20; // يمكنك تغيير هذا الرقم للتحكم في درجة دائرية الحواف
                path.AddArc(0, 0, r * 2, r * 2, 180, 90);
                path.AddArc(Width - r * 2, 0, r * 2, r * 2, 270, 90);
                path.AddArc(Width - r * 2, Height - r * 2, r * 2, r * 2, 0, 90);
                path.AddArc(0, Height - r * 2, r * 2, r * 2, 90, 90);
                path.CloseFigure();
                this.Region = new Region(path);
            }
        }

        private void ApplyTitleBarColor()
        {
            if (!IsHandleCreated || _titleBarColor.IsEmpty) return;

            // تحويل اللون إلى صيغة COLORREF التي يفهمها الويندوز API
            int colorRef = _titleBarColor.R | (_titleBarColor.G << 8) | (_titleBarColor.B << 16);
            DwmSetWindowAttribute(Handle, DWMWA_CAPTION_COLOR, ref colorRef, sizeof(int));
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            // تطبيق تدوير الحواف وتلوين العنوان تلقائياً بمجرد إنشاء هاندل الفورم
           // ApplyRoundedCorners();
            ApplyTitleBarColor();
        }

        // إعادة تطبيق الحواف الدائرية إذا قام المستخدم بتغيير حجم الفورم برمجياً لضمان عدم تشوه الأبعاد
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            //ApplyRoundedCorners();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                StopAndDisposeTimer();
            }
            base.Dispose(disposing);
        }
    }
}
