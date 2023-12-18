using LTUD1_BACHHOAXANH472.controller;
using LTUD1_BACHHOAXANH472.Model;
using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.BanHang;
using System;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public class PBanHangController
    {

        TextBox txtSDTKhachHang = new TextBox();
        TextBox txtTenKhachHang = new TextBox();
        TextBox txtMaHoaDon = new TextBox();
        TextBox txtSoLuongMua = new TextBox();
        Label lblTongTien = new Label();
        TabControl tcManHinhBanHang = new TabControl();

        RandomStringGenerator rnd = new RandomStringGenerator();

        DataGridView dgvThongTinHoaDon;
        DataGridView dgvDanhSachSanPham;

        ChiTietHoaDonController cthdController = new ChiTietHoaDonController(Utils.ConnectionString);
        HoaDonController hoadonController = new HoaDonController(Utils.ConnectionString);
        KhachHangController khachHangController = new KhachHangController(Utils.ConnectionString);

        public TextBox TxtSDTKhachHang { get => txtSDTKhachHang; set => txtSDTKhachHang = value; }
        public TextBox TxtTenKhachHang { get => txtTenKhachHang; set => txtTenKhachHang = value; }
        public TextBox TxtMaHoaDon { get => txtMaHoaDon; set => txtMaHoaDon = value; }
        public Label LblTongTien { get => lblTongTien; set => lblTongTien = value; }
        public DataGridView DgvThongTinHoaDon { get => dgvThongTinHoaDon; set => dgvThongTinHoaDon = value; }
        public DataGridView DgvDanhSachSanPham { get => dgvDanhSachSanPham; set => dgvDanhSachSanPham = value; }
        public TextBox TxtSoLuongMua { get => txtSoLuongMua; set => txtSoLuongMua = value; }
        public TabControl TcManHinhBanHang { get => tcManHinhBanHang; set => tcManHinhBanHang = value; }

        //Map datarow từ grid sản phẩm sang grid hóa đơn
        public DataGridViewRow MapDataRow(DataGridViewRow rowDanhSachSanPham)
        {
            //Thêm 1 obj cho dgvThongTinHoaDon vì dữ các cột không đồng bộ

            DataGridViewRow row = new DataGridViewRow();

            //Tạo columns cho từng hàng
            for (int i = 0; i < dgvThongTinHoaDon.Columns.Count - 2; i++)
            {
                row.Cells.Add(new DataGridViewTextBoxCell());
            }
            row.Cells[0].Value = rowDanhSachSanPham.Cells[1].Value;
            row.Cells[1].Value = rowDanhSachSanPham.Cells[2].Value;
            row.Cells[2].Value = rowDanhSachSanPham.Cells[3].Value;
            row.Cells[3].Value = rowDanhSachSanPham.Cells[5].Value;//tính tiền khuyến mãi sau giảm giá 
            row.Cells[4].Value = 0;
            row.Cells[5].Value = 0;

            row.Cells.Add(new DataGridViewButtonCell());
            row.Cells[6].Value = "+";
            row.Cells.Add(new DataGridViewButtonCell());
            row.Cells[7].Value = "-";
            return row;
        }
        public int TinhSoLuongTonTheoMa(string maSP)
        {
            int soLuongTon = 0;
            foreach (DataGridViewRow row in dgvDanhSachSanPham.Rows)
            {
                if (maSP.Trim() == row.Cells[2].Value.ToString().Trim())
                    soLuongTon += Convert.ToInt32(row.Cells[8].Value.ToString());
            }
            return soLuongTon;
        }

        public bool KiemTraLonHonTon(string maSP)
        {
            int soLuongTruocKhiThem = 0;
            int soLuongTon = TinhSoLuongTonTheoMa(maSP);

            foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
            {
                if (maSP.Trim() == row.Cells[0].Value.ToString().Trim())
                {
                    soLuongTruocKhiThem += Convert.ToInt32(row.Cells[4].Value.ToString().Trim());
                }
            }

            if (soLuongTruocKhiThem < soLuongTon)
            {
                return true;
            }
            return false;
        }

        public void SetTongTienVaTongSoLuong()
        {
            int soluongmua = 0;
            double tongtien = 0;
            foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
            {
                soluongmua += Convert.ToInt32(row.Cells[4].Value);
                tongtien += Convert.ToDouble(row.Cells[5].Value);
            }
            txtSoLuongMua.Text = soluongmua.ToString();
            if (lblTongTien != null)
            {
                lblTongTien.Text = tongtien.ToString();
            }
            else
            {
                // Xử lý trường hợp lblTongTien là null
            }
        }


        public void dgvThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    dgvThongTinHoaDon.Rows[e.RowIndex].Cells[5].Value = khuyenMai * soLuong;

                }
                else
                {
                    MessageBox.Show($"Mã {maSP} không đủ số lượng!", "Lỗi thêm số lượng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            // Kiểm tra xem người dùng có nhấp vào cột nút giảm số lượng hay không
            else if (e.ColumnIndex == dgvThongTinHoaDon.Columns["btnGiamSL"].Index && e.RowIndex >= 0)
            {
                double soLuong = Convert.ToInt32(dgvThongTinHoaDon.Rows[e.RowIndex].Cells[4].Value) - 1;

                if (soLuong < 0)
                {
                    MessageBox.Show($"Số lượng không được  < 0!", "Lỗi giảm số lượng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgvThongTinHoaDon.Rows[e.RowIndex].Cells[4].Value = soLuong; // gán lại số lượng

                double khuyenMai = Convert.ToInt32(dgvThongTinHoaDon.Rows[e.RowIndex].Cells[3].Value);

                double donGia = Convert.ToInt32(dgvThongTinHoaDon.Rows[e.RowIndex].Cells[2].Value);

                //Tính toán tổng
                dgvThongTinHoaDon.Rows[e.RowIndex].Cells[5].Value = khuyenMai * soLuong;
            }

            SetTongTienVaTongSoLuong();
        }
        public void btnThanhToan_Click(object sender, EventArgs e)
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
                MessageBox.Show("Vui lòng thêm sản phẩm vào hóa đơn", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Xác nhận thanh toán", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (string.IsNullOrEmpty(txtTenKhachHang.Text) && string.IsNullOrEmpty(txtSDTKhachHang.Text))
                {
                    MessageBox.Show("Vui lòng không để trống thông tin khách hàng", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                KhachHang khachHang = new KhachHang();

                khachHang.Ma = rnd.GenerateRandomAlphanumericString(11);
                khachHang.Ten = txtTenKhachHang.Text;
                khachHang.Sdt = Convert.ToInt32(txtSDTKhachHang.Text);

                khachHangController.Insert(khachHang);

                HoaDon hoaDon = new HoaDon(txtMaHoaDon.Text, "manv_admin", khachHang.Ma, DateTime.Now, Convert.ToDecimal(lblTongTien.Text));

                hoadonController.Insert(hoaDon);
                foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
                {
                    ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(txtMaHoaDon.Text, row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[4].Value));
                    cthdController.Insert(chiTietHoaDon);
                }
                //==============================================================================
                //--..........................................................................--
                //------------------        Sự kiện in hóa đơn       ---------------------------
                //--..........................................................................--
                //==============================================================================
                if (DialogResult.Yes == MessageBox.Show("Thanh toán thành công!\nBạn có muốn in hóa đơn", "In hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    /* FormInPhieuHoaDon frmThanhToan = new FormInPhieuHoaDon();
                     frmThanhToan.ShowDialog();*/
                    // Lấy tabControlXemDuLieu từ form hoặc từ nơi nó được khởi tạo
                    //TabControl tcManHinhBanHang = this.tcManHinhBanHang;
                    tcManHinhBanHang.SelectedIndex = 2;
                    
                }

                MessageBox.Show("Thanh toán thành công", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
        }
        public void btnHuyThanhToan_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn hủy thanh toán và xóa tất cả các mục trong giỏ hàng không?", "Xác nhận hủy thanh toán", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                // Xóa tất cả các dòng trong dgvThongTinHoaDon
                dgvThongTinHoaDon.Rows.Clear();
                txtTenKhachHang.Text = "";
                TxtSDTKhachHang.Text = "";
                lblTongTien.Text = "";
                txtSoLuongMua.Text = "";
            }
        }

        public void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào cột nút "btnThemGioHang" hay không
            if (e.ColumnIndex == dgvDanhSachSanPham.Columns["btnThemGioHang"].Index && e.RowIndex >= 0)
            {
                // Thêm sản phẩm vào dgvThongTinHoaDon hoặc cập nhật số lượng nếu sản phẩm đã tồn tại

                // Lấy thông tin sản phẩm từ dgvDanhSachSanPham
                string maSP = dgvDanhSachSanPham.Rows[e.RowIndex].Cells["MASP"].Value.ToString();
                string tenSP = dgvDanhSachSanPham.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
                decimal donGia = decimal.Parse(dgvDanhSachSanPham.Rows[e.RowIndex].Cells["DonGia"].Value.ToString());
                decimal km = decimal.Parse(dgvDanhSachSanPham.Rows[e.RowIndex].Cells["GIABAN"].Value.ToString());

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
                //CapNhatTongTien();
                // Cập nhật tổng số lượng
                //CapNhatTongSoLuongMua();
                SetTongTienVaTongSoLuong();
            }
        }
        public void ChangeHeaderNameDanhThongTinHoaDon()
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

        public void ChangeHeaderNameDanhSachSanPham()
        {


            dgvDanhSachSanPham.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgvDanhSachSanPham.Columns[2].HeaderText = "Tên Sản Phẩm";
            dgvDanhSachSanPham.Columns[3].HeaderText = "Đơn Vị Tính";
            dgvDanhSachSanPham.Columns[4].HeaderText = "Giá gốc";
            dgvDanhSachSanPham.Columns[5].HeaderText = "% Giảm giá";
            dgvDanhSachSanPham.Columns[6].HeaderText = "Giá bán";
            dgvDanhSachSanPham.Columns[7].HeaderText = "SL Tồn";
            //dgvDanhSachSanPham.Columns[8].HeaderText = "Mã Loại";
            //dgvDanhSachSanPham.Columns[9].HeaderText = "Mã NCC";
            //dgvDanhSachSanPham.Columns[10].HeaderText = "Mã KM";
        }

        public void TaoCotThemGioHang()
        {
            DataGridViewButtonColumn colThemGioHang = new DataGridViewButtonColumn();
            colThemGioHang.Name = "btnThemGioHang";
            colThemGioHang.HeaderText = "Giỏ hàng";
            dgvDanhSachSanPham.Columns.Add(colThemGioHang);
            ErrColors color = new ErrColors();
            foreach (DataGridViewRow row in dgvDanhSachSanPham.Rows)
            {
                DataGridViewCell cell = new DataGridViewButtonCell();
                cell.Value = "+";
                cell.Style.BackColor = color.primaryGreen;
                cell.Style.ForeColor = color.primaryPink;
                row.Cells[dgvDanhSachSanPham.Columns["btnThemGioHang"].Index].Value = cell.Value;
            }
        }

    }

}
