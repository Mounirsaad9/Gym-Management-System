using Gym.CustomControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gym
{
    public partial class BaseUserControl : UserControl
    {
        public BaseUserControl()
        {
            // تفعيل التخزين المزدوج لمنع الوميض أثناء التكبير والسحب
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);
            UpdateStyles();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // منع التنفيذ داخل الـ Designer لتجنب مشاكل التصميم
            if (!DesignMode)
            {
                AutoSetAnchors(this);
            }
        }

        // دالة المحاذاة التلقائية للعناصر الداخلية
        private void AutoSetAnchors(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // 1. الجدول المخصص: يتمدد في الاتجاهات الأربعة وتتوزع الأعمدة تلقائياً
                if (ctrl is CustomDataGridView dgv)
                {
                    dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                // 2. حقول النصوص المخصصة: تتمدد بعرض الشاشة تلقائياً
                //else if (ctrl is ucTextBox)
                //{
                //    ctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                //}

                // 3. البحث الشجري داخل الحوايا (RoundedPanel أو Panel أو GroupBox)
                if (ctrl.HasChildren || ctrl is RoundedPanel)
                {
                    AutoSetAnchors(ctrl);
                }
            }
        }
    }
}