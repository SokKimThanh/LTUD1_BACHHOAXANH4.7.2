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
        Sql.Parameters.AddWithValue("@matk", id);

        // Thực thi SqlCommand
        Sql.ExecuteNonQuery();

        // Đóng kết nối
        CloseConnection();
    }

    public override object FromDataRow(DataRow row)
    {
        return new Account()
        {
            MaTaiKhoan = row.Field<string>("matk"),
            TenTaiKhoan = row.Field<string>("tentk"),
            MatKhau = row.Field<string>("matkhau"),
            CreatedDate = row.Field<DateTime>("createdate"),
            Phone = row.Field<string>("phone"),
            Cccd = row.Field<string>("cccd"),
            Email = row.Field<string>("email")
        };
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
            Sql.Parameters.AddWithValue("@matk", o.MaTaiKhoan);
            Sql.Parameters.AddWithValue("@tentk", o.TenTaiKhoan);
            Sql.Parameters.AddWithValue("@matkhau", o.MatKhau);
            Sql.Parameters.AddWithValue("@createdate", o.CreatedDate);
            Sql.Parameters.AddWithValue("@phone", o.Phone);
            Sql.Parameters.AddWithValue("@cccd", o.Cccd);
            Sql.Parameters.AddWithValue("@email", o.Email);

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
            Sql.Parameters.AddWithValue("@matk", id);

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
            Account o = (Account)sender;
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_taikhoan_update", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@MATK", o.MaTaiKhoan);
            Sql.Parameters.AddWithValue("@TENTK", o.TenTaiKhoan);
            Sql.Parameters.AddWithValue("@MATKHAU", o.MatKhau);
            Sql.Parameters.AddWithValue("@PHONE", o.Phone);
            Sql.Parameters.AddWithValue("@CCCD", o.Cccd);
            Sql.Parameters.AddWithValue("@EMAIL", o.Email);

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
}


