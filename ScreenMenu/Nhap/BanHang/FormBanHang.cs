using System;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472
{
    public partial class FormBanHang : Form
    {
        private int currentPage = 1;
        private int pageSize = 16;
        private int pageCount = 0;
        PBanHangController banhangController = new PBanHangController();
        PhanTrangSanPham phantrang;
        RandomStringGenerator rnd = new RandomStringGenerator();
        DanhMucController danhMucController = new DanhMucController(Utils.ConnectionString);
        NhaCungCapController nhaCungCapController = new NhaCungCapController(Utils.ConnectionString);
        /// <summary>
        /// Hàm load design
        /// </summary>
        public FormBanHang()
        {
            InitializeComponent();

            // cài đặt style cho combobox 
            cboNhaCungCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPageSize.DropDownStyle = ComboBoxStyle.DropDownList;

            // cài đặt style cho datagridview 
            DataGridViewHelper.ConfigureDataGridView(dgvThongTinHoaDon);
            DataGridViewHelper.ConfigureDataGridView(dgvDanhSachSanPham);
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
            //==============================================================================
            //--..........................................................................--
            //------------------.      Khởi tạo thao tác datagridview       .---------------
            //--.................            sản phẩm giỏ hàng            ..................
            //==============================================================================
            //khởi tạo banhang controller điều khiển luồng dữ liệu trên form bán hàng
            banhangController.TxtSDTKhachHang = txtSDT;
            banhangController.TxtMaHoaDon = txtMaHoaDon;
            banhangController.TxtTenKhachHang = txtTenKhachHang;
            banhangController.TxtSoLuongMua = txtSoLuongMua;
            banhangController.DgvDanhSachSanPham = dgvDanhSachSanPham;
            banhangController.DgvThongTinHoaDon = dgvThongTinHoaDon;
            banhangController.ChangeHeaderNameDanhThongTinHoaDon();
            banhangController.ChangeHeaderNameDanhSachSanPham();
            banhangController.TaoCotThemGioHang();
            //==============================================================================
            //--..........................................................................--
            //------------------.      Khởi tạo dữ liệu combobox danh mục       .-----------
            //--.................                loại sản phẩm            ..................
            //==============================================================================
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
        //==============================================================================
        //--..........................................................................--
        //------------------.       Sự kiện chọn tiêu chí tìm kiếm     .----------------
        //--.................             nhà  cung cấp             ..................--
        //==============================================================================
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //==============================================================================
        //--..........................................................................--
        //------------------Sự kiện event bấm thanh toán -------------------------------
        //--..........................................................................--
        //==============================================================================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            banhangController.btnThanhToan_Click(sender, e);
        }
        //==============================================================================
        //--..........................................................................--
        //------------------Sự kiện event tăng giảm số lượng mua------------------------
        //--..........................................................................--
        //==============================================================================
        private void dgvThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            banhangController.dgvThongTinHoaDon_CellContentClick(sender, e);
            lblTongTien.Text = banhangController.LblTongTien.Text;
            txtSoLuongMua.Text = banhangController.TxtSoLuongMua.Text;
        }
        //==============================================================================
        //--..........................................................................--
        //------------------Sự kiện event  add to cart----------------------------------
        //--..........................................................................--
        //==============================================================================
        private void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            banhangController.dgvDanhSachSanPham_CellContentClick(sender, e);
            if (banhangController.LblTongTien != null)
            {
                lblTongTien.Text = banhangController.LblTongTien.Text;
            }
            else
            {
                // Xử lý trường hợp LblTongTien là null
            }
            txtSoLuongMua.Text = banhangController.TxtSoLuongMua.Text;
        }

        //==============================================================================
        //--..........................................................................--
        //------------------Sự kiện event hủy thanh toán -------------------------------
        //--..........................................................................--
        //==============================================================================
        private void btnHuyThanhToan_Click(object sender, EventArgs e)
        {
            banhangController.btnHuyThanhToan_Click(sender, e);
            lblTongTien.Text = banhangController.LblTongTien.Text;
            txtSoLuongMua.Text = banhangController.TxtSoLuongMua.Text;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}