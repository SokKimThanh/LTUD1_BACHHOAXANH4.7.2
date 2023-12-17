using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.HoaDon;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using LTUD1_BACHHOAXANH472.Model;
using LTUD1_BACHHOAXANH472.controller;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.BanHang
{
    public partial class FormBanHang : Form
    {
        ChiTietHoaDonController cthdController = new ChiTietHoaDonController(Utils.ConnectionString);
        HoaDonController hoadonController = new HoaDonController(Utils.ConnectionString);
        DanhMucController danhMucController = new DanhMucController(Utils.ConnectionString);
        SanPhamController sanPhamController = new SanPhamController(Utils.ConnectionString);
        KhachHangController khachHangController = new KhachHangController(Utils.ConnectionString);
        NhaCungCapController nhaCungCapController = new NhaCungCapController(Utils.ConnectionString);
        RandomStringGenerator rnd = new RandomStringGenerator();
        private PictureBox currentPictureBox;



        public FormBanHang()
        {
            InitializeComponent();
            // Vô hiệu hóa sự kiện CellValueChanged

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
            nhaCungCapController.SelectAll();
            cboNhaCungCap.DataSource = nhaCungCapController.DataSource;
            cboNhaCungCap.ValueMember = "MANCC";
            cboNhaCungCap.DisplayMember = "TENNCC";
        }

        private void GetData()
        {
            try
            {
               
            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
            }
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

            DataGridViewHelper.TaoCotAddToCast(dgvDanhSachSanPham);
            DataGridViewHelper.ChangeHeaderNameDanhSachSanPham(dgvDanhSachSanPham);
            DataGridViewHelper.ConfigureDataGridView(dgvDanhSachSanPham);

            //format theo nhu cầu :) 
            dgvThongTinHoaDon.ScrollBars = ScrollBars.Both;
            dgvThongTinHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDanhSachSanPham.ScrollBars = ScrollBars.Both;
            dgvDanhSachSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblTongTien.Text = "0";
            txtSoLuongMua.Text = "0";

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
            // Lấy giá trị của hàng được nhấp vào
            if (e.ColumnIndex == dgvDanhSachSanPham.Columns["btnAddToCast"].Index && e.RowIndex >= 0)
            {
                //Lấy dữ liệu dòng đó ra
                DataGridViewRow selectedRow = dgvDanhSachSanPham.Rows[e.RowIndex];

                //Thêm vào dgvThongTinHoaDon
                dgvThongTinHoaDon.Rows.Add(MapDataRow(selectedRow));

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

        private void lblTieuDeHoaDon_Click(object sender, EventArgs e)
        {

        }


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
            row.Cells[3].Value = TinhToanKhuyenMai(rowDanhSachSanPham.Cells[5].Value.ToString());
            row.Cells[4].Value = 0;
            row.Cells[5].Value = 0;

            row.Cells.Add(new DataGridViewButtonCell());
            row.Cells[6].Value = "+";
            row.Cells.Add(new DataGridViewButtonCell());
            row.Cells[7].Value = "-";
            return row;
        }

        private double TinhToanKhuyenMai(string maKM)
        {
            switch (maKM.Trim())
            {
                case "KM01":
                    return 10;
                case "KM02":
                    return 20;
                case "KM03":
                    return 30;
                default:
                    return 1;
            }

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
            double sum = 0;
            int tongSoluong = 0;
            foreach (DataGridViewRow row in dgvThongTinHoaDon.Rows)
            {
                tongSoluong += Convert.ToInt32(row.Cells[4].Value);
                sum += Convert.ToDouble(row.Cells[5].Value);
            }
            txtSoLuongMua.Text = tongSoluong.ToString();
            lblTongTien.Text = sum.ToString();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
          
        }

        private void lblTongSoTrang_Click(object sender, EventArgs e)
        {

        }
    }
    class HoaDon
    {
        private string maHD, maNV, maKH;
        private DateTime ngayHD;
        private decimal tongTien;
        public HoaDon()
        { }
        public HoaDon(string maHD, string maNV, string maKH, DateTime ngayHD, decimal tongTien)
        {
            this.MaHD = maHD;
            this.MaNV = maNV;
            this.MaKH = maKH;
            this.NgayHD = ngayHD;
            this.TongTien = tongTien;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayHD { get => ngayHD; set => ngayHD = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
    }
    internal class ChiTietHoaDon
    {
        private string maHD, maSP;
        private int soLuong;

        public ChiTietHoaDon() { }
        public ChiTietHoaDon(string maHD, string maSP, int soLuong)
        {
            this.MaHD = maHD;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
    public class HoaDonController : MyController
    {
        public HoaDonController(string connectionString) : base(connectionString)
        {
        }

        public override void Delete(object id)
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_hoadon_delete", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maHD", id);

                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public override object FromDataRow(DataRow row)
        {
            HoaDon o = new HoaDon();
            o.MaHD = row.Field<string>("mahd");
            o.NgayHD = row.Field<DateTime>("ngayhoadon");
            o.TongTien = row.Field<decimal>("tongthanhtien");
            /*  o.TongTien = 0;*/
            o.MaNV = row.Field<string>("manv");
            o.MaKH = row.Field<string>("makh");
            return o;
        }

        public override void Insert(object sender)
        {

            try
            {
                HoaDon user = (HoaDon)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_hoadon_insert", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maHD", user.MaHD);
                Sql.Parameters.AddWithValue("@ngayHD", user.NgayHD);
                Sql.Parameters.AddWithValue("@tongTien", user.TongTien);
                Sql.Parameters.AddWithValue("@maNV", user.MaNV);
                Sql.Parameters.AddWithValue("@maKH", user.MaKH);
                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public override void SelectAll()
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_hoadon_select_all", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Tạo đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng Database để lưu trữ dữ liệu
                DataSource = new DataTable();

                // đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                //đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void SelectAllNhanVien()
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_nhanvien_select_all", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Tạo đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng Database để lưu trữ dữ liệu
                DataSource = new DataTable();

                // đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);
                //đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void SelectAllKhachHang()
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_cbb_khachhang_select_all", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Tạo đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng Database để lưu trữ dữ liệu
                DataSource = new DataTable();

                // đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);
                //đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public override DataTable SelectByID(object id)
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_hoadon_select_one", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                // Thêm tham số vào SqlCommand
                string idnv = (string)id;
                idnv = idnv.ToString().Trim();
                Sql.Parameters.AddWithValue("@maHD", idnv);

                // Tạo một đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng DataTable để lưu trữ dữ liệu
                DataSource = new DataTable();

                // Đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                // Đóng kết nối
                CloseConnection();

                // Trả về DataTable
                return DataSource;
            }
            catch (Exception ex)
            {
                throw new Exception("SelectByID" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public override void Update(object sender)
        {
            try
            {
                HoaDon user = (HoaDon)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_hoadon_update", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maHD", user.MaHD);
                Sql.Parameters.AddWithValue("@ngayHD", user.NgayHD);
                Sql.Parameters.AddWithValue("@tongTien", user.TongTien);
                Sql.Parameters.AddWithValue("@maNV", user.MaNV);
                Sql.Parameters.AddWithValue("@maKH", user.MaKH);
                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
    internal class ChiTietHoaDonController : MyController
    {
        public ChiTietHoaDonController(string connectionString) : base(connectionString)
        {
        }

        public override void Delete(object sender)
        {
            ChiTietHoaDon user = (ChiTietHoaDon)sender;
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_chitiethoadon_delete", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maHD", user.MaHD);
                Sql.Parameters.AddWithValue("@masp", user.MaSP);

                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public string TongTien(object id)
        {
            string TT = "";
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_chitiethoadon_tongtien", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@mahd", id);


                using (SqlDataReader reader = Sql.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Assuming YourColumnName is a string column; adjust accordingly
                        int value = reader.GetInt32(0);
                        //MessageBox.Show(value.ToString());
                        TT = value.ToString() + "\tVND";
                        // MessageBox.Show(TT);
                    }
                    else
                    {
                        TT = "No data found.";
                    }
                }
                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return TT;
        }
        public int KTTonKho(object id, int sl)
        {
            int SL = 0;
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_chitiethoadon_Kiemtratonkho", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@makm", id);
                Sql.Parameters.AddWithValue("@slmua", sl);


                using (SqlDataReader reader = Sql.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Assuming YourColumnName is a string column; adjust accordingly
                        int value = reader.GetInt32(0);
                        //MessageBox.Show(value.ToString());
                        if (value > 0)
                        {
                            MessageBox.Show("Sản phẩm tồn kho còn lại: " + value.ToString());

                        }
                        else
                        {
                            MessageBox.Show("Hết hàng");
                        }
                        // MessageBox.Show(TT);
                        SL = value;
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                    }
                }
                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return SL;

        }
        public override object FromDataRow(DataRow row)
        {
            throw new NotImplementedException();
        }

        public override void Insert(object sender)
        {
            ChiTietHoaDon user = (ChiTietHoaDon)sender;
            // if (KTMASP(user.MaSP) == true)
            //  {

            try
            {

                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_chitiethoadon_insert", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@mahd", user.MaHD);
                Sql.Parameters.AddWithValue("masp", user.MaSP);
                Sql.Parameters.AddWithValue("@sl", user.SoLuong);
                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            // }

        }

        public override void SelectAll()
        {
            try
            {/*
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_chitiethoadon_select_one", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                Sql.Parameters.AddWithValue("@maHD", user.MaHD);
                // Tạo đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng Database để lưu trữ dữ liệu
                DataSource = new DataTable();

                // đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                //đóng kết nối
                CloseConnection();*/
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public override DataTable SelectByID(object id)
        {

            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_chitiethoadon_select_all", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                Sql.Parameters.AddWithValue("@mahd", id);
                // Tạo đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng Database để lưu trữ dữ liệu
                DataSource = new DataTable();

                // đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                //đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return DataSource;
        }
        public bool KTMASP(object id)
        {

            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_chitiethoadon_TimMaSP", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                Sql.Parameters.AddWithValue("@masp", id);
                using (SqlDataReader reader = Sql.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Assuming YourColumnName is a string column; adjust accordingly
                        string value = reader.GetString(0);
                        MessageBox.Show(value.ToString());
                        if (value.ToString() == id.ToString())
                        {
                            return false;
                        }

                    }
                    else
                    {
                        return true;

                    }
                }

                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }

        public override void Update(object sender)
        {
            try
            {
                ChiTietHoaDon user = (ChiTietHoaDon)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_hinhthuckm_update", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maHD", user.MaHD);
                Sql.Parameters.AddWithValue("masp", user.MaSP);
                Sql.Parameters.AddWithValue("@SL", user.SoLuong);
                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();

                // Đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
