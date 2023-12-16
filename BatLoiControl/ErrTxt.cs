using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;



public class ErrTxt
{
    Label lblHint;
    Panel pnError;
    ErrColors errColors = new ErrColors();
    public Label LblHint { get => lblHint; set => lblHint = value; }
    public Panel PnError { get => pnError; set => pnError = value; }

    public ErrTxt(Form frm)
    {
        lblHint = new Label();
        pnError = new Panel();
        //label 
        lblHint.Text = string.Empty;
        LblHint.AutoSize = false;
        LblHint.Dock = DockStyle.Fill;
        LblHint.TextAlign = ContentAlignment.TopCenter;
        LblHint.Font = new Font("Arial", 12);
        LblHint.ForeColor = errColors.mes_white;

        //panel 
        PnError.Dock = DockStyle.Top;
        PnError.Height = LblHint.Size.Height;
        PnError.Controls.Add(LblHint);
        frm.Controls.Add(PnError);
    }


    /// <summary>
    /// Chặn nhập số
    /// </summary>
    /// <param name="e"></param>
    /// <returns>Return true if is number</returns>
    public static bool NoNumber_KeyPress(KeyPressEventArgs e)
    {
        Regex regex = new Regex("[0-9]");
        bool isNumber = regex.IsMatch(e.KeyChar.ToString());
        if (isNumber)
        {
            // Không cho phép gõ tiếp
            return true;
        }
        else
        {
            // Cho phép gõ tiếp
            return false;
        }
    }
    /// <summary>
    /// Không nhập chữ key press
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public static bool NoText_KeyPress(KeyPressEventArgs e)
    {
        // Khớp với bất kỳ ký tự chữ cái nào
        Regex regex = new Regex("[a-zA-Z]");
        bool isText = regex.IsMatch(e.KeyChar.ToString());
        return isText;
    }


    /// <summary>
    /// Cho phép các ký tự số và ký tự điều khiển như backspace
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <returns>return true if have symbol</returns>
    internal static bool NoSymbol_KeyPress(KeyPressEventArgs e)
    {
        // Kiểm tra tất cả các ký tự không phải là chữ và số
        Regex regex = new Regex("[!@#$%^&*()_\\-=*/]");
        bool isSymbol = regex.IsMatch(e.KeyChar.ToString());
        if (isSymbol)
        {
            // Không cho phép gõ tiếp
            return true;
        }
        else
        {
            // Cho phép gõ tiếp
            return false;
        }
    }
    /// <summary>
    /// Ngừng nhập khoảng trắng textbox
    /// </summary>
    /// <param name="sender">Textbox sender</param>
    /// <param name="e">Nhấn xuống event</param>
    /// <returns>Return true if no have space</returns>
    public static bool NoSpace_KeyPress(KeyPressEventArgs e)
    {
        // Kiểm tra xem phím được nhấn có phải là khoảng trắng hay không
        Regex regex = new Regex("[ ]");
        bool isSpace = regex.IsMatch(e.KeyChar.ToString());
        if (isSpace)
        {
            // Không cho phép gõ tiếp
            return true;
        }
        else
        {   // Cho phép gõ tiếp
            return false;
        }
    }
    /// <summary>
    /// Không nhập số
    /// </summary>
    /// <param name="sender"></param>
    /// <returns>return true if  have number</returns>
    public static bool NoNumber_TextChange(object sender)
    {
        Control c = (Control)sender;
        // Khớp với bất kỳ ký tự số nào
        Regex regex = new Regex("[0-9]");
        bool isNumber = regex.IsMatch(c.Text.ToString());
        // check input string
        if (isNumber)
        {
            // Detected number input
            return true;
        }
        else
        {
            // Detected text input!
            return false;
        }
    }

