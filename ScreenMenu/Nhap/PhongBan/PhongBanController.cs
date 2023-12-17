using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.PhongBan
{
    internal class PhongBanController : MyController
    {
        public PhongBanController(string connectionString) : base(connectionString)
        {
        }

        public override void Delete(object id)
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_phongban_delete", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maPB", id);

                // Thực thi SqlCommand
                if (Sql.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                };

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
            PhongBan o = new PhongBan();
            o.MaPB = row.Field<string>("mapb");
            o.TenPB = row.Field<string>("TENPHG");
            o.MaCN = row.Field<string>("macn");
            return o;
        }

        public override void Insert(object sender)
        {
            try
            {
                PhongBan user = (PhongBan)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_phongban_insert", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maPB", user.MaPB);
                Sql.Parameters.AddWithValue("@tenPB", user.TenPB);
                Sql.Parameters.AddWithValue("@maCN", user.MaCN);
                // Thực thi SqlCommand
                if (Sql.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                };

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
                Sql = new SqlCommand("sp_phongban_select_all", conn);
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
        public void SelectMaCN()
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_cbb_chinhanh_select", conn);
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

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_phongban_select_one", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                Sql.Parameters.AddWithValue("@maPB", id);
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
            return DataSource;
        }
        public override void Update(object sender)
        {
            try
            {
                PhongBan user = (PhongBan)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();
                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_phongban_update", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maPB", user.MaPB);
                Sql.Parameters.AddWithValue("@tenPB", user.TenPB);
                Sql.Parameters.AddWithValue("@maCN", user.MaCN);
                // Thực thi SqlCommand
                if (Sql.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                };

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
