using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472.Model
{
    public static class TextHelper
    {
        /// <summary>
        /// Chặn nhập dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        public static void HandleTextChange(object sender)
        {
            // Phát hiện nhập chữ
            Control control = sender as Control;
            if (control != null)
            {
                // Xóa ký tự cuối cùng đã nhập
                if (control.Text.Length > 0)
                {
                    control.Text = control.Text.Remove(control.Text.Length - 1);
                    // Đặt con trỏ về cuối chuỗi
                    if (control is TextBox)
                    {
                        ((TextBox)control).SelectionStart = control.Text.Length;
                    }
                    else if (control is RichTextBox)
                    {
                        ((RichTextBox)control).SelectionStart = control.Text.Length;
                    }
                }
            }
        }
        public static void HandleTextChange(object sender, int min, int max)
        {
            Control control = sender as Control;
            if (control != null)
            {
                // Xóa ký tự cuối cùng đã nhập nếu vượt quá số ký tự tối đa
                if (control.Text.Length > max)
                {
                    control.Text = control.Text.Remove(control.Text.Length - 1);
                }
                // Đặt con trỏ về cuối chuỗi
                if (control is TextBox)
                {
                    ((TextBox)control).SelectionStart = control.Text.Length;
                }
                else if (control is RichTextBox)
                {
                    ((RichTextBox)control).SelectionStart = control.Text.Length;
                }
            }
        }

        /// <summary>
        /// Số điện thoại không nhập chữ, không nhập ký tự, hoặc khoảng trắng
        /// </summary>
        /// <param name="sender"></param>
        public static void HandleTextChange_PhoneNumber(object sender)
        {
            int min = 9; int max = 11;
            if (ErrTxt.NoText_TextChange(sender) || ErrTxt.NoSymbol_TextChanged(sender) || ErrTxt.NoSpace_TextChange(sender) || ErrTxt.MinMaxValue_TextChanged(sender, min, max))
            {
                HandleTextChange(sender, min, max);
            }
        }

        internal static void HandleTextChange_Salary(object sender)
        {
            if (ErrTxt.NoText_TextChange(sender))
            {
                HandleTextChange(sender);
            }
        }


        internal static void HandleTextChange_TenChiNhanh(object sender)
        {
            // kiểm tra 1 trong 3 cái nào dính thì chặn luôn
            if (ErrTxt.NoNumber_TextChange(sender) || ErrTxt.NoSymbol_TextChanged(sender))
            {
                HandleTextChange(sender);
            }
        }
        public static void HandleTextChange_DiaChi(object sender)
        {
            if (ErrTxt.NoSymbol_TextChanged(sender))
            {
                HandleTextChange(sender);
            }
        }
        public static void HandleTextChange_FullName(object sender)
        {
            // kiểm tra 1 trong 3 cái nào dính thì chặn luôn
            if (ErrTxt.NoNumber_TextChange(sender) || ErrTxt.NoSpace_TextChange(sender) || ErrTxt.NoSymbol_TextChanged(sender))
            {
                HandleTextChange(sender);
            }
        }
    }

}
