using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class AccountController : MyController
{
    public AccountController(string connectionString) : base(connectionString)
    {

    }

    public override void Delete(object id)
    {
        // Mở kết nối
        SqlConnection conn = OpenConnection();

        // Tạo một đối tượng SqlCommand
        Sql = new SqlCommand("sp_taikhoan_delete", conn);
        Sql.CommandType = CommandType.StoredProcedure;

        // Thêm tham số vào SqlCommand
        Sql.Parameters.AddWithValue("@tentk", id);
        // Thực thi SqlCommand
        Sql.ExecuteNonQuery();

        // Đóng kết nối
        CloseConnection();
    }

    public override object FromDataRow(DataRow row)
    {
        Account o = new Account();
        o.Tentk = row.Field<string>("TENTK");
        o.Matkhau = row.Field<string>("MATKHAU");
        o.Manv = row.Field<string>("MANV");
        o.Maqtc = row.Field<string>("MAQTC");
        return o;
    }

    public override void Insert(object sender)
    {
        try
        {
            Account o = (Account)sender;
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_taikhoan_insert", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@tentk", o.Tentk);
            Sql.Parameters.AddWithValue("@matkhau", o.Matkhau);
            Sql.Parameters.AddWithValue("@manv", o.Manv);
            Sql.Parameters.AddWithValue("@maqtc", o.Maqtc);
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
            // Đóng kết nối
            CloseConnection();
        }
    }

    public override void SelectAll()
    {
        try
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_taikhoan_select_all", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Tạo một đối tượng SqlDataAdapter
            Adapter = new SqlDataAdapter(Sql);

            // Tạo một đối tượng DataTable để lưu trữ dữ liệu
            DataSource = new DataTable();

            // Đổ dữ liệu vào DataTable
            Adapter.Fill(DataSource);

            // Đóng kết nối
            CloseConnection();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Đóng kết nối
            CloseConnection();
        }
    }
    public void select_cbo_quyentruycap()
    {
        try
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_cbo_quyentruycap_select_all", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Tạo một đối tượng SqlDataAdapter
            Adapter = new SqlDataAdapter(Sql);

            // Tạo một đối tượng DataTable để lưu trữ dữ liệu
            DataSource = new DataTable();

            // Đổ dữ liệu vào DataTable
            Adapter.Fill(DataSource);

            // Đóng kết nối
            CloseConnection();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Đóng kết nối
            CloseConnection();
        }
    } public void select_cnql_quyentruycap()
    {
        try
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_cnql_quyentruycap", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Tạo một đối tượng SqlDataAdapter
            Adapter = new SqlDataAdapter(Sql);

            // Tạo một đối tượng DataTable để lưu trữ dữ liệu
            DataSource = new DataTable();

            // Đổ dữ liệu vào DataTable
            Adapter.Fill(DataSource);

            // Đóng kết nối
            CloseConnection();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Đóng kết nối
            CloseConnection();
        }
    }
    public void select_cbo_nhanvien()
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

    public override DataTable SelectByID(object id)
    {
        try
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_taikhoan_select_one", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@tentk", id);

            // Tạo một đối tượng SqlDataAdapter
            Adapter = new SqlDataAdapter(Sql);

            // Tạo một đối tượng DataTable để lưu trữ dữ liệu
            DataSource = new DataTable();

            // Đổ dữ liệu vào DataTable
            Adapter.Fill(DataSource);

            // Đóng kết nối
            CloseConnection();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Đóng kết nối
            CloseConnection();
        }
        // Trả về DataTable
        return DataSource;
    }

    public override void Update(object sender)
    {
        try
        {

            try
            {
                Account o = (Account)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_taikhoan_update", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@tentk", o.Tentk);
                Sql.Parameters.AddWithValue("@matkhau", o.Matkhau);
                Sql.Parameters.AddWithValue("@manv", o.Manv);
                Sql.Parameters.AddWithValue("@maqtc", o.Maqtc);
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
                // Đóng kết nối
                CloseConnection();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Đóng kết nối
            CloseConnection();
        }
    }
}


