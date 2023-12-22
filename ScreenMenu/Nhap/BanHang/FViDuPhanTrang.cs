using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.BanHang
{
    public partial class ViDuPhanTrang : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private int currentPage = 1;
        private int recordsPerPage = 4;
        private int recordTotals = 0;
        SanPhamController sanPhamController = new SanPhamController(Utils.ConnectionString);
        DanhMucController loaispController = new DanhMucController(Utils.ConnectionString);
        NhaCungCapController nccController = new NhaCungCapController(Utils.ConnectionString);

        public ViDuPhanTrang()
        {
            InitializeComponent();

        }

        private void GetData()
        {
            try
            {
                bindingSource1.DataSource = sanPhamController.PhanTrang(currentPage, recordsPerPage, null, null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < recordTotals)
            {
                currentPage++;
                lblTongSoTrang.Text = currentPage.ToString();
                GetData();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                lblTongSoTrang.Text = currentPage.ToString();
                GetData();
            }
        }

        private void ViDuPhanTrang_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = sanPhamController.PhanTrang(currentPage, recordsPerPage, null, null, null);
            dataGridView1.DataSource = bindingSource1;
            recordTotals = sanPhamController.GetRowCount(null, null, null) / recordsPerPage; ;
            tongsotrang.Text = recordTotals.ToString();

            cboLoaiSanPham.DataSource = loaispController.sp_cbo_danhmuc_select_all();
            cboLoaiSanPham.ValueMember = "MALOAI";
            cboLoaiSanPham.DisplayMember = "TENLOAI";

            cboNhaCungCap.DataSource = nccController.sp_cbo_nhacungcap_select_all();
            cboNhaCungCap.ValueMember = "MANCC";
            cboNhaCungCap.DisplayMember = "TENNCC";
        }
        private void cboNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNhaCungCap.SelectedItem.ToString() == "Tất cả")
            {
                // Thực hiện hành động khi người dùng chọn "Tất cả"
                cboNhaCungCap.SelectedValue = null;
            }
        }
        private void cboLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiSanPham.SelectedItem.ToString() == "Tất cả")
            {
                // Thực hiện hành động khi người dùng chọn "Tất cả"
                cboNhaCungCap.SelectedValue = null;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string loaisanpham = cboLoaiSanPham.SelectedValue.ToString();
            string nhacungcap = cboNhaCungCap.SelectedValue.ToString();
            string tensanpham = txtTenSanPham.Text;
            bindingSource1.DataSource = sanPhamController.PhanTrang(currentPage, recordsPerPage, tensanpham, loaisanpham, nhacungcap);
            dataGridView1.DataSource = bindingSource1;
            recordTotals = sanPhamController.GetRowCount(tensanpham, loaisanpham, nhacungcap) / recordsPerPage; ;
            tongsotrang.Text = recordTotals.ToString();
        }
    }
}
