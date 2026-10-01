using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gym
{
    public partial class ucTextBox : UserControl
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int EM_SETMARGINS = 0xD3;
        private const int EC_LEFTMARGIN = 0x1;
        private const int EC_RIGHTMARGIN = 0x2;


        public ucTextBox()
        {
            InitializeComponent();

            txt.HandleCreated += (s, e) => FixCaretClipping();
        }

        private void ucTextBox_Load(object sender, EventArgs e)
        {
            _borderColorBack_up = BorderColor;

            txt.Focus();

            if (string.IsNullOrWhiteSpace(txt.Text) || txt.Text == _PlaceholderText)
            {
                txt.Text = _PlaceholderText;

                txt.ForeColor = _PlaceholderForeColor;

                _isPlaceholderActive = true;
            }
            else
            {
                txt.ForeColor = _foreColor;
                _isPlaceholderActive = false;
            }

            _AdjustTxtBackColor();

            ApplyIconByLanguage();
        }



        public enum InputMode
        {
            Normal,
            NumbersOnly,
            LettersOnly,
            Decimal,
            ReadOnly
        }
        public InputMode TextMode { get; set; } = InputMode.Normal;


        public event Action TextValueChanged;

        public event Action txtLeave;

        public event Action<string> EnterPressed;


        private bool _ClearingPlaceholder = false;

        private bool _ReplacingSelectedText = false;

        private bool _isPlaceholderActive = true;

        private bool _RightAndLeftIconVisible = true;

        private bool _enableEnterPress = false;

        private bool _usePasswordChar = false;

        private bool _MultiLine = false;


        private int _leftIconSize = 25;

        private int _rightIconSize = 25;

        private int _leftIconOffsetX = 0;

        private int _rightIconOffsetX = 0;

        private int _txtOffsetX = 0;


        private string _PlaceholderText = "TextBox";

        private string _TextValue = "";


        private Color _borderColorBack_up = Color.Gainsboro;

        private Color _foreColor = Color.White;

        private Color _PlaceholderForeColor = Color.Gray;


        private Image _leftIconImage = null;
        private Image _rightIconImage = null;


        private bool _isFormattingNumber = false;
        private bool _enableGroupSeparators = true;


        //======================================================= Properties =====================================================

        [Category("TextBox Style")]
        public bool isPlaceholderActive
        {
            get { return _isPlaceholderActive; }
            private set { if (_isPlaceholderActive == value) return; _isPlaceholderActive = value; }
        }


        [Category("TextBox Style")]
        public string PlaceholderText
        {
            get { return _PlaceholderText; }
            set
            {
                if (_PlaceholderText == value) return;
                _PlaceholderText = value;
                txt.Text = _PlaceholderText;
                Invalidate();
            }
        }


        [Category("TextBox Style")]
        public Color PlaceholderForeColor
        {
            get { return _PlaceholderForeColor; }
            set
            {
                if (_PlaceholderForeColor == value) return;
                _PlaceholderForeColor = value;
                txt.ForeColor = _PlaceholderForeColor;
                Invalidate();
            }
        }


        [Category("TextBox Style")]
        public string TextValue
        {
            get
            {
                if (_isPlaceholderActive)
                    return "";

                return txt.Text;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) return;

                _TextValue = value;
                txt.Text = _TextValue;

                if (!string.IsNullOrWhiteSpace(value) && value != _PlaceholderText)
                {
                    _isPlaceholderActive = false;
                    txt.ForeColor = _foreColor;
                }

                Invalidate();
            }
        }


        [Category("TextBox Style")]
        public int BorderRadius
        {
            get => roundedPanel1.BorderRadius;
            set { roundedPanel1.BorderRadius = value; }
        }


        [Category("TextBox Style")]
        public int BorderThickness
        {
            get => roundedPanel1.BorderThickness;
            set { roundedPanel1.BorderThickness = value; }
        }


        [Category("TextBox Style")]
        public Color BorderColor
        {
            get => roundedPanel1.BorderColor;
            set { roundedPanel1.BorderColor = value; }
        }


        [Category("TextBox Style")]
        public LinearGradientMode GradientMode
        {
            get => roundedPanel1.GradientMode;
            set { roundedPanel1.GradientMode = value; }
        }


        [Category("TextBox Style")]
        public bool UnderlineOnly
        {
            get => roundedPanel1.UnderlineOnly;
            set { roundedPanel1.UnderlineOnly = value; }
        }


        [Category("TextBox Style")]
        public Color UnderlineColor
        {
            get => roundedPanel1.UnderlineColor;
            set { roundedPanel1.UnderlineColor = value; }
        }


        [Category("TextBox Style")]
        public Color UnderlineFocusColor
        {
            get => roundedPanel1.UnderlineFocusColor;
            set { roundedPanel1.UnderlineFocusColor = value; }
        }


        [Category("TextBox Style")]
        public int UnderlineThickness
        {
            get => roundedPanel1.UnderlineThickness;
            set { roundedPanel1.UnderlineThickness = value; }
        }


        [Category("TextBox Style")]

        private Color borderFocusColor = Color.DodgerBlue;
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set { borderFocusColor = value; }
        }


        [Category("TextBox Style")]
        public Image LeftIconImage
        {
            get => _leftIconImage;
            set
            {
                if (_leftIconImage == value) return;
                _leftIconImage = value;
                pbLeft.Image = _leftIconImage;
                pbLeft.Visible = _leftIconImage != null;
                AlignControls();
                Invalidate();
            }
        }


        [Category("TextBox Style")]
        public Image RightIconImage
        {
            get => _rightIconImage;
            set
            {
                if (_rightIconImage == value) return;
                _rightIconImage = value;
                pbRight.Image = _rightIconImage;
                pbRight.Visible = _rightIconImage != null;
                AlignControls();
                Invalidate();
            }
        }


        [Category("TextBox Style")]
        public bool RightAndLeftIconVisible
        {
            get => _RightAndLeftIconVisible;
            set { _RightAndLeftIconVisible = value; VisibleIcons(); }
        }


        [Category("TextBox Style")]
        public override RightToLeft RightToLeft
        {
            get => base.RightToLeft;
            set { base.RightToLeft = value; ApplyIconByLanguage(); }
        }


        [Category("TextBox Style")]
        public int LeftIconSize
        {
            get => _leftIconSize;
            set
            {
                _leftIconSize = Math.Max(8, value);
                pbLeft.Size = new Size(_leftIconSize, _leftIconSize);
                AlignControls();
                Invalidate();
            }
        }


        [Category("TextBox Style")]
        public int RightIconSize
        {
            get => _rightIconSize;
            set
            {
                _rightIconSize = Math.Max(8, value);
                pbRight.Size = new Size(_rightIconSize, _rightIconSize);
                AlignControls();
                Invalidate();
            }
        }


        [Category("TextBox Style")]

        private Color _backColor = Color.Black;
        public Color TextBoxBackColor
        {
            get => _backColor;
            set
            {
                _backColor = value;

                if (roundedPanel1 != null)
                {
                    roundedPanel1.FillColor = value;
                    roundedPanel1.FillColor2 = value;
                }

                if (txt != null)
                    _AdjustTxtBackColor();

                Invalidate();
            }
        }


        [Category("TextBox Style")]
        public Color TextBoxForeColor
        {
            get => _foreColor;
            set
            {
                _foreColor = value;
                if (!_isPlaceholderActive)
                    txt.ForeColor = _foreColor;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectionStart
        {
            get => txt.SelectionStart;
            set
            {
                if (txt != null && !_isPlaceholderActive)
                {
                    txt.SelectionStart = Math.Max(0, Math.Min(value, txt.TextLength));
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectionLength
        {
            get => txt.SelectionLength;
            set
            {
                if (txt != null && !_isPlaceholderActive)
                {
                    txt.SelectionLength = Math.Max(0, Math.Min(value, txt.TextLength - txt.SelectionStart));
                }
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }


        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Font Font
        {
            get => base.Font;
            set => base.Font = value;
        }


        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = value;
        }


        [Category("TextBox Style")]
        public Font TextFont
        {
            get => txt.Font;
            set
            {
                if (txt != null) txt.Font = value;

                AlignControls();

                Invalidate();
            }
        }


        [Category("TextBox Style")]
        public int LeftIconOffsetX
        {
            get => _leftIconOffsetX;
            set { _leftIconOffsetX = value; AlignControls(); Invalidate(); }
        }


        [Category("TextBox Style")]
        public int RightIconOffsetX
        {
            get => _rightIconOffsetX;
            set { _rightIconOffsetX = value; AlignControls(); Invalidate(); }
        }


        [Category("TextBox Style")]
        public int TxtOffsetX
        {
            get => _txtOffsetX;
            set { _txtOffsetX = value; AlignControls(); Invalidate(); }
        }


        [Category("TextBox Style")]
        public bool GlowEnabled
        {
            get => roundedPanel1.GlowEnabled;
            set { roundedPanel1.GlowEnabled = value; }
        }


        [Category("TextBox Style")]
        public Color GlowColor
        {
            get => roundedPanel1.GlowColor;
            set { roundedPanel1.GlowColor = value; }
        }


        [Category("TextBox Style")]
        public int GlowSize
        {
            get => roundedPanel1.GlowSize;
            set { roundedPanel1.GlowSize = value; }
        }


        [Category("TextBox Style")]
        public bool EnableEnterPress
        {
            get => _enableEnterPress;
            set { _enableEnterPress = value; }
        }


        [Category("TextBox Style")]
        public bool UsePasswordChar
        {
            get => _usePasswordChar;
            set
            {
                if (_usePasswordChar == value) return;
                _usePasswordChar = value;

                // إذا تم تفعيل كلمة المرور، نلغي الـ Multiline فقط
                if (_usePasswordChar)
                {
                    _MultiLine = false;
                    txt.Multiline = false;
                }

                // تطبيق التشفير فوراً على الـ txt الداخلي
                if (!_isPlaceholderActive)
                {
                    txt.UseSystemPasswordChar = _usePasswordChar;
                }

                Invalidate();
            }
        }


        [Category("TextBox Style")]
        public bool Multiline
        {
            get => _MultiLine;
            set
            {
                if (_MultiLine == value) return; _MultiLine = value; txt.Multiline = value;
                Invalidate();
            }
        }


        [Category("TextBox Style")]
        public bool EnableGroupSeparators
        {
            get => _enableGroupSeparators;
            set { _enableGroupSeparators = value; Invalidate(); }
        }

        [Browsable(false)]
        public string TextValueClean
        {
            get
            {
                if (_isPlaceholderActive) return "";
                return txt.Text.Replace(",", "").Trim();
            }
        }

        [Browsable(false)]
        public decimal DecimalValue
        {
            get
            {
                return decimal.TryParse(TextValueClean, out decimal val) ? val : 0m;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------



        //============================================ Functions ========================================================

        private void FixCaretClipping()
        {
            if (txt.IsHandleCreated)
            {
                int margin = 4; // بكسلات إضافية كهامش أمان للمؤشر
                int lParam = (margin) | (margin << 16); // اليسار واليمين بنفس القيمة
                SendMessage(txt.Handle, EM_SETMARGINS, EC_LEFTMARGIN | EC_RIGHTMARGIN, lParam);
            }
        }

        private void _AdjustTxtBackColor()
        {
            if (_backColor != Color.Transparent)
            {
                txt.BackColor = _backColor;
                return;
            }

            Control parent = this.Parent;

            while (parent != null && parent.BackColor == Color.Transparent)
                parent = parent.Parent;

            txt.BackColor = parent?.BackColor ?? SystemColors.Control;
        }

        private void SwapIconsImages()
        {
            if (RightToLeft == RightToLeft.Yes)
            {
                pbLeft.Image = _rightIconImage;
                pbRight.Image = _leftIconImage;

                if (pbLeft.Size != pbRight.Size)
                {
                    pbLeft.Size = new Size(_rightIconSize, _rightIconSize);
                    pbRight.Size = new Size(_leftIconSize, _leftIconSize);
                }
            }
            else
            {
                pbLeft.Image = _leftIconImage;
                pbRight.Image = _rightIconImage;

                if (pbLeft.Size != pbRight.Size)
                {
                    pbLeft.Size = new Size(_leftIconSize, _leftIconSize);
                    pbRight.Size = new Size(_rightIconSize, _rightIconSize);
                }
            }
        }

        private void ApplyIconByLanguage()
        {
            if (_RightAndLeftIconVisible)
            {
                SwapIconsImages();

                VisibleIcons();
            }
            else
            {
                if (RightToLeft == RightToLeft.Yes)
                {
                    pbLeft.Visible = false;
                    pbRight.Visible = pbRight.Image != null;
                }
                else
                {
                    pbLeft.Visible = pbLeft.Image != null;
                    pbRight.Visible = false;
                }
            }

            AlignControls();
        }

        private void VisibleIcons()
        {
            if (_RightAndLeftIconVisible)
            {
                pbLeft.Visible = pbLeft.Image != null;
                pbRight.Visible = pbRight.Image != null;
            }
            else
            {
                if (RightToLeft == RightToLeft.Yes)
                {
                    pbLeft.Visible = false;
                    pbRight.Visible = pbRight.Image != null;
                }
                else
                {
                    pbLeft.Visible = pbLeft.Image != null;
                    pbRight.Visible = false;
                }
            }

            AlignControls();
        }

        private void AlignControls()
        {
            if (txt == null) return;

            roundedPanel1.Size = this.Size;

            int centerY = roundedPanel1.Height / 2;


            // تحديد أطراف الـ TextBox أفقياً
            int left = pbLeft.Visible ? pbLeft.Right + 4 : 8;
            int right = pbRight.Visible ? pbRight.Left - 4 : this.Width - 8;

            int txtTop;
            int txtHeight;

            // 🌟 منطق الارتفاع والوضع عند Multiline
            if (Multiline)
            {
                pbLeft.Anchor = txt.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                pbRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                // يتمدد من أعلى الـ Panel إلى أسفلها مع ترك هامش داخلي (مثلاً 6 بكسل من الأعلى والأسفل)
                int verticalPadding = 12;
                txtTop = verticalPadding;
                txtHeight = Math.Max(10, this.Height - (verticalPadding * 2));
            }

            else
            {
                // توسيط الأيقونات عمودياً دائماً في منتصف الـ uc الكلي دون تغيير مواضعها
                if (pbLeft != null && pbLeft.Visible)
                    pbLeft.Top = centerY - pbLeft.Height / 2;

                if (pbRight != null && pbRight.Visible)
                    pbRight.Top = centerY - pbRight.Height / 2;

                // مواضع الأيقونات أفقياً
                pbLeft.Left = 8 + LeftIconOffsetX;
                pbRight.Left = this.Width - pbRight.Width - 8 - RightIconOffsetX;

                // الوضع العادي عند Single-Line
                int baseTop = centerY - (txt.Height / 2);
                float fontSize = txt.Font.Size;
                int fontOffset = 0;

                if (fontSize > 12)
                {
                    fontOffset = (int)((fontSize - 12) / 4);
                }

                txtTop = baseTop - fontOffset;
                txtHeight = txt.Height;
            }

            // تطبيق الموقع والأبعاد
            txt.SetBounds(
                left + TxtOffsetX,
                txtTop,
                right - left - TxtOffsetX,
                txtHeight
            );
        }

        private void FormatNumberWithSeparators()
        {
            if (_isFormattingNumber || _isPlaceholderActive) return;

            string rawText = txt.Text;

            if (string.IsNullOrWhiteSpace(rawText) || rawText == _PlaceholderText)
                return;

            _isFormattingNumber = true;

            int selectionStart = txt.SelectionStart;
            int originalLength = rawText.Length;

            // تنظيف الفواصل الحالية لحساب الرقم
            string cleanText = rawText.Replace(",", "").Trim();

            if (decimal.TryParse(cleanText, out decimal number))
            {
                string formattedText = "";

                if (TextMode == InputMode.Decimal && cleanText.Contains("."))
                {
                    string[] parts = cleanText.Split('.');
                    if (decimal.TryParse(parts[0], out decimal integerPart))
                    {
                        formattedText = integerPart.ToString("N0") + "." + (parts.Length > 1 ? parts[1] : "");
                    }
                }
                else
                {
                    formattedText = number.ToString("N0");
                }

                if (txt.Text != formattedText)
                {
                    txt.Text = formattedText;

                    // الحفاظ على موضع المؤشر الصحيح أثناء الكتابة أو الحذف
                    int newLength = formattedText.Length;
                    int newSelectionStart = selectionStart + (newLength - originalLength);

                    if (newSelectionStart >= 0 && newSelectionStart <= txt.Text.Length)
                    {
                        txt.SelectionStart = newSelectionStart;
                    }
                    else
                    {
                        txt.SelectionStart = txt.Text.Length;
                    }
                }
            }

            _isFormattingNumber = false;
        }


        public void txtFocus()
        {
            BeginInvoke(new Action(() =>
            {
                txt.Focus();

                if (_isPlaceholderActive)
                {
                    txt.SelectionStart = 0;
                }
                else
                {
                    txt.SelectionStart = txt.Text.Length;
                }

                txt.SelectionLength = 0;
            }));
        }
        public void txtFocus_SelectAll()
        {
            BeginInvoke(new Action(() =>
            {
                if (_isPlaceholderActive)
                {
                    txt.Focus();
                    txt.SelectionStart = 0;
                    txt.SelectionLength = 0;
                }
                else
                {
                    txt.SelectAll();
                    txt.Focus();
                }
            }));
        }
        public void txtClear_Focus()
        {
            BeginInvoke(new Action(() =>
            {
                txt.Clear();
                txt.Focus();
            }));
            txt.Text = _PlaceholderText;
        }
        public void txtClear()
        {
            txt.Clear();
            txt.Text = _PlaceholderText;
        }

        //-------------------------------------------------------------------------------------------------------------



        //======================================================= Events ================================================

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (BorderThickness > 0)
                roundedPanel1.BorderColor = borderFocusColor;

            if (_isPlaceholderActive)
            {
                BeginInvoke((Action)(() =>
                {
                    txt.SelectionStart = 0;
                    txt.SelectionLength = 0;
                }));
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtLeave?.Invoke();

            if (BorderThickness > 0)
                roundedPanel1.BorderColor = _borderColorBack_up;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (_isPlaceholderActive || TextMode == InputMode.ReadOnly)
            {
                if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Space ||
                    e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right ||
                    e.KeyCode == Keys.Left || e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.CapsLock ||
                    e.KeyCode == Keys.Pause || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Insert)
                {
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.Control && e.KeyCode == Keys.A
                    || e.Alt && e.Shift)
                {
                    e.SuppressKeyPress = true;
                    return;
                }

            }


            if (txt.SelectionLength == txt.TextLength && !char.IsControl((char)e.KeyValue))
            {
                _ReplacingSelectedText = true;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                switch (TextMode)
                {
                    case InputMode.NumbersOnly:

                        if (!char.IsDigit(e.KeyChar))
                        {
                            e.Handled = true;
                            return;
                        }
                        break;

                    case InputMode.LettersOnly:

                        if (!char.IsLetter(e.KeyChar))
                        {
                            e.Handled = true;
                            return;
                        }
                        break;

                    case InputMode.Decimal:

                        bool isDigit = char.IsDigit(e.KeyChar);
                        // قبول . أو , كفاصلة عشرية إذا لم تكن موجودة سابقاً في النص الصافي
                        string cleanTextWithoutSeparators = txt.Text.Replace(",", "");
                        bool isSeparator = (e.KeyChar == ',' || e.KeyChar == '.') && !cleanTextWithoutSeparators.Contains(".");

                        if (!isDigit && !isSeparator)
                        {
                            e.Handled = true;
                            return;
                        }

                        // إذا كتب المستخدم , نحولها تلقائياً إلى . لتوحيد الفاصلة العشرية
                        if (e.KeyChar == ',')
                        {
                            e.KeyChar = '.';
                        }
                        break;

                    case InputMode.ReadOnly:
                        e.Handled = true;
                        return;
                }
            }

            // 2) الحرف مقبول فعلاً وسيُدرج بالنص — الآن فقط امسح الـ Placeholder

            if (_isPlaceholderActive && !char.IsControl(e.KeyChar))
            {
                _ClearingPlaceholder = true;
                _isPlaceholderActive = false;
                txt.Text = "";
                txt.ForeColor = _foreColor;
                _ClearingPlaceholder = false;
            }

            // 3) منع المسافة المزدوجة أو بداية النص بمسافة

            if (e.KeyChar == ' ')
            {
                int cursorPosition = txt.SelectionStart;

                if (cursorPosition == 0)
                {
                    e.Handled = true;
                    return;
                }

                if (txt.Text[txt.SelectionStart - 1] == ' ')
                {
                    e.Handled = true;
                    return;
                }

                if (cursorPosition < txt.TextLength && txt.Text[cursorPosition] == ' ')
                {
                    txt.SelectionStart = cursorPosition + 1;
                    e.Handled = true;
                    return;
                }
            }

            // 4) معالجة Enter

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (_enableEnterPress && !string.IsNullOrWhiteSpace(txt.Text) && !_isPlaceholderActive)
                    EnterPressed?.Invoke(txt.Text.Trim());
            }
        }

        private void txtSearch_MouseDown(object sender, MouseEventArgs e)
        {
            if (_isPlaceholderActive)
            {
                BeginInvoke((Action)(() =>
                {
                    txt.SelectionStart = 0;
                    txt.SelectionLength = 0;
                }));
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_isPlaceholderActive || _isFormattingNumber) // إضافة _isFormattingNumber لحماية المنطق
            {
                return;
            }

            int cursorPosition = txt.SelectionStart;

            txt.ForeColor = _foreColor;

            if (_ClearingPlaceholder)
                return;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                if (_ReplacingSelectedText)
                    return;

                _isPlaceholderActive = true;

                if (_usePasswordChar)
                    txt.UseSystemPasswordChar = false;

                txt.Text = _PlaceholderText;
                txt.ForeColor = _PlaceholderForeColor;

                txt.SelectionStart = 0;
                txt.SelectionLength = 0;
            }
            else if (_usePasswordChar)
            {
                txt.UseSystemPasswordChar = _usePasswordChar;
                txt.SelectionStart = txt.Text.Length;
                txt.SelectionLength = 0;
            }

            _ReplacingSelectedText = false;

            // 🟢 التعديل الجديد هنا: تطبيق الفواصل العلوية للأرقام قبل إطلاق الحدث
            if (_enableGroupSeparators && (TextMode == InputMode.NumbersOnly || TextMode == InputMode.Decimal))
            {
                FormatNumberWithSeparators();
                // إعادة المؤشر لمكانه بعد التنسيق لكي لا يقفز إلى النهاية
                txt.SelectionStart = Math.Min(cursorPosition, txt.Text.Length);
            }

            TextValueChanged?.Invoke();
        }

        private void txtSearch_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isPlaceholderActive && e.Button == MouseButtons.Left)
            {
                txt.SelectionLength = 0;
                txt.SelectionStart = 0;
            }
        }

        //-------------------------------------------------------------------------------------------------------------



        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AlignControls();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            _AdjustTxtBackColor();
        }
    }
}