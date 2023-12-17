namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.HoaDon
{
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
}
