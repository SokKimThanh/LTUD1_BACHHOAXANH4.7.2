using LTUD1_BACHHOAXANH472.controller;
using LTUD1_BACHHOAXANH472.Model;
using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.BanHang;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormBanHang : Form
    {

        private int currentPage = 1;
        private int pageSize = 4;
        private int pageCount = 0;
        private PictureBox currentPictureBox;

        BanHangController banhangController;

        PhanTrangSanPham phantrang;
        RandomStringGenerator rnd = new RandomStringGenerator();

        ChiTietHoaDonController cthdController = new ChiTietHoaDonController(Utils.ConnectionString);
        HoaDonController hoadonController = new HoaDonController(Utils.ConnectionString);
        DanhMucController danhMucController = new DanhMucController(Utils.ConnectionString);
        SanPhamController sanPhamController = new SanPhamController(Utils.ConnectionString);
        KhachHangController khachHangController = new KhachHangController(Utils.ConnectionString);
        NhaCungCapController nhaCungCapController = new NhaCungCapController(Utils.ConnectionString);
        ChiTietHoaDonController cchtController = new ChiTietHoaDonController(Utils.ConnectionString);
        HoaDonController hoaDonController = new HoaDonController(Utils.ConnectionString);

        /// <summary>
        /// Hàm load design
        /// </summary>
        public FormBanHang()
        {
            InitializeComponent(); 
            DataGridViewHelper.ConfigureDataGridView(dgvThongTinHoaDon);
            DataGridViewHelper.ConfigureDataGridView(dgvDanhSachSanPham);

            //DataGridViewHelper.ChangeHeaderNameDanhThongTinHoaDon(dgvThongTinHoaDon);
            //DataGridViewHelper.ChangeHeaderNameDanhSachSanPham(dgvDanhSachSanPham);
            //DataGridViewHelper.TaoCotAddToCart(dgvDanhSachSanPham);
             
        }
        /// <summary>
        /// Hàm load dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBanHang_Load(object sender, EventArgs e)
        {
            // tạo mã random cho mã hóa đơn
            txtMaHoaDon.Text = rnd.GenerateRandomAlphanumericString(11);

            // thêm dữ liệu vào datagridview sản phẩm
            phantrang = new PhanTrangSanPham(currentPage, pageSize, pageCount);
            phantrang.GetData();

            dgvDanhSachSanPham.DataSource = phantrang.DanhSachSanPham.DataSource;

            pageCount = sanPhamController.GetRowCount() / pageSize;
            lblTongSoTrang.Text = $"Trang {currentPage}/{pageCount}";//Trang 1/40

            //khởi tạo banhang controller điều khiển luồng dữ liệu trên form bán hàng
            banhangController = new BanHangController(dgvThongTinHoaDon, dgvDanhSachSanPham);

            // thêm dữ liệu vào combobox loại sản phẩm 

            cboLoaiSanPham.DataSource = danhMucController.sp_cbo_danhmuc_select_all();
            cboLoaiSanPham.ValueMember = "MALOAI";
            cboLoaiSanPham.DisplayMember = "TENLOAI";

            // thêm dữ liệu vào combobox nhà cung cấp
            cboNhaCungCap.DataSource = nhaCungCapController.sp_cbo_nhacungcap_select_all();
            cboNhaCungCap.ValueMember = "MANCC";
            cboNhaCungCap.DisplayMember = "TENNCC";
             
            

            lblTongTien.Text = "0";
            txtSoLuongMua.Text = "0";

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
            phantrang.Loaisanpham = cboLoaiSanPham.SelectedValue.ToString();
            phantrang.Nhacungcap = cboNhaCungCap.SelectedValue.ToString();
            phantrang.Tensanpham = txtTenSanPham.Text;
            phantrang.GetData();
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            currentPictureBox = sender as PictureBox;
            timer1.Start();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            currentPictureBox = sender as PictureBox;
            timer1.Start();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            currentPictureBox = sender as PictureBox;
            timer1.Start();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            currentPictureBox = sender as PictureBox;
            timer1.Stop();
        }

        private bool isZoomingIn = true;

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isZoomingIn)
            {
                currentPictureBox.Width += 1;
                currentPictureBox.Height += 1;

                if (currentPictureBox.Width >= 32) // MAX_WIDTH là kích thước tối đa phóng to
                {
                    isZoomingIn = false;
                }
            }
            else
            {
                currentPictureBox.Width -= 1;
                currentPictureBox.Height -= 1;

                if (currentPictureBox.Width <= 24) // MIN_WIDTH là kích thước tối thiểu thu nhỏ
                {
                    isZoomingIn = true;
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextHelper.HandleTextChange_PhoneNumber(sender);
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            phantrang.btnNext_Click(sender, e);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            phantrang.btnPrevious_Click(sender, e);
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void dgvThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHuyThanhToan_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn hủy thanh toán và xóa tất cả các mục trong giỏ hàng không?", "Xác nhận hủy thanh toán", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Xóa tất cả các dòng trong dgvThongTinHoaDon
                dgvThongTinHoaDon.Rows.Clear();
                txtTenKhachHang.Text = "";
                txtSDT.Text = "";
                lblTongTien.Text = "";
                txtSoLuongMua.Text = "";
            }
        }



    }
}
