using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp
{
    public partial class Text_Box_Custom : UserControl
    {
        #region Enum
        public enum eValidationType
        {
            OnlyLetter,
            OnlyNumber,
            NumberAndLetter,
            SpecialChar,
            IsValidEmail,
        }

        #endregion
        #region Custom Field
        /// <summary>
        /// Thuộc tính dùng để gán và truy xuất giá trị của label
        /// </summary>
        [Category(CategoryDisplay)]
        public string Label
        {
            get { return label1.Text; }
            set
            {
                label1.Text = value;
                this.Invalidate();
            }
        }
        //public async void ErrorLable(bool status)
        //{
        //    if (status)
        //    {
        //        lblError.Show();
        //        await Task.Delay(5000);
        //        lblError.Hide();
        //        errorProvider.SetError(txt, null);
        //        //return;
        //    }
        //    else
        //    {
        //        lblError.Hide();
        //        errorProvider.SetError(txt, null);
        //    }
        //}
        
        public ErrorProvider errorProvider1 { get; set; }


        /// <summary>
        ///  Clears all text from the text box control without validation not null .
        /// </summary>


        /// <summary>
        /// Thuộc tính dùng để gán và lấy giá trị của input 
        /// </summary>
        [Category(CategoryDisplay)]
        public override string? Text
        {
            get { return txt.Text; }
            set { txt.Text = value; }
        }
        /// <summary>
        /// Thuộc tính dùng để gán và lấy giá trị lỗi của quá trình validation
        /// </summary>
        [Category(CategoryDisplay)]
        public string Error
        {
            get
            {
                if (!DesignMode)
                {
                    // Allow null
                    if (AllowNull)
                    {
                        if (lblError.Text == EMAIL_FORMAT)
                        {
                            if (txt.Text != null)
                            {
                                return EMAIL_FORMAT;
                            }
                        }
                        else
                        {
                            return string.Empty;
                        }
                    }

                    if (txt.Text == null || txt.Text == string.Empty)
                    {
                        lblError.Show();
                        lblError.Text = NOT_NULL;
                        errorProvider.SetError(txt, NOT_NULL);
                        lblError.Focus();
                        return NOT_NULL;
                    }
                    return lblError.Text;
                }
                return string.Empty;
            }
            set
            {
                lblError.Show();
                lblError.Text = value;
                //txt.Focus();
                errorProvider.SetError(txt, value);
                timer1.Start();
            }
        }
        [Category(CategoryDisplay)]
        public bool AllowNull { get; set; } = true;

        [Category(CategoryDisplay)]
        public bool ReadOnly { get { return txt.ReadOnly; } set { txt.ReadOnly = value; } }

        [Category(CategoryDisplay)]
        public eValidationType @ValidationType { get; set; } = eValidationType.SpecialChar;

        [Category(CategoryDisplay)]
        public bool AllowWhiteSpace { get; set; } = true;
        [Category(CategoryDisplay)]
        public int MinimumChar { get; set; }
        #endregion

        #region Make Color


        [Category("RJ Code Advance")]
        public bool Multiline
        {
            get { return txt.Multiline; }
            set { txt.Multiline = value; }
        }

        [Category("RJ Code Advance")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                txt.BackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                txt.ForeColor = value;
            }
        }
        #endregion
        public Text_Box_Custom()
        {
            InitializeComponent();
        }
        private void TextBoxCustom_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                lblError.Text = string.Empty;
                errorProvider.SetIconPadding(txt, -20);
            }
        }
        // Message Error
        public const string NOT_NULL = "Không được để trống!";
        const string SPECIAL_CHARACTER = "Kí tự vừa nhập không hợp lệ!";
        const string ONLY_LETTER_AND_DIGIT = "Chỉ được chứa chữ và số!";
        const string OUT_RANGE_SPECIAL_CHARACTER = "Chứa kí tự không hợp lệ!";
        const string ONLY_DIGIT = "Chỉ chứa chữ!";
        const string ONLY_NUMBER = "Chỉ chứa số!";
        const string NO_WHITE_SPACE = "Không được có khoảng trắng!";
        const string EMAIL_FORMAT = "Sai định dạng email";
        const string MINIMUM_CHARACTER = "Kí tự tối thiểu là ";
        // Category
        const string CategoryDisplay = "Input Validation";

        //Overridden methods
        //Events
        #region Event Exposing
        public event EventHandler UCTextChanged
        {
            add
            {
                txt.TextChanged += value;
            }
            remove { txt.TextChanged -= value; }
        }

        public event KeyPressEventHandler UCKeyPress
        {
            add
            {
                txt.KeyPress += value;
            }
            remove { txt.KeyPress -= value; }
        }
        #endregion

        #region Pre-Validation Input
        private bool isEnableTextChanged = true;
        /// <summary>
        /// Sự kiện này sẽ được thực thi đầu tiên => validate cơ bản cho input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow backspace control except (Esc, Enter,...)
            if (Char.IsControl(e.KeyChar) && e.KeyChar != ((char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        public async void txt_TextChanged(object sender, EventArgs e)
        {
            if (!isEnableTextChanged)
            {
                return;
            }
            timer1.Start();
            Error = string.Empty;
            TextBox textbox = (TextBox)sender;
            // Case 1: Báo lỗi nếu có giá trị bằng rỗng
            if (!AllowNull && textbox.Text == string.Empty)
            {
                lblError.Show();
                Error = NOT_NULL;
                //await Task.Delay(5000);
                //lblError.Hide();
                //errorProvider.SetError(txt, "");
                return;
            }

            // case 2: Báo lỗi nếu chứa khoảng trắng
            if (!AllowWhiteSpace && textbox.Text.Any(s => Char.IsWhiteSpace(s)))
            {
                Error = NO_WHITE_SPACE;
                return;
            }
            // case 3: Báo lỗi nếu chứa kí tự đặc biệt
            if (textbox.Text.Any(s => Char.IsControl(s)))
            {
                Error = SPECIAL_CHARACTER;
                return;
            }
            // case 3: Báo lỗi nếu chưa đủ ký tự tối thiểu
            if (textbox.Text.Length < MinimumChar)
            {
                Error = MINIMUM_CHARACTER + MinimumChar;
                return;
            }

            switch (ValidationType)
            {
                case eValidationType.OnlyLetter:
                    {
                        OnlyLetterHandler(textbox.Text);
                    }; break;
                case eValidationType.OnlyNumber:
                    {
                        OnlyNumberHandler(textbox.Text);
                    }; break;
                case eValidationType.NumberAndLetter:
                    {
                        NumberAndLetterHandler(textbox.Text);
                    }; break;
                case eValidationType.SpecialChar:
                    {
                        SpecialCharHandler(textbox.Text);
                    }; break;
                case eValidationType.IsValidEmail:
                    {
                        IsValidEmail(textbox.Text);
                    }; break;
                default:
                    {

                    }; break;
            }
        }

        private void SpecialCharHandler(string text)
        {
            // Báo lỗi nếu chứa kí tự không được phép trong regex
            string pattern = "([^\\u0000-\\u007F]|\\w| |[!@#%^&*()_+-={}|;':\\\",./<>?~`])+";
            Regex rg = new Regex(pattern);
            if (!text.All(s => rg.IsMatch(s.ToString())))
            {
                Error = OUT_RANGE_SPECIAL_CHARACTER;
            }
        }
        private void IsValidEmail(string text)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            if (text != "")
            {
                if (!regex.IsMatch(text))
                {
                    Error = EMAIL_FORMAT;
                }
            }
        }
        private void NumberAndLetterHandler(string text)
        {
            // Báo lỗi nếu kí tự không phải, chữ, số hoặc khoảng trắng
            if (!text.All(s => Char.IsLetterOrDigit(s) || Char.IsWhiteSpace(s)))
            {
                Error = ONLY_LETTER_AND_DIGIT;
            }
        }

        private void OnlyLetterHandler(string text)
        {
            // Báo lỗi nếu kí tự không phải là chữ hoặc khoảng trắng
            if (!text.All(s => Char.IsLetter(s) || Char.IsWhiteSpace(s)))
            {
                Error = ONLY_DIGIT;
            }
        }
        private void OnlyNumberHandler(string text)
        {
            // Báo lỗi nếu kí tự không phải là số
            if (!text.All(s => Char.IsDigit(s)))
            {
                Error = ONLY_NUMBER;
            }
            //test
        }
        #endregion

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (lblError.Text != "" && txt.Text == "")
            {
                lblError.Hide();
                errorProvider.SetError(txt, null);
            }
            else if (lblError.Text == "User Name đã tồn tại" || lblError.Text == "Mã sản phẩm đã tồn tại" || lblError.Text == "Tên sản phẩm đã tồn tại")
            {
                lblError.Text = null;
                errorProvider.SetError(txt, null);
            }
        }
        public void showError()
        {
            lblError.Show();
        }
    }
}
