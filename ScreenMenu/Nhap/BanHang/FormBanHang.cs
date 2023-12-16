using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.HoaDon;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.BanHang
{
    public partial class FormBanHang : Form
    {
        ChiTietHoaDonController cthdController = new ChiTietHoaDonController(Utils.ConnectionString);
        HoaDonController hoadonController = new HoaDonController(Utils.ConnectionString);
        DanhMucController danhMucController = new DanhMucController(Utils.ConnectionString);
        SanPhamController sanPhamController = new SanPhamController(Utils.ConnectionString);
        NhaCungCapController nhaCungCapController = new NhaCungCapController(Utils.ConnectionString);
        RandomStringGenerator rnd = new RandomStringGenerator();

        public FormBanHang()
        {
            InitializeComponent();
            // Vô hiệu hóa sự kiện CellValueChanged
            dgvThongTinHoaDon.CellValueChanged -= dgvThongTinHoaDon_CellValueChanged;
            // tạo mã random cho mã hóa đơn
            txtMaHoaDon.Text = rnd.GenerateRandomAlphanumericString(11);

            // thêm dữ liệu vào datagridview sản phẩm
            sanPhamController.SelectAll();
            dgvDanhSachSanPham.DataSource = sanPhamController.DataSource;
            // thêm dữ liệu vào loại sản phẩm 
            danhMucController.SelectAll();
            cboLoaiSanPham.DataSource = danhMucController.DataSource;
            cboLoaiSanPham.ValueMember = "MALOAI";
            cboLoaiSanPham.DisplayMember = "TENLOAI";

            // thêm dữ liệu vào combobox nhà cung cấp
            cboNhaCungCap.DataSource = nhaCungCapController.sp_cbo_nhacungcap_select_all();
            //cboLoaiSanPham.ValueMember = "TENNCC";
            //cboLoaiSanPham.DisplayMember = "TENNCC";
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            DataGridViewHelper.ConfigureDataGridView(dgvThongTinHoaDon);
            DataGridViewHelper.ConfigureDataGridView(dgvDanhSachSanPham);
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            //
            FormInPhieuThanhToan frmThanhToan = new FormInPhieuThanhToan();
            frmThanhToan.Show();
        }
        private void dgvThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kích hoạt lại sự kiện CellValueChanged
            //dgvThongTinHoaDon.CellValueChanged += dgvThongTinHoaDon_CellValueChanged;

            // Kiểm tra xem người dùng có nhấp vào cột nút tăng số lượng hay không
            if (e.ColumnIndex == dgvThongTinHoaDon.Columns["BtnTangSL"].Index && e.RowIndex >= 0)
            {
                // Tăng số lượng sản phẩm
                int sl = int.Parse(dgvThongTinHoaDon.Rows[e.RowIndex].Cells["SL"].Value.ToString());
                dgvThongTinHoaDon.Rows[e.RowIndex].Cells["SL"].Value = sl + 1;
            }

            // Kiểm tra xem người dùng có nhấp vào cột nút giảm số lượng hay không
            if (e.ColumnIndex == dgvThongTinHoaDon.Columns["btnGiamSL"].Index && e.RowIndex >= 0)
            {
                // Giảm số lượng sản phẩm
                int sl = int.Parse(dgvThongTinHoaDon.Rows[e.RowIndex].Cells["SL"].Value.ToString());
                if (sl > 0)
                {
                    dgvThongTinHoaDon.Rows[e.RowIndex].Cells["SL"].Value = sl - 1;
                }
            }
        }
        private void dgvThongTinHoaDon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Đảm bảo rằng tất cả dữ liệu đã được tải xong
            if (e.ListChangedType != ListChangedType.ItemDeleted)
            {
                // Thực hiện các thao tác trên DataGridView tại đây
            }
        }

        private void dgvThongTinHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvThongTinHoaDon.RowCount > 0)
                {
                    // dgvThongTinHoaDon đã có dữ liệu
                    // Kiểm tra xem người dùng có thay đổi giá trị trong cột "SL" hay không
                    if (e.ColumnIndex == dgvThongTinHoaDon.Columns["SL"].Index && e.RowIndex >= 0)
                    {
                        // Lấy số lượng sản phẩm mới
                        int sl = int.Parse(dgvThongTinHoaDon.Rows[e.RowIndex].Cells["SL"].Value.ToString());

                        // Lấy đơn giá
                        decimal donGia = decimal.Parse(dgvThongTinHoaDon.Rows[e.RowIndex].Cells["DonGia"].Value.ToString());

                        // Tính toán tổng tiền mới
                        decimal thanhTien = sl * donGia;

                        // Cập nhật tổng tiền trong DataGridView
                        dgvThongTinHoaDon.Rows[e.RowIndex].Cells["ThanhTien"].Value = thanhTien;
                    }
                }
                else
                {
                    // dgvThongTinHoaDon chưa có dữ liệu

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CapNhatTongSoLuongMua()
        {
            int tongSoLuongMua = 0;

            // Duyệt qua tất cả các dòng trong dgvThongTinHoaDon
            foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
            {
                // Lấy số lượng từ mỗi dòng
                int soLuong = Convert.ToInt32(row.Cells["SL"].Value);

                // Cộng số lượng vào tổng số lượng mua
                tongSoLuongMua += soLuong;
            }

            // Cập nhật ô txtSoLuongMua với tổng số lượng mua mới
            txtSoLuongMua.Text = tongSoLuongMua.ToString();
        }

        private void CapNhatTongTien()
        {
            decimal tongTien = 0;

            // Duyệt qua tất cả các dòng trong dgvThongTinHoaDon
            foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
            {
                // Lấy số lượng và đơn giá từ mỗi dòng
                int soLuong = Convert.ToInt32(row.Cells["SL"].Value);
                decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);

                // Tính thành tiền và cộng vào tổng tiền
                tongTien += soLuong * donGia;
            }

            // Cập nhật label với tổng tiền mới
            lblTongTien.Text = tongTien.ToString("N0");
        }

        private void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào cột nút "btnThemGioHang" hay không
            if (e.ColumnIndex == dgvDanhSachSanPham.Columns["btnThemGioHang"].Index && e.RowIndex >= 0)
            {
                // Thêm sản phẩm vào dgvThongTinHoaDon hoặc cập nhật số lượng nếu sản phẩm đã tồn tại

                // Lấy thông tin sản phẩm từ dgvDanhSachSanPham
                string maSP = dgvDanhSachSanPham.Rows[e.RowIndex].Cells["MaSPP"].Value.ToString();
                string tenSP = dgvDanhSachSanPham.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
                decimal donGia = decimal.Parse(dgvDanhSachSanPham.Rows[e.RowIndex].Cells["DonGia"].Value.ToString());
                decimal km = decimal.Parse(dgvDanhSachSanPham.Rows[e.RowIndex].Cells["KM"].Value.ToString());

                // Tìm sản phẩm trong dgvThongTinHoaDon
                foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
                {
                    if (row.Cells["MaSP"].Value.ToString() == maSP)
                    {
                        // Nếu sản phẩm đã tồn tại, tăng số lượng lên 1
                        row.Cells["SL"].Value = int.Parse(row.Cells["SL"].Value.ToString()) + 1;
                        return;
                    }
                }

                // Nếu sản phẩm chưa tồn tại, thêm một dòng mới vào dgvThongTinHoaDon
                dgvThongTinHoaDon.Rows.Add(maSP, tenSP, donGia, km, 1);

                // Cập nhật tổng tiền
                CapNhatTongTien();
                // Cập nhật tổng số lượng
                CapNhatTongSoLuongMua();
            }
        }
        private void btnHuyThanhToan_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn hủy thanh toán và xóa tất cả các mục trong giỏ hàng không?", "Xác nhận hủy thanh toán", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Xóa tất cả các dòng trong dgvThongTinHoaDon
                dgvThongTinHoaDon.Rows.Clear();

                // Cập nhật tổng tiền
                CapNhatTongTien();
                // Cập nhật tổng số lượng
                CapNhatTongSoLuongMua();
            }
        }
        private PictureBox currentPictureBox;
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

                if (currentPictureBox.Width >= 32) // MAX_WIDTH là kích thước tối đa bạn muốn phóng to
                {
                    isZoomingIn = false;
                }
            }
            else
            {
                currentPictureBox.Width -= 1;
                currentPictureBox.Height -= 1;

                if (currentPictureBox.Width <= 24) // MIN_WIDTH là kích thước tối thiểu bạn muốn thu nhỏ
                {
                    isZoomingIn = true;
                }
            }
        }


    }
}
