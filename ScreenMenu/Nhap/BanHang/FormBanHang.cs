using CrystalDecisions.Windows.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472
{
    public partial class FormBanHang : Form
    {
        private int currentPage = 1;
        private int recordPerPage = 8;
        private int pageCount = 0;
        PBanHangHoaDonChiTietAdapter banhangController;
        PBanHangSanPhamAdapter phantrangController;
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
            cboRecordPerPage.DropDownStyle = ComboBoxStyle.DropDownList;

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
            //------------------.    Khởi tạo thao tác datagridview       .-----------------
            //--............................ sản phẩm phân trang .........................--
            //==============================================================================

            phantrangController = new PBanHangSanPhamAdapter(cboRecordPerPage, txtTenSanPham, cboNhaCungCap, cboLoaiSanPham, dgvDanhSachSanPham, lblTongSoTrang, 8);
            phantrangController.SetRecordPerPageCombobox(8, 4);
            phantrangController.GetData();
            //dgvDanhSachSanPham.DataSource = phantrangController.DgvDanhSachSanPham.DataSource;
            //lblTongSoTrang.Text = phantrangController.GetTongSoTrang();
            //==============================================================================
            //--..........................................................................--
            //------------------.      Khởi tạo thao tác datagridview       .---------------
            //--.................            sản phẩm giỏ hàng            ..................
            //==============================================================================
            //khởi tạo banhang sanPhamController điều khiển luồng dữ liệu trên form bán hàng
            banhangController = new PBanHangHoaDonChiTietAdapter(txtSDTKhachHang, txtTenKhachHang, txtMaHoaDon, txtSoLuongMua, lblTongTien, dgvThongTinHoaDon, dgvDanhSachSanPham);
            banhangController.ChangeHeaderNameDanhThongTinHoaDon();
            banhangController.ChangeHeaderNameDanhSachSanPham();
            banhangController.CreateButtonClickHoaDonSanPham();
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
        private void cboRecordPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiSanPham.SelectedItem.ToString() == "0")
            {
                // Thực hiện hành động khi người dùng chọn "Tất cả"
                cboRecordPerPage.SelectedValue = null;
            }
            else
            {
                phantrangController.RecordsPerPage = int.Parse(cboRecordPerPage.SelectedItem.ToString());
            }
        }
        //==============================================================================
        //--..........................................................................--
        //------------------.       Sự kiện tìm kiếm sản phẩm     .---------------------
        //--..........................................................................--
        //==============================================================================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            phantrangController.btnTimKiem_Click(sender, e);
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
            phantrangController.btnNext_Click(sender, e);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            phantrangController.btnPrevious_Click(sender, e);
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
        private void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            banhangController.dgvDanhSachSanPham_CellClick(sender, e);
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



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            phantrangController.btnRefresh_Click(sender, e);
        }

    }
}