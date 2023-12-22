using LTUD1_BACHHOAXANH472.controller;
using LTUD1_BACHHOAXANH472.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public class AdapterBanHang
    {

        ChiTietHoaDonController cthdController = new ChiTietHoaDonController(Utils.ConnectionString);
        HoaDonController hoadonController = new HoaDonController(Utils.ConnectionString);
        KhachHangController khachHangController = new KhachHangController(Utils.ConnectionString);
        RandomStringGenerator rnd = new RandomStringGenerator();
        HoaDon hoadon;

        TextBox txtSDTKhachHang = new TextBox();
        TextBox txtTenKhachHang = new TextBox();
        TextBox txtMaHoaDon = new TextBox();
        TextBox txtSoLuongMua = new TextBox();
        Label lblthanhtien = new Label();
        private string manhanvien;
        private string makhachhang;

        DataGridView dgvThongTinHoaDon;
        DataGridView dgvDanhSachSanPham;

        double tongthanhtien = 0;
        double tongsoluong = 0;
        private string btnNameThemHDCT;// tên nút thêm hóa đơn ct
        TabControl tcManHinhBanHang = new TabControl();

        public AdapterBanHang()
        {

        }

        public AdapterBanHang(TextBox txtSDTKhachHang, TextBox txtTenKhachHang, TextBox txtMaHoaDon, TextBox txtSoLuongMua, Label lblthanhtien, DataGridView dgvThongTinHoaDon, DataGridView dgvDanhSachSanPham, HoaDon hoadon, TabControl tcManHinhBanHang)
        {
            this.txtSDTKhachHang = txtSDTKhachHang;
            this.txtTenKhachHang = txtTenKhachHang;
            this.txtMaHoaDon = txtMaHoaDon;
            this.txtSoLuongMua = txtSoLuongMua;
            this.lblthanhtien = lblthanhtien;
            this.dgvThongTinHoaDon = dgvThongTinHoaDon;
            this.dgvDanhSachSanPham = dgvDanhSachSanPham;
            this.hoadon = hoadon;
            this.tcManHinhBanHang = tcManHinhBanHang;
        }

        public TextBox TxtSDTKhachHang { get => txtSDTKhachHang; set => txtSDTKhachHang = value; }
        public TextBox TxtTenKhachHang { get => txtTenKhachHang; set => txtTenKhachHang = value; }
        public TextBox TxtMaHoaDon { get => txtMaHoaDon; set => txtMaHoaDon = value; }
        public Label Lblthanhtien { get => lblthanhtien; set => lblthanhtien = value; }
        public DataGridView DgvThongTinHoaDon { get => dgvThongTinHoaDon; set => dgvThongTinHoaDon = value; }
        public DataGridView DgvDanhSachSanPham { get => dgvDanhSachSanPham; set => dgvDanhSachSanPham = value; }
        public TextBox TxtSoLuongMua { get => txtSoLuongMua; set => txtSoLuongMua = value; }
        public double Tongthanhtien { get => tongthanhtien; set => tongthanhtien = value; }
        public double Tongsoluong { get => tongsoluong; set => tongsoluong = value; }
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public HoaDon Hoadon { get => hoadon; set => hoadon = value; }
        public TabControl TcManHinhBanHang { get => tcManHinhBanHang; set => tcManHinhBanHang = value; }

        /// <summary>
        /// Map datarow từ grid sản phẩm sang grid hóa đơn
        /// </summary>
        /// <param name="rowDanhSachSanPham">một dòng sản phẩm được chọn</param>
        /// <returns></returns>
        public DataGridViewRow MapDataRow(DataGridViewRow rowDanhSachSanPham)
        {
            // Kiểm tra xem sản phẩm đã tồn tại trong dgvThongTinHoaDon hay chưa
            //dgvThongTinHoaDon.Columns["SL"].Index
            foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
            {
                int columnIndex = dgvThongTinHoaDon.CurrentCell.ColumnIndex; // Lấy chỉ số cột hiện tại
                string columnName = dgvThongTinHoaDon.Columns[columnIndex].Name; // Lấy tên cột

                if (row.Cells["MASP"].Value.ToString() == rowDanhSachSanPham.Cells["MASP"].Value.ToString())
                {
                    // Nếu sản phẩm đã tồn tại, tăng số lượng lên 1 và cập nhật tổng tiền
                    int soluongmuahang = 0;
                    if (dgvThongTinHoaDon.Columns.Contains("SL") && row.Cells["SL"].Value != null)
                    {
                        soluongmuahang = int.Parse(row.Cells["SL"].Value.ToString()) + 1;

                        // kiểm tra tồn kho
                        if (soluongmuahang <= int.Parse(rowDanhSachSanPham.Cells["SLTONKHO"].Value.ToString()))
                        {
                            row.Cells["SL"].Value = soluongmuahang; // Cập nhật số lượng
                        }
                        else
                        {
                            throw new Exception("Không đủ số lượng cung cấp!");
                        }
                    }
                    int khuyenmai = int.Parse(row.Cells["KM"].Value.ToString());

                    double thanhtien = soluongmuahang * khuyenmai; // Tính lại tổng tiền
                    row.Cells["THANHTIEN"].Value = thanhtien; // Cập nhật tổng tiền

                    return null; // Trả về null vì không cần thêm hàng mới
                }
            }

            // Nếu sản phẩm chưa tồn tại, tạo một hàng mới
            DataGridViewRow newRow = new DataGridViewRow();

            // Tạo các ô cho từng cột
            for (int i = 0; i < dgvThongTinHoaDon.Columns.Count - 2; i++) // -2: Bỏ qua 2 ô cuối là ô cộng trừ
            {
                newRow.Cells.Add(new DataGridViewTextBoxCell());
            }

            // Điền thông tin sản phẩm vào hàng mới
            newRow.Cells[dgvThongTinHoaDon.Columns["MASP"].Index].Value = rowDanhSachSanPham.Cells["MASP"].Value;
            newRow.Cells[dgvThongTinHoaDon.Columns["TENSP"].Index].Value = rowDanhSachSanPham.Cells["TENSP"].Value;
            newRow.Cells[dgvThongTinHoaDon.Columns["DONGIA"].Index].Value = rowDanhSachSanPham.Cells["DONGIA"].Value;
            newRow.Cells[dgvThongTinHoaDon.Columns["KM"].Index].Value = rowDanhSachSanPham.Cells["GIABAN"].Value;
            newRow.Cells[dgvThongTinHoaDon.Columns["SL"].Index].Value = 1;
            newRow.Cells[dgvThongTinHoaDon.Columns["THANHTIEN"].Index].Value = rowDanhSachSanPham.Cells["GIABAN"].Value;
            // Thêm các nút cộng trừ
            newRow.Cells.Add(new DataGridViewButtonCell());
            newRow.Cells[6].Value = "+";
            newRow.Cells.Add(new DataGridViewButtonCell());
            newRow.Cells[7].Value = "-";

            return newRow; // Trả về hàng mới
        }

        /// <summary>
        /// Tính số lượng tồn kho
        /// </summary>
        /// <param name="maSP"></param>
        /// <returns></returns>
        public int TinhSoLuongTonTheoMa(string maSP)
        {
            int soLuongTon = 0;
            foreach (DataGridViewRow row in dgvDanhSachSanPham.Rows)
            {
                if (maSP.Trim() == row.Cells[2].Value.ToString().Trim())
                {
                    soLuongTon += Convert.ToInt32(row.Cells[8].Value.ToString());
                }
            }
            return soLuongTon;
        }

        /// <summary>
        /// Kiểm tra Số lượng tồn kho theo mã sản phẩm
        /// </summary>
        /// <param name="maSP"></param>
        /// <returns></returns>
        public bool KiemTraLonHonTon(string maSP)
        {
            int soLuongTruocKhiThem = 0;
            int soLuongTon = TinhSoLuongTonTheoMa(maSP);

            foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
            {
                string cellMaSanPham = row.Cells[0].Value.ToString().Trim();
                if (maSP.Trim() == cellMaSanPham)
                {
                    soLuongTruocKhiThem += Convert.ToInt32(row.Cells[4].Value.ToString().Trim());
                }
            }

            if (soLuongTruocKhiThem < soLuongTon)
            {
                return true;// thông qua. số lượng trước khi thêm nhỏ hơn số lượng tồn
            }
            return false;// phát hiện sai phạm 
        }

        public void SetthanhtienVaTongSoLuong()
        {
            int tongsoluong = 0;
            double thanhtien = 0;

            foreach (DataGridViewRow row in DgvThongTinHoaDon.Rows)
            {
                tongsoluong += Convert.ToInt32(row.Cells["SL"].Value);
                thanhtien += Convert.ToDouble(row.Cells["ThanhTien"].Value);
            }
            txtSoLuongMua.Text = tongsoluong.ToString();
            if (lblthanhtien != null)
            {
                Lblthanhtien.Text = thanhtien.ToString();
                TxtSoLuongMua.Text = tongsoluong.ToString();
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
                    double soLuong = Convert.ToInt32(dgvThongTinHoaDon.Rows[e.RowIndex].Cells["SL"].Value) + 1;

                    dgvThongTinHoaDon.Rows[e.RowIndex].Cells["SL"].Value = soLuong; // gán lại số lượng

                    double khuyenMai = Convert.ToInt32(dgvThongTinHoaDon.Rows[e.RowIndex].Cells["KM"].Value);


                    //Tính toán tổng
                    double thanhtien = khuyenMai * soLuong;
                    dgvThongTinHoaDon.Rows[e.RowIndex].Cells["ThanhTien"].Value = thanhtien;
                }
                else
                {
                    MessageBox.Show($"Không đủ số lượng cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Kiểm tra xem người dùng có nhấp vào cột nút giảm số lượng hay không
            else if (e.ColumnIndex == dgvThongTinHoaDon.Columns["btnGiamSL"].Index && e.RowIndex >= 0)
            {
                double soLuong = Convert.ToInt32(dgvThongTinHoaDon.Rows[e.RowIndex].Cells["SL"].Value) - 1;

                if (soLuong <= 0)
                {
                    // Xóa dòng khỏi DataGridView
                    dgvThongTinHoaDon.Rows.RemoveAt(e.RowIndex);
                    lblthanhtien.Text = "0";
                    txtSoLuongMua.Text = "0";
                    MessageBox.Show($"Hủy thêm Sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvThongTinHoaDon.Rows[e.RowIndex].Cells["SL"].Value = soLuong; // gán lại số lượng

                double khuyenMai = Convert.ToInt32(dgvThongTinHoaDon.Rows[e.RowIndex].Cells["KM"].Value);


                //Tính toán tổng
                double thanhtien = khuyenMai * soLuong;
                dgvThongTinHoaDon.Rows[e.RowIndex].Cells["ThanhTien"].Value = thanhtien;
            }
            SetthanhtienVaTongSoLuong();
        }


        public void btnHuyThanhToan_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn hủy thanh toán và xóa tất cả các mục trong giỏ hàng không?", "Xác nhận hủy thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                // Xóa tất cả các dòng trong dgvThongTinHoaDon
                dgvThongTinHoaDon.Rows.Clear();
                txtTenKhachHang.Text = "";
                TxtSDTKhachHang.Text = "";
                lblthanhtien.Text = "0";
                txtSoLuongMua.Text = "0";
            }
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
                MessageBox.Show("Vui lòng thêm sản phẩm vào hóa đơn", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Xác nhận thanh toán", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (string.IsNullOrEmpty(txtTenKhachHang.Text) && string.IsNullOrEmpty(txtSDTKhachHang.Text))
                {
                    MessageBox.Show("Vui lòng không để trống thông tin khách hàng", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //==============================================================================
                //--..........................................................................--
                //------------------        Sự kiện in hóa đơn       ---------------------------
                //--..........................................................................--
                //==============================================================================
                KhachHang khachHang = new KhachHang();

                khachHang.Ma = rnd.GenerateRandomAlphanumericString(11);
                khachHang.Ten = txtTenKhachHang.Text;
                khachHang.Sdt = Convert.ToInt32(txtSDTKhachHang.Text);

                khachHangController.Insert(khachHang);

                Hoadon = new HoaDon(txtMaHoaDon.Text, "NV14", khachHang.Ma, DateTime.Now, Convert.ToDecimal(lblthanhtien.Text));

                hoadonController.Insert(Hoadon);
                foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
                {
                    ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(txtMaHoaDon.Text, row.Cells["MASP"].Value.ToString(), Convert.ToInt32(row.Cells["SL"].Value));
                    cthdController.Insert(chiTietHoaDon);
                }
                MessageBox.Show("Thanh toán thành công", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        //==============================================================================
        //--..........................................................................--
        //------------------           Sự kiện click btnNameThemHDCT       -------------
        //--..........................................................................--
        //==============================================================================
        public void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng có nhấp vào nút cuối cùng không                
                if (e.ColumnIndex == dgvDanhSachSanPham.Columns[btnNameThemHDCT].Index && e.RowIndex >= 0)
                {
                    // Lấy hàng hiện tại
                    DataGridViewRow rowDanhSachSanPham = dgvDanhSachSanPham.Rows[e.RowIndex];

                    // Gọi hàm MapDataRow
                    DataGridViewRow newRow = MapDataRow(rowDanhSachSanPham);

                    // Kiểm tra xem newRow có phải là null không
                    if (newRow != null)
                    {
                        // Thêm hàng mới vào dgvThongTinHoaDon
                        dgvThongTinHoaDon.Rows.Add(newRow);
                    }
                    SetthanhtienVaTongSoLuong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ChangeHeaderNameDanhThongTinHoaDon()
        {
            dgvThongTinHoaDon.Columns["MASP"].HeaderText = "Mã Sản Phẩm";
            dgvThongTinHoaDon.Columns["TENSP"].HeaderText = "Tên Sản Phẩm";
            dgvThongTinHoaDon.Columns["DONGIA"].HeaderText = "Đơn Giá";
            dgvThongTinHoaDon.Columns["KM"].HeaderText = "Khuyến Mãi";
            dgvThongTinHoaDon.Columns["SL"].HeaderText = "Số Lượng";
            dgvThongTinHoaDon.Columns["THANHTIEN"].HeaderText = "Tổng";
        }

        public void ChangeHeaderNameDanhSachSanPham()
        {
            dgvDanhSachSanPham.Columns["MASP"].HeaderText = "Mã Sản Phẩm";
            dgvDanhSachSanPham.Columns["TENSP"].HeaderText = "Tên Sản Phẩm";
            dgvDanhSachSanPham.Columns["DONVI"].HeaderText = "Đơn Vị Tính";
            dgvDanhSachSanPham.Columns["DONGIA"].HeaderText = "Giá gốc";//Đơn giá 
            dgvDanhSachSanPham.Columns["GIAMGIA"].HeaderText = "% Giảm giá";
            dgvDanhSachSanPham.Columns["GIABAN"].HeaderText = "Giá bán";// giá khuyến mãi sau giảm giá
            dgvDanhSachSanPham.Columns["SLTONKHO"].HeaderText = "SL Tồn";
        }

        public void CreateButtonClickHoaDonSanPham()
        {
            //==============================================================================
            //--..........................................................................--
            //------------------          Thêm nút cho danh sách sản phẩm      -------------
            //--..........................................................................--
            //==============================================================================
            // Lấy tổng số cột
            int totalColumns = dgvDanhSachSanPham.Columns.Count;

            // Thay đổi thứ tự cột "btnNameThemHDCT" thành vị trí cuối cùng
            dgvDanhSachSanPham.Columns["btnNameThemHDCT"].DisplayIndex = totalColumns - 1;

            // Lấy cột cuối cùng
            DataGridViewColumn lastColumn = dgvDanhSachSanPham.Columns["btnNameThemHDCT"];

            // Hiển thị tên cột cuối cùng

            btnNameThemHDCT = lastColumn.Name;

            //==============================================================================
            //--..........................................................................--
            //------------------          Thêm nút cho danh sách sản phẩm      -------------
            //--..........................................................................--
            //==============================================================================
        }
    }

}
