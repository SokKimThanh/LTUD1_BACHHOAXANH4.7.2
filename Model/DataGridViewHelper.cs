using System.Drawing;
using System.Windows.Forms;
public static class DataGridViewHelper
{
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
    }
    public static void ChangeHeaderNameDanhThongTinHoaDon(DataGridView dgvThongTinHoaDon)
    {
        dgvThongTinHoaDon.Columns[0].HeaderText = "Mã Sản Phẩm";
        dgvThongTinHoaDon.Columns[1].HeaderText = "Tên Sản Phẩm";
        dgvThongTinHoaDon.Columns[2].HeaderText = "Đơn Giá";
        dgvThongTinHoaDon.Columns[3].HeaderText = "Khuyến Mãi";
        dgvThongTinHoaDon.Columns[4].HeaderText = "Số Lượng";
        dgvThongTinHoaDon.Columns[5].HeaderText = "Tổng";
        dgvThongTinHoaDon.Columns[6].HeaderText = "+";
        dgvThongTinHoaDon.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvThongTinHoaDon.Columns[7].HeaderText = "-";
        dgvThongTinHoaDon.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

    }

    public static void ChangeHeaderNameDanhSachSanPham(DataGridView dgvDanhSachSanPham)
    {
        dgvDanhSachSanPham.Columns[1].HeaderText = "Mã Sản Phẩm";
        dgvDanhSachSanPham.Columns[2].HeaderText = "Tên Sản Phẩm";
        //dgvDanhSachSanPham.Columns[3].HeaderText = "Đơn Vị Tính";
        //dgvDanhSachSanPham.Columns[4].HeaderText = "NSX";
        //dgvDanhSachSanPham.Columns[5].HeaderText = "HSD";
        dgvDanhSachSanPham.Columns[6].HeaderText = "Đơn Giá";
        dgvDanhSachSanPham.Columns[7].HeaderText = "SL Tồn";
        //dgvDanhSachSanPham.Columns[8].HeaderText = "Mã Loại";
        //dgvDanhSachSanPham.Columns[9].HeaderText = "Mã NCC";
        dgvDanhSachSanPham.Columns[10].HeaderText = "Mã KM";

        dgvDanhSachSanPham.Columns.RemoveAt(3);
        dgvDanhSachSanPham.Columns.RemoveAt(3);
        dgvDanhSachSanPham.Columns.RemoveAt(3);

        dgvDanhSachSanPham.Columns.RemoveAt(5);
        dgvDanhSachSanPham.Columns.RemoveAt(5);
        //dgvDanhSachSanPham.Columns.RemoveAt(5);


    }

    public static void TaoCotAddToCast(DataGridView dgvDanhSachSanPham)
    {
        DataGridViewButtonColumn colAddToCast = new DataGridViewButtonColumn();
        colAddToCast.Name = "btnAddToCast";
        colAddToCast.HeaderText = "Giỏ hàng";
        dgvDanhSachSanPham.Columns.Insert(0, colAddToCast);

        foreach (DataGridViewRow row in dgvDanhSachSanPham.Rows)
        {
            DataGridViewCell cell = new DataGridViewButtonCell();
            cell.Value = "+";
            row.Cells[0].Value = cell.Value;
        }
    }
}


