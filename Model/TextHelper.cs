using System;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;
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
        public static void HandleTextChangeMinmax(Control control, int min, int max)
        {

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
        /// <param name="sender">một thể hiện của Textbox</param>
        /// <param name="e">một thể hiện của EventArgs hoặc KeyPressEventArgs</param>
        public static void HandlePhoneNumber(object sender, object e)
        {
            int min = 9; int max = 11;
            if (ErrTextbox.isSpace(sender) || ErrTextbox.MinMaxValue_TextChanged(sender, min, max))
            {
                Control control = sender as Control;

                if (e is KeyPressEventArgs)
                {
                    KeyPressEventArgs a = e as KeyPressEventArgs;

                    HandleTextChangeMinmax(control, min, max);
                    if (!char.IsControl(a.KeyChar) && !char.IsDigit(a.KeyChar))
                    {
                        a.Handled = true;
                    }
                }
                else if (e is EventArgs)
                {
                    HandleTextChangeMinmax(control, min, max);
                }
            }
        }


        internal static void HandleTextChange_Salary(object sender)
        {
            if (ErrTextbox.NoText_TextChange(sender))
            {
                HandleTextChange(sender);
            }
        }


        internal static void HandleTextChange_TenChiNhanh(object sender)
        {
            // kiểm tra 1 trong 3 cái nào dính thì chặn luôn
            if (ErrTextbox.isNumber(sender) || ErrTextbox.isText(sender))
            {
                HandleTextChange(sender);
            }
        }
        public static void HandleTextChange_DiaChi(object sender)
        {
            if (ErrTextbox.isText(sender))
            {
                HandleTextChange(sender);
            }
        }
        public static void HandleTextChange_FullName(object sender)
        {
            int min = 30; int max = 30;
            // kiểm tra 1 trong 3 cái nào dính thì chặn luôn 
            TextBox textBox = sender as TextBox;
            Control control = sender as Control;
            if (textBox != null)
            {
                string text = textBox.Text;
                int charCount = text.Length;
                if (ErrTextbox.isNumber(sender) || charCount > max || charCount < min)
                {

                    HandleTextChangeMinmax(control, min, max);
                }
            }

        }
        
    }

}
