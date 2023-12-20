using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

public static class ComboBoxHelper
{
    /// <summary>
    /// Hàm cấu hình lại các thuộc tính cần thiết cho một combobox
    /// </summary>
    /// <param name="cb">Combobox bình thường chưa qua design</param>
    public static void ConfigureComboBox(ComboBox cb)
    {
        // Thiết lập màu sắc và kiểu chữ
        cb.ForeColor = Color.Black;
        cb.Font = new Font("Segoe UI", 16);

        // Thiết lập chế độ chọn
        //cb.DropDownStyle = ComboBoxStyle.DropDownList;

        // Thiết lập chế độ hiển thị
        cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        cb.AutoCompleteSource = AutoCompleteSource.ListItems;

        // Thiết lập kích thước
        cb.Width = 200;

        // Thiết lập chiều cao của danh sách dropdown
        cb.DropDownHeight = 100;
    }
}

