using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Gym.CustomControls
{
    public partial class ucComboBox : UserControl
    {
        #region ─── Windows 11 DWM Rounding APIs ───

        // استدعاء مكتبة DWM الخاصة بويندوز 11 للتحكم بنمط تدوير النوافذ
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int pvAttribute, int cbAttribute);

        // تعريف الثوابت الخاصة بالتدوير في ويندوز 11
        private const int DWMWA_WINDOW_CORNER_PREFERENCE = 33; // خاصية التحكم بزوايا النافذة
        private const int DWMWCP_ROUND = 2;                    // زوايا دائرية (نمط ويندوز 11 الافتراضي)
        private const int DWMWCP_ROUNDSMALL = 3;               // زوايا دائرية صغيرة (شديدة النعومة والجمال للقمصان البرمجية)

        #endregion

        [StructLayout(LayoutKind.Sequential)]
        private struct COMBOBOXINFO
        {
            public int cbSize;
            public Rectangle rcItem;
            public Rectangle rcButton;
            public int stateButton;
            public IntPtr hwndCombo;
            public IntPtr hwndItem;
            public IntPtr hwndList; // مقبض القائمة المنسدلة
        }

        [DllImport("user32.dll", EntryPoint = "GetComboBoxInfo", CharSet = CharSet.Auto)]
        private static extern bool GetComboBoxInfo(IntPtr hwndCombo, ref COMBOBOXINFO pcbi);

        private Color borderColor = Color.DarkGray;      // لون الإطار الافتراضي
        private Color borderFocusColor = Color.DodgerBlue; // لون الإطار عند التركيز (Focus)
        private bool isFocused = false;                    // لمتابعة حالة التركيز حالياً

        private Color fillColor = Color.White;
        private int verticalPadding = 12;
        private Font _cbFont = new Font("Segoe UI", 9F);

        // متغيرات الـ Placeholder
        private string placeholderText = "";
        private Color placeholderColor = Color.Gray;
        private bool isDroppedDown = false; // لمتابعة حالة القائمة هل هي مفتوحة أم مغلقة

        public ucComboBox()
        {
            InitializeComponent();

            cb.FlatStyle = FlatStyle.Flat;
            cb.BackColor = fillColor;
            cb.DrawMode = DrawMode.OwnerDrawFixed;

            // 🌟 تحديث حالة التركيز وإعادة رسم الإطار فوراً عند الدخول والخروج
            cb.Enter += (s, e) =>
            {
                isFocused = true;
                roundedPanel.BorderColor = borderFocusColor; // تغيير لون إطار البانيل إلى لون التركيز
                roundedPanel.Invalidate();
            };

            cb.Leave += (s, e) =>
            {
                isFocused = false;
                roundedPanel.BorderColor = borderColor; // إعادة لون إطار البانيل إلى اللون الافتراضي
                roundedPanel.Invalidate();
            };

            cb.DropDown += Cb_DropDown;
            cb.DropDownClosed += Cb_DropDownClosed;
            cb.SelectedIndexChanged += Cb_SelectedIndexChanged;
            cb.DrawItem += Cb_DrawItem;

            this.Resize += UcComboBox_Resize;
        }

        #region ─── منطق الـ Placeholder الذكي ───

        private void Cb_DropDown(object sender, EventArgs e)
        {
            isDroppedDown = true;
            cb.Invalidate(); // إعادة رسم الكومبوبوكس فوراً لإخفاء الـ Placeholder بمجرد الفتح

            // جلب معلومات الكومبوبوكس للحصول على مقبض القائمة المنسدلة (hwndList)
            COMBOBOXINFO info = new COMBOBOXINFO();
            info.cbSize = Marshal.SizeOf(info);

            if (GetComboBoxInfo(cb.Handle, ref info))
            {
                IntPtr hwndDropdown = info.hwndList;

                if (hwndDropdown != IntPtr.Zero)
                {
                    // 🌟 السحر الخاص بويندوز 11: إجبار النظام على رسم زوايا دائرية ناعمة جداً (ROUNDSMALL)
                    // يمكنك تغيير القيمة إلى DWMWCP_ROUND (2) لتدوير أكبر، أو DWMWCP_ROUNDSMALL (3) لتدوير ناعم ومتناسق
                    int cornerPreference = DWMWCP_ROUNDSMALL;

                    DwmSetWindowAttribute(hwndDropdown, DWMWA_WINDOW_CORNER_PREFERENCE, ref cornerPreference, sizeof(int));
                }
            }
        }

        private void Cb_DropDownClosed(object sender, EventArgs e)
        {
            isDroppedDown = false;
            cb.Invalidate(); // إعادة الرسم عند الإغلاق لإظهار الـ Placeholder إن لم يتم اختيار قيمة
        }

        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb.Invalidate(); // إعادة الرسم لإظهار القيمة الجديدة أو الـ Placeholder
        }

        // دالة الرسم المخصصة لعناصر الكومبوبوكس والنص الرئيسي
        private void Cb_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;

            // 1. رسم النص الرئيسي للكومبوبوكس (عندما يكون مغلقاً)
            if (e.Index == -1)
            {
                using (SolidBrush bgBrush = new SolidBrush(fillColor))
                {
                    g.FillRectangle(bgBrush, rect);
                }

                // شرط إظهار الـ Placeholder: الكومبوبوكس مغلق + لم يتم اختيار أي قيمة + تم كتابة نص الـ Placeholder
                if (!isDroppedDown && cb.SelectedIndex == -1 && !string.IsNullOrEmpty(placeholderText))
                {
                    TextRenderer.DrawText(g, placeholderText, _cbFont, rect, placeholderColor,
                        TextFormatFlags.VerticalCenter | (RightToLeft == RightToLeft.Yes ? TextFormatFlags.Right : TextFormatFlags.Left));
                }
                return;
            }

            // 2. رسم العناصر داخل القائمة المنسدلة (عند فتحها)
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            string itemText = cb.GetItemText(cb.Items[e.Index]);

            if (isSelected)
            {
                // لون الخلفية عند تمرير الماوس (Hover)
                using (SolidBrush hoverBg = new SolidBrush(hoverBackColor))
                {
                    g.FillRectangle(hoverBg, rect);
                }
                TextRenderer.DrawText(g, itemText, _cbFont, rect, hoverForeColor,
                    TextFormatFlags.VerticalCenter | (RightToLeft == RightToLeft.Yes ? TextFormatFlags.Right : TextFormatFlags.Left));
            }
            else
            {
                // الخلفية العادية للعناصر
                using (SolidBrush normBg = new SolidBrush(fillColor))
                {
                    g.FillRectangle(normBg, rect);
                }
                TextRenderer.DrawText(g, itemText, _cbFont, rect, cb.ForeColor,
                    TextFormatFlags.VerticalCenter | (RightToLeft == RightToLeft.Yes ? TextFormatFlags.Right : TextFormatFlags.Left));
            }
        }

        #endregion

        // دالة الوزن وقص حواف الـ ComboBox تلقائياً
        private void UcComboBox_Resize(object sender, EventArgs e)
        {
            if (cb == null || roundedPanel == null) return;

            int paddingX = Math.Max(12, roundedPanel.BorderRadius / 2);

            cb.Left = paddingX;
            cb.Width = roundedPanel.Width - (paddingX * 2);
            cb.Top = (this.Height - cb.Height) / 2;

            if (cb.Width > 0 && cb.Height > 0)
            {
                cb.Region?.Dispose();
                cb.Region = new Region(new Rectangle(2, 2, cb.Width - 4, cb.Height - 4));
            }
        }

        private void AdjustHeightToFont()
        {
            if (cb == null) return;

            cb.Font = _cbFont;

            // 🌟 التعديل السحري: نغير الارتفاع تلقائياً فقط إذا كانت الخاصية مفعلة
            if (autoHeight)
            {
                this.Height = cb.Height + verticalPadding;
            }

            // إعادة حساب المقاسات وقص الحواف (ستعمل دائماً لتوسيط الكومبوبوكس عمودياً في الحجم اليدوي)
            UcComboBox_Resize(this, EventArgs.Empty);

            roundedPanel.Invalidate();
            this.Invalidate();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (cb != null)
            {
                cb.Font = _cbFont;
            }
            AdjustHeightToFont();
        }

        #region ─── خصائص التحكم بالـ Placeholder ───

        [Category("Custom Placeholder")]
        [Description("النص المؤقت الذي يظهر عندما لا يتم اختيار أي عنصر والقائمة مغلقة")]
        public string PlaceholderText
        {
            get => placeholderText;
            set { placeholderText = value; cb.Invalidate(); }
        }


        [Category("Custom Placeholder")]
        [Description("لون نص الـ Placeholder")]
        public Color PlaceholderColor
        {
            get => placeholderColor;
            set { placeholderColor = value; cb.Invalidate(); }
        }


        #endregion

        #region ─── خصائص التحكم بالـ ComboBox الداخلي (cb) ───


        [Category("Custom ComboBox")]
        [Description("تحديد مصدر البيانات للـ ComboBox")]
        [AttributeProvider(typeof(IListSource))]
        public object DataSource
        {
            get => cb.DataSource;
            set => cb.DataSource = value;
        }


        [Category("Custom ComboBox")]
        [Description("الحقل المراد عرضه من مصدر البيانات")]
        public string DisplayMember
        {
            get => cb.DisplayMember;
            set => cb.DisplayMember = value;
        }


        [Category("Custom ComboBox")]
        [Description("الحقل الذي يمثل القيمة الفعلية للعنصر المحدد")]
        public string ValueMember
        {
            get => cb.ValueMember;
            set => cb.ValueMember = value;
        }


        [Category("Custom ComboBox")]
        [Description("العناصر المضافة يدوياً داخل الـ ComboBox")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
        public ComboBox.ObjectCollection Items => cb.Items;


        [Category("Custom ComboBox")]
        [Description("نمط القائمة المنسدلة (يُفضل DropDownList للمظهر الدائري الفخم)")]
        public ComboBoxStyle DropDownStyle
        {
            get => cb.DropDownStyle;
            set => cb.DropDownStyle = value;
        }


        [Category("Custom ComboBox")]
        [Description("الترتيب المختار حالياً (Index)")]
        public int SelectedIndex
        {
            get => cb.SelectedIndex;
            set { cb.SelectedIndex = value; cb.Invalidate(); }
        }


        [Category("Custom ComboBox")]
        [Description("العنصر المحدد حالياً كـ Object")]
        public object SelectedItem
        {
            get => cb.SelectedItem;
            set { cb.SelectedItem = value; cb.Invalidate(); }
        }


        [Category("Custom ComboBox")]
        [Description("القيمة المحددة حالياً بناءً على الـ ValueMember")]
        public object SelectedValue
        {
            get => cb.SelectedValue;
            set { cb.SelectedValue = value; cb.Invalidate(); }
        }


        [Category("Custom ComboBox")]
        [Description("النص المكتوب أو المعروض حالياً")]
        public override string Text
        {
            get => cb.Text;
            set { cb.Text = value; cb.Invalidate(); }
        }


        [Category("Custom ComboBox")]
        [Description("خط النص داخل القائمة المنسدلة")]
        public Font cbFont
        {
            get => _cbFont;
            set
            {
                _cbFont = value;
                if (cb != null)
                {
                    cb.Font = value;
                }
                AdjustHeightToFont();
            }
        }


        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }


        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = value;
        }


        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Font Font
        {
            get => base.Font;
            set => base.Font = value;
        }


        [Category("Custom ComboBox")]
        [Description("لون النص المعروض")]
        public Color cbForeColor
        {
            get => cb.ForeColor;
            set => cb.ForeColor = value;
        }


        [Category("Custom Design")]
        [Description("الهامش العمودي الإضافي للتحكم بارتفاع وحجم العنصر بالنسبة للخط")]
        public int VerticalPadding
        {
            get => verticalPadding;
            set
            {
                verticalPadding = Math.Max(0, value);
                AdjustHeightToFont();
            }
        }
     

        [Category("Custom Design")]
        [Description("عند تفعيلها، سيتم تغيير ارتفاع الأداة تلقائياً ليناسب حجم الخط. عند إلغائها، يمكنك تحديد الارتفاع يدوياً.")]

        private bool autoHeight = false; // افتراضياً false لكي يحترم الحجم الذي تحدده يدوياً
        public bool AutoHeight
        {
            get => autoHeight;
            set
            {
                autoHeight = value;
                AdjustHeightToFont(); // تحديث الحجم فوراً عند تغيير الخاصية
            }
        }
      

        [Category("Custom Design")]
        [Description("لون خلفية العنصر عند تمرير الماوس فوقه في القائمة")]

        private Color hoverBackColor = Color.FromArgb(240, 244, 255);       
        public Color HoverBackColor
        {
            get => hoverBackColor;
            set { hoverBackColor = value; cb.Invalidate(); }
        }


        [Category("Custom Design")]
        [Description("لون خط العنصر عند تمرير الماوس فوقه في القائمة")]

        private Color hoverForeColor = Color.DodgerBlue;
        public Color HoverForeColor
        {
            get => hoverForeColor;
            set { hoverForeColor = value; cb.Invalidate(); }
        }



        #endregion

        #region ─── خصائص التحكم بشكل الـ RoundedPanel المحيطة ───


        [Category("Custom Design")]
        [Description("درجة تدوير الحواف للبانيل")]
        public int BorderRadius
        {
            get => roundedPanel.BorderRadius;
            set { roundedPanel.BorderRadius = value; roundedPanel.Invalidate(); UcComboBox_Resize(this, EventArgs.Empty); }
        }


        [Category("Custom Design")]
        [Description("سماكة إطار البانيل")]
        public int BorderThickness
        {
            get => roundedPanel.BorderThickness;
            set { roundedPanel.BorderThickness = value; roundedPanel.Invalidate(); }
        }


        [Category("Custom Design")]
        [Description("لون إطار الأداة في الحالة العادية")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                if (!isFocused) // إذا لم تكن الأداة تحت التركيز، قم بتطبيق اللون فوراً
                {
                    roundedPanel.BorderColor = value;
                    roundedPanel.Invalidate();
                }
            }
        }


        [Category("Custom Design")]
        [Description("لون إطار الأداة عندما يتم تحديدها أو التركيز عليها (Focus)")]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set
            {
                borderFocusColor = value;
                if (isFocused) // إذا كانت الأداة تحت التركيز حالياً، قم بتحديث اللون فوراً
                {
                    roundedPanel.BorderColor = value;
                    roundedPanel.Invalidate();
                }
            }
        }


        [Category("Custom Design")]
        [Description("لون خلفية البانيل والكومبوبوكس")]
        public Color FillColor
        {
            get => fillColor;
            set
            {
                fillColor = value;
                roundedPanel.FillColor = value;
                roundedPanel.FillColor2 = value;
                cb.BackColor = value;
                roundedPanel.Invalidate();
            }
        }

     
        #endregion

        #region ─── الأحداث الأساسية الممررة (Events Forwarding) ───

        [Category("Custom Events")]
        [Description("يحدث عند تغيير العنصر المحدد في القائمة")]
        public event EventHandler SelectedIndexChanged
        {
            add => cb.SelectedIndexChanged += value;
            remove => cb.SelectedIndexChanged -= value;
        }

        [Category("Custom Events")]
        [Description("يحدث عند تغيير قيمة العنصر المحدد")]
        public event EventHandler SelectedValueChanged
        {
            add => cb.SelectedValueChanged += value;
            remove => cb.SelectedValueChanged -= value;
        }

        [Category("Custom Events")]
        [Description("يحدث عند كتابة أو تغيير النص بالداخل")]
        public new event EventHandler TextChanged
        {
            add => cb.TextChanged += value;
            remove => cb.TextChanged -= value;
        }

        #endregion
    }
}
