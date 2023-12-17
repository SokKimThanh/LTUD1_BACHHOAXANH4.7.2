using System.Drawing;
using System.Windows.Forms;
public static class DataGridViewHelper
{
    /// <summary>
    /// Hàm vẽ lại các thuộc tính cần thiết cho một datagridview
    /// </summary>
    /// <param name="dgv">Datagridview bình thường chưa qua design</param>
    public static void ConfigureDataGridView(DataGridView dgv)
    {
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.ForeColor = Color.Black;
        dgv.ReadOnly = true;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.MultiSelect = false;
        dgv.Dock = DockStyle.Fill;
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dgv.AllowUserToAddRows = false;
        dgv.ScrollBars = ScrollBars.Both;

    }
}


