using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.Model
{
    public static class TextHelper
    {
        public static void HandleTextChange_DiaChi(object sender)
        {
            if (ErrTxt.NoSymbol_TextChanged(sender))
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
        }
        public static void HandleTextChange_Name(object sender)
        {
            // kiểm tra 1 trong 3 cái nào dính thì chặn luôn
            if (ErrTxt.NoNumber_TextChange(sender) || ErrTxt.NoSpace_TextChange(sender) || ErrTxt.NoSymbol_TextChanged(sender))
            {
                // Phát hiện nhập chữ
                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {
                    // Xóa ký tự cuối cùng đã nhập
                    if (textBox.Text.Length > 0)
                    {
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                        // Đặt con trỏ về cuối chuỗi
                        textBox.SelectionStart = textBox.Text.Length;
                    }
                }
            }
        }
        public static void HandleTextChange_PhoneNumber(object sender)
        {
            if (ErrTxt.NoText_TextChange(sender))
            {
                // Phát hiện nhập chữ
                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {
                    // Xóa ký tự cuối cùng đã nhập
                    if (textBox.Text.Length > 0)
                    {
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                        // Đặt con trỏ về cuối chuỗi
                        textBox.SelectionStart = textBox.Text.Length;
                    }
                }
            }
        }

        internal static void HandleTextChange_Salary(object sender)
        {
            if (ErrTxt.NoText_TextChange(sender))
            {
                // Phát hiện nhập chữ
                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {
                    // Xóa ký tự cuối cùng đã nhập
                    if (textBox.Text.Length > 0)
                    {
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                        // Đặt con trỏ về cuối chuỗi
                        textBox.SelectionStart = textBox.Text.Length;
                    }
                }
            }
        }
    }

}
