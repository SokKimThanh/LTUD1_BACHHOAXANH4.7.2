using LTUD1_BACHHOAXANH472.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472
{
    public partial class FormBanHang : Form
    {
        private int currentPage = 1;
        private int recordsPerPage = 8;
        private int totalRecords = 0;
        AdapterBanHang banhangController;
        AdapterPhanTrang phantrangAdapter;
        RandomStringGenerator rnd = new RandomStringGenerator();
        DanhMucController danhMucController = new DanhMucController(Utils.ConnectionString);
        NhaCungCapController nhaCungCapController = new NhaCungCapController(Utils.ConnectionString);
        HoaDon hoadon = new HoaDon();
        ReportManager reportManager = new ReportManager();
        //SanPhamController sanPhamController = new SanPhamController(Utils.ConnectionString);
        /// <summary>
        /// Hàm load design
        /// </summary>
        public FormBanHang(ReportManager reportManager)
        {
            InitializeComponent();

            // cài đặt style cho combobox 
            ComboBoxHelper.ConfigureComboBox(cboNhaCungCap);
            ComboBoxHelper.ConfigureComboBox(cboLoaiSanPham);
            ComboBoxHelper.ConfigureComboBox(cboRecordPerPage);

            // cài đặt style cho datagridview 
            DataGridViewHelper.ConfigureDataGridView(dgvThongTinHoaDon);
            DataGridViewHelper.ConfigureDataGridView(dgvDanhSachSanPham);

            this.reportManager = reportManager;
        }
        /// <summary>
        /// Hàm load dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBanHang_Load(object sender, EventArgs e)
        {
            try
            {
                // tạo mã random cho mã hóa đơn
                txtMaHoaDon.Text = rnd.GenerateRandomAlphanumericString(11);
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

                //==============================================================================
                //--..........................................................................--
                //------------------.    Khởi tạo thao tác datagridview       .-----------------
                //--.....................      sản phẩm phân trang       .....................--
                //==============================================================================
                phantrangAdapter = new AdapterPhanTrang(cboRecordPerPage, txtTenSanPham, cboNhaCungCap, cboLoaiSanPham, dgvDanhSachSanPham, lblTongSoTrang, 8);
                phantrangAdapter.SetRecordPerPageCombobox(8, 4);
                cboRecordPerPage.SelectedIndex = 1;
                recordsPerPage = int.Parse(cboRecordPerPage.SelectedItem.ToString());
                dgvDanhSachSanPham.DataSource = phantrangAdapter.GetData(recordsPerPage);
                totalRecords = phantrangAdapter.GetRowCount();
                lblTongSoTrang.Text = currentPage + "/" + totalRecords.ToString();
                //==============================================================================
                //--..........................................................................--
                //------------------.      Khởi tạo thao tác datagridview       .---------------
                //--.................            sản phẩm hóa đơn             ..................
                //==============================================================================
                //khởi tạo banhang sanPhamController điều khiển luồng dữ liệu trên form bán hàng
                banhangController = new AdapterBanHang(txtSDTKhachHang, txtTenKhachHang, txtMaHoaDon, txtSoLuongMua, lblTongTien, dgvThongTinHoaDon, dgvDanhSachSanPham, hoadon, tcManHinhBanHang);
                banhangController.ChangeHeaderNameDanhThongTinHoaDon();
                banhangController.ChangeHeaderNameDanhSachSanPham();
                banhangController.CreateButtonClickHoaDonSanPham();


                lblTongTien.Text = "0";
                txtSoLuongMua.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            // Lấy giá trị được chọn từ ComboBox
            recordsPerPage = (int)cboRecordPerPage.SelectedItem;
            if (recordsPerPage <= 0 && cboRecordPerPage.SelectedIndex <= 0)
            {
                // Thực hiện hành động khi người dùng chọn "Tất cả"
                cboRecordPerPage.SelectedIndex = 1;
            }
            else
            {
                dgvDanhSachSanPham.DataSource = phantrangAdapter.GetData(recordsPerPage);
            }
        }
        //==============================================================================
        //--..........................................................................--
        //------------------.       Sự kiện tìm kiếm sản phẩm     .---------------------
        //--..........................................................................--
        //==============================================================================

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
            phantrangAdapter.btnNext_Click(sender, e);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            phantrangAdapter.btnPrevious_Click(sender, e);
        }
        //==============================================================================
        //--..........................................................................--
        //------------------Sự kiện event kiểm tra nhập số điện thoại-------------------
        //--..........................................................................--
        //==============================================================================
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxHelper.HandlePhoneNumber(sender, e);
        }
        //==============================================================================
        //--..........................................................................--
        //------------------Sự kiện event bấm thanh toán -------------------------------
        //--..........................................................................--
        //==============================================================================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                banhangController.btnThanhToan_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //==============================================================================
        //--..........................................................................--
        //------------------Sự kiện event tăng giảm số lượng mua------------------------
        //--..........................................................................--
        //==============================================================================
        private void dgvThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            banhangController.dgvThongTinHoaDon_CellContentClick(sender, e);
        }
        private void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            banhangController.dgvDanhSachSanPham_CellClick(sender, e);
            if (banhangController.Lblthanhtien != null)
            {
                lblTongTien.Text = banhangController.Lblthanhtien.Text;
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
            lblTongTien.Text = banhangController.Lblthanhtien.Text;
            txtSoLuongMua.Text = banhangController.TxtSoLuongMua.Text;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            phantrangAdapter.btnRefresh_Click(sender, e);
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            TextboxHelper.HandleTextChange_FullName(sender);
        }

        private void txtTenSanPham_TextChanged(object sender, EventArgs e)
        {
            TextboxHelper.HandleTextChange_FullName(sender);
        }

        private void tcManHinhBanHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcManHinhBanHang.SelectedTab == tcManHinhBanHang.TabPages[1])
            {
                // Do something here
                //MessageBox.Show("banhangController.Hoadon.MaHD: " + txtMaHoaDon.Text);
                //==============================================================================
                //--..........................................................................--
                //------------------        Tạo report in hóa đơn       ------------------------
                //--..........................................................................--
                //==============================================================================


                //if (!string.IsNullOrEmpty(banhangController.Hoadon.MaHD))
                //{
                //    ReportHelper rh = new ReportHelper(
                //        reportManager,
                //        "PhieuInHoaDon",
                //        new Dictionary<string, string> { { "@mahd", banhangController.Hoadon.MaHD } },
                //        this.crystalReportViewer1);
                //    rh.LoadReport();
                //}
                //else
                //{
                //    MessageBox.Show("Không tìm thấy mã hd");
                //}
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //==============================================================================
            //--..........................................................................--
            //------------------        Tạo report in hóa đơn       ------------------------
            //--..........................................................................--
            //==============================================================================
            if (!string.IsNullOrEmpty(banhangController.Hoadon.MaHD))
            {
                ReportHelper rh = new ReportHelper(
                    reportManager,
                    "PhieuInHoaDon",
                    new Dictionary<string, string> { { "@mahd", banhangController.Hoadon.MaHD } },
                    this.crystalReportViewer1);
                rh.LoadReport();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã hd");
            }
        }
    }
}