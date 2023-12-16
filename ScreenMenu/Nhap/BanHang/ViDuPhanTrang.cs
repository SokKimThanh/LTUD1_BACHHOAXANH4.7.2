using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.BanHang
{
    public partial class ViDuPhanTrang : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private int currentPage = 1;
        private int pageSize = 4;
        private int pageCount = 0;
        SanPhamController controller = new SanPhamController(Utils.ConnectionString);
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
                bindingSource1.DataSource = controller.PhanTrang(currentPage, pageSize, null, null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < pageCount)
            {
                currentPage++;
                sotrang.Text = currentPage.ToString();
                GetData();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                sotrang.Text = currentPage.ToString();
                GetData();
            }
        }

        private void ViDuPhanTrang_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = controller.PhanTrang(currentPage, pageSize, null, null, null);
            dataGridView1.DataSource = bindingSource1;
            pageCount = controller.GetRowCount() / pageSize; ;
            tongsotrang.Text = pageCount.ToString();

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
            bindingSource1.DataSource = controller.PhanTrang(currentPage, pageSize, tensanpham, loaisanpham, nhacungcap);
            dataGridView1.DataSource = bindingSource1;
            pageCount = controller.GetRowCount() / pageSize; ;
            tongsotrang.Text = pageCount.ToString();
        }
    }
}
