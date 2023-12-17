using LTUD1_BACHHOAXANH472.controller;
using LTUD1_BACHHOAXANH472.Model;
using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.BanHang;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472
{
    public partial class FormBanHang : Form
    {
        private int currentPage = 1;
        private int pageSize = 4;
        private int pageCount = 0;
        private PictureBox currentPictureBox;
        PBanHangController banhangController;
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
            cboPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            DataGridViewHelper.ConfigureDataGridView(dgvThongTinHoaDon);
            DataGridViewHelper.ConfigureDataGridView(dgvDanhSachSanPham);
            //DataGridViewHelper.ChangeHeaderNameDanhThongTinHoaDon(dgvThongTinHoaDon);
            //DataGridViewHelper.ChangeHeaderNameDanhSachSanPham(dgvDanhSachSanPham);
            DataGridViewHelper.TaoCotAddToCart(dgvDanhSachSanPham);


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
            //==============================================================================
            //--..........................................................................--
            //------------------.           Khởi tạo phân trang       .---------------------
            //--..........................................................................--
            //==============================================================================
            // thêm dữ liệu vào datagridview sản phẩm
            phantrang = new PhanTrangSanPham(currentPage, pageSize, pageCount);
            dgvDanhSachSanPham.DataSource = phantrang.GetDataPhanTrang();
            lblTongSoTrang.Text = phantrang.GetTongSoTrang();
            //==============================================================================
            //--..........................................................................--
            //------------------.  Khởi tạocombobox hiển thị số lượng item       .----------
            //--..........................................................................--
            //==============================================================================
            // Gọi phương thức create pagesize để tạo một combobox chứa pagesize tùy chỉnh hiển thị dữ liệu
            phantrang.CreatePagesizeCombobox(cboPageSize);
            // cbopagesize index = 1
            cboPageSize.SelectedIndex = 1;

            //khởi tạo banhang controller điều khiển luồng dữ liệu trên form bán hàng
            banhangController = new PBanHangController(dgvThongTinHoaDon, dgvDanhSachSanPham);
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
        private void cboPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn từ ComboBox
            int selectedValue = (int)cboPageSize.SelectedItem;
            // Gán giá trị pagesize
            phantrang.PageSize = selectedValue;
        }
        //==============================================================================
        //--..........................................................................--
        //------------------.       Sự kiện tìm kiếm sản phẩm     .---------------------
        //--..........................................................................--
        //==============================================================================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // thông tin trang hiển thị 
            phantrang.PageSize = int.Parse(cboPageSize.SelectedItem.ToString());

            // lấy giá trị trên các ô nhập
            phantrang.Loaisanpham = cboLoaiSanPham.SelectedValue.ToString();
            phantrang.Nhacungcap = cboNhaCungCap.SelectedValue.ToString();
            phantrang.Tensanpham = txtTenSanPham.Text;
            // thực hiện câu truy vấn phân trang 
            // lấy dữ liệu phân trang hiện tại
            dgvDanhSachSanPham.DataSource = phantrang.GetDataPhanTrang();
            // làm mới danh sách 
            dgvDanhSachSanPham.Refresh();

            lblTongSoTrang.Text = phantrang.GetTongSoTrang();
        }

        //==============================================================================
        //--..........................................................................--
        //------------------Giao diện hình mũi tên nhỏ chuyển trang---------------------
        //--..........................................................................--
        //==============================================================================
        private void btnPrevious_MouseHover(object sender, EventArgs e)
        {
            PictureBox currentPictureBox = sender as PictureBox;
            currentPictureBox.Image = Properties.Resources.icon_big_phantrangleft; // đổi sang hình to hơn
        }
        //==============================================================================
        //--..........................................................................--
        //------------------Giao diện hình mũi tên nhỏ chuyển trang---------------------
        //--..........................................................................--
        //==============================================================================
        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {
            PictureBox currentPictureBox = sender as PictureBox;
            currentPictureBox.Image = Properties.Resources.icon_small_phantrangleft; // đổi sang hình nhỏ hơn
        }
        //==============================================================================
        //--..........................................................................--
        //------------------Giao diện hình mũi tên nhỏ chuyển trang---------------------
        //--..........................................................................--
        //==============================================================================
        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            PictureBox currentPictureBox = sender as PictureBox;
            currentPictureBox.Image = Properties.Resources.icon_big_phantrangright; // đổi sang hình to hơn
        }
        //==============================================================================
        //--..........................................................................--
        //------------------Giao diện hình mũi tên nhỏ chuyển trang---------------------
        //--..........................................................................--
        //==============================================================================
        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            PictureBox currentPictureBox = sender as PictureBox;
            currentPictureBox.Image = Properties.Resources.icon_small_phantrangright; // đổi sang hình nhỏ hơn
        }
        //==============================================================================
        //--..........................................................................--
        //------------------SỰ KIỆN EVENT hình mũi tên nhỏ chuyển trang-----------------
        //--..........................................................................--
        //==============================================================================
        private void btnNext_Click(object sender, EventArgs e)
        {
            phantrang.btnNext_Click(sender, e);
            lblTongSoTrang.Text = phantrang.GetTongSoTrang();
            dgvDanhSachSanPham.DataSource = phantrang.DanhSachSanPham.DataSource;
            dgvDanhSachSanPham.Refresh();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            phantrang.btnPrevious_Click(sender, e);
            lblTongSoTrang.Text = phantrang.GetTongSoTrang();
            dgvDanhSachSanPham.DataSource = phantrang.DanhSachSanPham.DataSource;
            dgvDanhSachSanPham.Refresh();
        }
        //==============================================================================
        //--..........................................................................--
        //------------------Sự kiện event kiểm tra nhập số điện thoại-------------------
        //--..........................................................................--
        //==============================================================================
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextHelper.HandleTextChange_PhoneNumber(sender);
        }
        //==============================================================================
        //--..........................................................................--
        //------------------Sự kiện event bấm thanh toán -------------------------------
        //--..........................................................................--
        //==============================================================================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }
        //==============================================================================
        //--..........................................................................--
        //------------------Sự kiện event tăng giảm số lượng mua------------------------
        //--..........................................................................--
        //==============================================================================
        private void dgvThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //==============================================================================
        //--..........................................................................--
        //------------------Sự kiện event  add to cart----------------------------------
        //--..........................................................................--
        //==============================================================================
        private void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //==============================================================================
        //--..........................................................................--
        //------------------Sự kiện event hủy thanh toán -------------------------------
        //--..........................................................................--
        //==============================================================================
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