using System.Windows.Forms;
using System;
using LTUD1_BACHHOAXANH472.Model;
using LTUD1_BACHHOAXANH472.controller;
using LTUD1_BACHHOAXANH472;

namespace LTUD1_BACHHOAXANH472
{
    public class PBanHangController
    {
        int soluongmua;
        double tongtien;
        TextBox txtSDTKhachHang;
        TextBox txtTenKhachHang;
        TextBox txtMaHoaDon;
        Label lblTongTien;

        RandomStringGenerator rnd = new RandomStringGenerator();

        DataGridView dgvThongTinHoaDon;
        DataGridView dgvDanhSachSanPham;

        ChiTietHoaDonController cthdController = new ChiTietHoaDonController(Utils.ConnectionString);
        HoaDonController hoadonController = new HoaDonController(Utils.ConnectionString);
        KhachHangController khachHangController = new KhachHangController(Utils.ConnectionString);


        public int Soluongmua { get => soluongmua; set => soluongmua = value; }
        public double Tongtien { get => tongtien; set => tongtien = value; }
        public TextBox TxtSDTKhachHang { get => txtSDTKhachHang; set => txtSDTKhachHang = value; }
        public TextBox TxtTenKhachHang { get => txtTenKhachHang; set => txtTenKhachHang = value; }
        public TextBox TxtMaHoaDon { get => txtMaHoaDon; set => txtMaHoaDon = value; }
        public Label LblTongTien { get => lblTongTien; set => lblTongTien = value; }
        public DataGridView DgvThongTinHoaDon { get => dgvThongTinHoaDon; set => dgvThongTinHoaDon = value; }
        public DataGridView DgvDanhSachSanPham { get => dgvDanhSachSanPham; set => dgvDanhSachSanPham = value; }

        //Map datarow từ grid sản phẩm sang grid hóa đơn
        private DataGridViewRow MapDataRow(DataGridViewRow rowDanhSachSanPham)
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
        private int TinhSoLuongTonTheoMa(string maSP)
        {
            int soLuongTon = 0;
            foreach (DataGridViewRow row in dgvDanhSachSanPham.Rows)
            {
                if (maSP.Trim() == row.Cells[1].Value.ToString().Trim())
                    soLuongTon += Convert.ToInt32(row.Cells[4].Value.ToString());
            }
            return soLuongTon;
        }

        private bool KiemTraLonHonTon(string maSP)
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

        private void SetTongTienVaTongSoLuong()
        {
            foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
            {
                soluongmua += Convert.ToInt32(row.Cells[4].Value);
                tongtien += Convert.ToDouble(row.Cells[5].Value);
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
                if (string.IsNullOrEmpty(txtTenKhachHang.Text) && string.IsNullOrEmpty(txtSDTKhachHang.Text))
                {
                    MessageBox.Show("Vui lòng không để trống thông tin khách hàng", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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
                if (DialogResult.Yes == MessageBox.Show("Thanh toán thành công!\nBạn có muốn in hóa đơn", "In hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    FormInPhieuThanhToan frmThanhToan = new FormInPhieuThanhToan();
                    frmThanhToan.ShowDialog();
                }

                MessageBox.Show("Thanh toán thành công", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
        }
    }

}
