using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.DiaDiem
{
    internal class DiaDiemController : MyController
    {
        public DiaDiemController(string connectionString) : base(connectionString)
        {
        }

        public override void Delete(object id)
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_diadiem_delete", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maCN", id);

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
            throw new NotImplementedException();
        }

        public override void Insert(object sender)
        {
            try
            {
                DiaDiem user = (DiaDiem)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_diadiem_insert", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maCN", user.MaCN);
                Sql.Parameters.AddWithValue("@tenCN", user.TenCN);
                Sql.Parameters.AddWithValue("@diaChi", user.DiaChi);
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
                Sql = new SqlCommand("sp_diadiem_select_all", conn);
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
            throw new NotImplementedException();
        }
        public DataTable SelectPhongBanByMaCN(object id)
        {
            // Tạo một đối tượng Database để lưu trữ dữ liệu
            DataTable dt = new DataTable(); 
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_cbo_laydanhsach_phongban_theo_chinhanh", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                Sql.Parameters.AddWithValue("@MACN", id.ToString());

                // Tạo đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql); 

                // đổ dữ liệu vào DataTable
                Adapter.Fill(dt);

                //đóng kết nối
                CloseConnection();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
        public override void Update(object sender)
        {
            try
            {
                DiaDiem user = (DiaDiem)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_diadiem_update", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@maCN", user.MaCN);
                Sql.Parameters.AddWithValue("@tenCN", user.TenCN);
                Sql.Parameters.AddWithValue("@diaChi", user.DiaChi);
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
