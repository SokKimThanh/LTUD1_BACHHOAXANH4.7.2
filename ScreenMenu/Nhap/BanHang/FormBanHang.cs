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

        private BindingSource bindingSource1 = new BindingSource();
        private int currentPage = 1;
        private int pageSize = 4;
        private int pageCount = 0;
        private PictureBox currentPictureBox;

        BanHangController banghangController = new BanHangController();

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

        public FormBanHang()
        {
            InitializeComponent();
            phantrang = new PhanTrangSanPham(bindingSource1, currentPage, pageSize, pageCount);


            // Vô hiệu hóa sự kiện CellValueChanged

            // tạo mã random cho mã hóa đơn
            txtMaHoaDon.Text = rnd.GenerateRandomAlphanumericString(11);

            // thêm dữ liệu vào datagridview sản phẩm

            dgvDanhSachSanPham.DataSource = phantrang.DanhSachSanPham;

            // thêm dữ liệu vào loại sản phẩm 
            danhMucController.SelectAll();
            cboLoaiSanPham.DataSource = danhMucController.DataSource;
            cboLoaiSanPham.ValueMember = "MALOAI";
            cboLoaiSanPham.DisplayMember = "TENLOAI";

            // thêm dữ liệu vào combobox nhà cung cấp
            nhaCungCapController.SelectAll();
            cboNhaCungCap.DataSource = nhaCungCapController.DataSource;
            cboNhaCungCap.ValueMember = "MANCC";
            cboNhaCungCap.DisplayMember = "TENNCC";

            bindingSource1.DataSource = sanPhamController.PhanTrang(currentPage, pageSize, null, null, null);
            dgvDanhSachSanPham.DataSource = bindingSource1;
            pageCount = sanPhamController.GetRowCount() / pageSize; ;
            lblTongSoTrang.Text = $"Trang {currentPage}/{pageCount}";//Trang 1/40
        }
        private void FormBanHang_Load(object sender, EventArgs e)
        {
            cboLoaiSanPham.DataSource = danhMucController.sp_cbo_danhmuc_select_all();
            cboLoaiSanPham.ValueMember = "MALOAI";
            cboLoaiSanPham.DisplayMember = "TENLOAI";

            cboNhaCungCap.DataSource = nhaCungCapController.sp_cbo_nhacungcap_select_all();
            cboNhaCungCap.ValueMember = "MANCC";
            cboNhaCungCap.DisplayMember = "TENNCC";


            DataGridViewHelper.ConfigureDataGridView(dgvThongTinHoaDon);

            DataGridViewHelper.ChangeHeaderNameDanhThongTinHoaDon(dgvThongTinHoaDon);

            //DataGridViewHelper.ChangeHeaderNameDanhSachSanPham(dgvDanhSachSanPham);
            DataGridViewHelper.ConfigureDataGridView(dgvDanhSachSanPham);
            DataGridViewHelper.TaoCotAddToCast(dgvDanhSachSanPham);

            //format theo nhu cầu :) 
            dgvThongTinHoaDon.ScrollBars = ScrollBars.Both;
            dgvThongTinHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDanhSachSanPham.ScrollBars = ScrollBars.Both;
            dgvDanhSachSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            string loaisanpham = cboLoaiSanPham.SelectedValue.ToString();
            string nhacungcap = cboNhaCungCap.SelectedValue.ToString();
            string tensanpham = txtTenSanPham.Text;

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //Loại bỏ những dòng có số lượng < 0 đi

            foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
            {
                int soLuong = Convert.ToInt32(row.Cells[4].Value);
                if (soLuong == 0) // loại hết những dòng có số lượng < 0
                {
                    dgvThongTinHoaDon.Rows.Remove(row);
                }

            }
            if (dgvThongTinHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào hóa đơn", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Xác nhận thanh toán", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (string.IsNullOrEmpty(txtTenKhachHang.Text) && string.IsNullOrEmpty(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng không để trống thông tin khách hàng", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    return;
                }
                KhachHang khachHang = new KhachHang();

                khachHang.Ma = rnd.GenerateRandomAlphanumericString(11);
                khachHang.Ten = txtTenKhachHang.Text;
                khachHang.Sdt = Convert.ToInt32(txtSDT.Text);

                khachHangController.Insert(khachHang);

                HoaDon hoaDon = new HoaDon(txtMaHoaDon.Text, "manv_admin", khachHang.Ma, DateTime.Now, Convert.ToDecimal(lblTongTien.Text));

                hoadonController.Insert(hoaDon);
                foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
                {
                    ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(txtMaHoaDon.Text, row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[4].Value));
                    cthdController.Insert(chiTietHoaDon);
                }
                if (DialogResult.Yes == MessageBox.Show("Thanh toán thành công!\nBạn có muốn in hóa đơn", "In hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    FormInPhieuThanhToan frmThanhToan = new FormInPhieuThanhToan();
                    frmThanhToan.ShowDialog();
                }

                MessageBox.Show("Thanh toán thành công", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }

        }

        private void dgvThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tăng số lượng
            if (e.ColumnIndex == dgvThongTinHoaDon.Columns["BtnTangSL"].Index && e.RowIndex >= 0)
            {
                string maSP = dgvThongTinHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                if (KiemTraLonHonTon(maSP)) // check tồn
                {
                    double soLuong = Convert.ToInt32(dgvThongTinHoaDon.Rows[e.RowIndex].Cells[4].Value) + 1;

                    dgvThongTinHoaDon.Rows[e.RowIndex].Cells[4].Value = soLuong; // gán lại số lượng

                    double khuyenMai = Convert.ToInt32(dgvThongTinHoaDon.Rows[e.RowIndex].Cells[3].Value);

                    double donGia = Convert.ToInt32(dgvThongTinHoaDon.Rows[e.RowIndex].Cells[2].Value);

                    //Tính toán tổng
                    dgvThongTinHoaDon.Rows[e.RowIndex].Cells[5].Value = donGia * (khuyenMai / 100) * soLuong;

                }
                else
                {
                    MessageBox.Show($"Mã {maSP} không đủ số lượng!", "Lỗi thêm số lượng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            // Kiểm tra xem người dùng có nhấp vào cột nút giảm số lượng hay không
            if (e.ColumnIndex == dgvThongTinHoaDon.Columns["btnGiamSL"].Index && e.RowIndex >= 0)
            {
                double soLuong = Convert.ToInt32(dgvThongTinHoaDon.Rows[e.RowIndex].Cells[4].Value) - 1;

                if (soLuong < 0)
                {
                    MessageBox.Show($"Số lượng không được  < 0!", "Lỗi giảm số lượng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvThongTinHoaDon.Rows[e.RowIndex].Cells[4].Value = soLuong; // gán lại số lượng

                double khuyenMai = Convert.ToInt32(dgvThongTinHoaDon.Rows[e.RowIndex].Cells[3].Value);

                double donGia = Convert.ToInt32(dgvThongTinHoaDon.Rows[e.RowIndex].Cells[2].Value);

                //Tính toán tổng
                dgvThongTinHoaDon.Rows[e.RowIndex].Cells[5].Value = donGia * (khuyenMai / 100) * soLuong;
            }

            SetTongTienVaTongSoLuong();
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

    }
}