    /// <summary>
    /// Không nhập text
    /// </summary>
    /// <param name="sender"></param>
    /// <returns></returns>
    public static bool NoText_TextChange(object sender)
    {
        Control c = (Control)sender;
        // Only allow digits
        Regex regex = new Regex("[a-zA-ZeéèẻẽẹêếềễểệaáàảãạăắằẵẳặâấầẩẫậoóòỏõọơớờỡởợôốồổỗộuúùũủụưứừữửựiíìỉĩịyýỳỷỹỵđEÉÈẺẼẸÊẾỀỄỂỆAÁÀẢÃẠĂẮẰẴẲẶÂẤẦẨẪẬOÓÒỎÕỌƠỚỜỠỞỢÔỐỒỔỖỘUÚÙŨỦỤƯỨỪỮỬỰIÍÌỈĨỊYÝỲỶỸỴĐ]");
        bool isText = regex.IsMatch(c.Text.ToString());
        // check input string
        if (isText)
        {
            // Detected text input!
            return true;
        }

        else
        {   // Detected number input
            return false;
        }
    }
    /// <summary>
    /// Không nhập symbol !@#$%^&*()_+/*=-
    /// </summary>
    /// <param name="sender"></param>
    /// <returns>return true if no have symbol</returns>
    public static bool NoSymbol_TextChanged(object sender)
    {
        Control c = (Control)sender;
        Regex regex = new Regex("[!@#$%^&*()_\\-=*/]");
        bool isSymbol = regex.IsMatch(c.Text.ToString());
        // check input string
        if (isSymbol)
        {
            // phát hiện nhập ký tự đặc biệt
            return true;
        }
        // nhap ok!
        else
        {
            return false;
        }
    }
    /// <summary>
    /// Không nhập space
    /// </summary>
    /// <param name="sender"></param>
    /// <returns>true if no space</returns>
    public static bool NoSpace_TextChange(object sender)
    {
        TextBox c = (TextBox)sender;
        Regex regex = new Regex("[ ]");
        bool isSpace = regex.IsMatch(c.Text.ToString());
        if (isSpace)
        {
            return true;
        }
        // nhap ok!
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Không nhập đủ số lượng kí tự
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns>return true if enough length</returns>
    public static bool NoMinMax_TextChanged(object sender, int min = 3, int max = 16)
    {
        Control c = (Control)sender;
        string patern = "a-zA-Z0-9 !@#$%^&*()_+*/-eéèẻẽẹêếềễểệaáàảãạăắằẵẳặâấầẩẫậoóòỏõọơớờỡởợôốồổỗộuúùũủụưứừữửựiíìỉĩịyýỳỷỹỵđEÉÈẺẼẸÊẾỀỄỂỆAÁÀẢÃẠĂẮẰẴẲẶÂẤẦẨẪẬOÓÒỎÕỌƠỚỜỠỞỢÔỐỒỔỖỘUÚÙŨỦỤƯỨỪỮỬỰIÍÌỈĨỊYÝỲỶỸỴĐ";
        Regex regex = new Regex(@"[" + patern + "]" + "{" + min + "," + max + "}$");
        bool isMinMax = regex.IsMatch(c.Text.ToString());
        if (c.Text.Length < 3 || c.Text.Length > max)
        {
            return false;
        }

        if (isMinMax)
        {
            //Phat hiện nhập chưa đủ kí tự
            return false;
        }
        // nhập ok!
        else
        {
            // nhập chính xác
            return true;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    public static bool NoMinMax_KeyPress(object sender, int min = 3, int max = 16)
    {
        TextBox c = (TextBox)sender;
        c.MaxLength = max;

        if (c.Text.Length < min)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /// <summary>
    /// Kiểm tra giá trị nhập của control
    /// </summary>
    /// <param name="sender"></param>
    /// <returns>True: giá trị null hoặc empty</returns>
    public static bool CheckControlValue(object sender)
    {
        if (sender == null)
        {
            return false;
        }


        string value = string.Empty;
        Control control = (Control)sender;
        if (control is TextBox)
        {
            value = ((TextBox)control).Text;
        }
        else if (control is ComboBox)
        {
            value = ((ComboBox)control).Text;
        }
        else if (control is DateTimePicker)
        {
            value = ((DateTimePicker)control).Value.ToString();
        }
        else if (control is RichTextBox)
        {
            value = ((RichTextBox)control).Text;
        }


        return string.IsNullOrEmpty(value);
    }



    /**
     * usage space
     * Số điện thoại sử dụng nosymnumminmax change được phép có dấu cách ra vd: 0924 964 226
     */
    public void NoSymTextSpaceMinMaxPress(object sender, KeyPressEventArgs e, int max = 16, int min = 3)
    {
        e.Handled = false;
        if (NoSymbol_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập ký tự đặc biệt";
            //PnError.BackColor = errColors.err_txt_nosymbol;
        }
        else if (NoText_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập chữ";
            //PnError.BackColor = errColors.err_txt_notext;

        }
        else if (NoSpace_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập khoảng trắng";
            //PnError.BackColor = errColors.err_txt_nospace;
        }
        else if (NoMinMax_KeyPress(sender, min, max))
        {
            //lblHint.Text = "Không nhập đủ hoặc dư số lượng ký tự";
            //PnError.BackColor = errColors.err_txt_minmax_length;
        }
        else
        {
            //lblHint.Text = "Nhập ok!";
            //PnError.BackColor = errColors.mes_success;
            e.Handled = false;
        }
    }

    public void NoSymTextSpacePress(KeyPressEventArgs e)
    {
        e.Handled = false;
        if (NoSymbol_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập ký tự đặc biệt";
            //PnError.BackColor = errColors.err_txt_nosymbol;
        }
        else if (NoText_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập chữ";
            //PnError.BackColor = errColors.err_txt_notext;

        }
        else if (NoSpace_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập khoảng trắng";
            //PnError.BackColor = errColors.err_txt_nospace;
        }

        else
        {
            //lblHint.Text = "Nhập ok!";
            //PnError.BackColor = errColors.mes_success;
            e.Handled = false;
        }
    }

    public void NoSymTextMinMaxPress(object sender, KeyPressEventArgs e, int max = 16, int min = 3)
    {
        e.Handled = false;
        if (NoSymbol_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập ký tự đặc biệt";
            //PnError.BackColor = errColors.err_txt_nosymbol;
        }
        else if (NoText_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập chữ";
            //PnError.BackColor = errColors.err_txt_notext;

        }
        else if (NoMinMax_KeyPress(sender, min, max))
        {
            //lblHint.Text = "Không nhập đủ hoặc dư số lượng ký tự";
            //PnError.BackColor = errColors.err_txt_minmax_length;
        }
        else
        {
            //lblHint.Text = "Nhập ok!";
            //PnError.BackColor = errColors.mes_success;
            e.Handled = false;
        }
    }

    public void NoSymTextPress(KeyPressEventArgs e)
    {
        e.Handled = false;
        if (NoSymbol_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập ký tự đặc biệt";
            //PnError.BackColor = errColors.err_txt_nosymbol;
        }
        else if (NoText_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập chữ";
            //PnError.BackColor = errColors.err_txt_notext;

        }
        else
        {
            //lblHint.Text = "Nhập ok!";
            //PnError.BackColor = errColors.mes_success;
            e.Handled = false;
        }
    }

    public void NoSymNumMinMaxPress(object sender, KeyPressEventArgs e, int max = 16, int min = 3)
    {
        e.Handled = false;
        if (NoSymbol_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập ký tự đặc biệt";
            //PnError.BackColor = errColors.err_txt_nosymbol;
        }
        else if (NoNumber_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập số";
            //PnError.BackColor = errColors.err_txt_nonumber;

        }
        else if (NoMinMax_KeyPress(sender, min, max))
        {
            //lblHint.Text = "Không nhập đủ hoặc dư số lượng ký tự";
            //PnError.BackColor = errColors.err_txt_minmax_length;
        }
        else
        {
            //lblHint.Text = "Nhập ok!";
            //PnError.BackColor = errColors.mes_success;
            e.Handled = false;
        }
    }

    public void NoSymNumPress(KeyPressEventArgs e)
    {
        e.Handled = false;
        if (NoSymbol_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập ký tự đặc biệt";
            //PnError.BackColor = errColors.err_txt_nosymbol;
        }
        else if (NoNumber_KeyPress(e))
        {
            e.Handled = true;
            //lblHint.Text = "Không nhập số";
            //PnError.BackColor = errColors.err_txt_nonumber;

        }
        else
        {
            e.Handled = false;
            //lblHint.Text = "Nhập ok!";
            //PnError.BackColor = errColors.mes_success;
        }
    }

    public bool NoSymNumSpaceMinMaxChange(object sender, int min = 3, int max = 16)
    {
        Control c = (Control)sender;
        if (NoSymbol_TextChanged(sender))
        {
            return true;
        }
        else if (NoNumber_TextChange(sender))
        {
            return true;
        }
        else if (NoSpace_TextChange(sender))
        {
            return true;
        }
        else if (NoMinMax_TextChanged(sender, min, max))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /// <summary>
    /// No symbol, no number, not enough min max characters
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    public bool NoSymNumMinMaxChange(object sender, int min = 3, int max = 16)
    {
        Control c = (Control)sender;
        if (NoSymbol_TextChanged(sender))
        {
            return true;
        }
        else if (NoNumber_TextChange(sender))
        {
            return true;
        }
        else if (NoMinMax_TextChanged(sender, min, max))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /// <summary>
    /// No symbol, no number
    /// </summary>
    /// <param name="sender"></param>
    /// <returns></returns>
    public bool NoSymNumChange(object sender)
    {
        Control c = (Control)sender;

        if (NoSymbol_TextChanged(sender))
        {
            return true;
        }
        else if (NoNumber_TextChange(sender))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /// <summary>
    /// No symbol, no text, nospace, not enough min max
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    public bool NoSymTextSpaceMinMaxChange(object sender, int min = 3, int max = 16)
    {
        Control c = (Control)sender;
        if (NoSymbol_TextChanged(sender))
        {
            return true;
        }
        else if (NoText_TextChange(sender))
        {
            return true;
        }
        else if (NoSpace_TextChange(sender))
        {
            return true;
        }
        else if (NoMinMax_TextChanged(sender, min, max))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /// <summary>
    /// No symbol, no text, no space
    /// </summary>
    /// <param name="sender"></param>
    /// <returns></returns>
    public bool NoSymTextSpaceChange(object sender)
    {
        Control c = (Control)sender;
        if (NoSymbol_TextChanged(sender))
        {
            return true;
        }
        else if (NoText_TextChange(sender))
        {
            return true;
        }
        else if (NoSpace_TextChange(sender))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool NoSymTextMinMaxChange(object sender, int min = 3, int max = 16)
    {
        Control c = (Control)sender;
        if (NoSymbol_TextChanged(sender))
        {
            return true;
        }
        else if (NoText_TextChange(sender))
        {
            return true;
        }
        else if (NoMinMax_TextChanged(sender, min, max))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool NoSymTextChange(object sender)
    {
        Control c = (Control)sender;
        if (NoSymbol_TextChanged(sender))
        {
            return true;
        }
        else if (NoText_TextChange(sender))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /// <summary>
    /// Không nhập ít hơn và không nhập nhiều hơn
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="v1">Ít hơn</param>
    /// <param name="v2">Nhiều hơn</param>
    /// <returns></returns>
    internal static bool MinMaxValue_TextChanged(object sender, int v1, int v2)
    {
        Control c = (Control)sender;
        if (c.Text.Length < v1 || c.Text.Length > v2)
        {
            // không nhập ít hơn số ký tự tối thiểu hoặc nhiều hơn số ký tự tối đa 
            return true;//phát hiện sai phạm trả về true
        }
        else
        {
            return false;
        }
    }

}

