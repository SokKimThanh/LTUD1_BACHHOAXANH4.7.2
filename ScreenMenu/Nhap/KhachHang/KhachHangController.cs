using LTUD1_BACHHOAXANH472.Model;

namespace LTUD1_BACHHOAXANH472.controller
{
    public class KhachHangController : MyController
    {
        public KhachHangController(string connectionString) : base(connectionString)
        {
        }
        public override void Delete(object id)
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_khachhang_delete", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maKH", id);

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
            KhachHang o = new KhachHang();
            o.Ma = row.Field<string>("MAKH");
            o.Ten = row.Field<string>("HOTENKH");
            o.Sdt = row.Field<int>("SDTKH");
            o.Diem = row.Field<int>("DIEMTL");
            return o;
        }

        public override void Insert(object sender)
        {
            try
            {
                KhachHang user = (KhachHang)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_khachhang_insert", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maKH", user.Ma);
                Sql.Parameters.AddWithValue("@tenKH", user.Ten);
                Sql.Parameters.AddWithValue("@sdtKH", user.Sdt);
                Sql.Parameters.AddWithValue("@diemTL", user.Diem);

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
                Sql = new SqlCommand("sp_khachhang_select_all", conn);
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
                MessageBox.Show(ex.Message);
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
                Sql = new SqlCommand("sp_khachhang_select_one", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                // Thêm tham số vào SqlCommand
                string idnv = (string)id;
                idnv = idnv.ToString().Trim();
                Sql.Parameters.AddWithValue("@maKH", idnv);

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
                KhachHang user = (KhachHang)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_khachhang_update", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maKH", user.Ma);
                Sql.Parameters.AddWithValue("@tenKH", user.Ten);
                Sql.Parameters.AddWithValue("@sdtKH", user.Sdt);
                Sql.Parameters.AddWithValue("@diemTL", user.Diem);

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
