using System;
using System.Data;
using System.Data.SqlClient;

namespace LTUD1_BACHHOAXANH472
{
    internal class KhuyenMaiController : MyController
    {
        public KhuyenMaiController(string connectionString) : base(connectionString)
        {
        }



        public override void Delete(object id)
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_khuyenmai_delete", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@makm", id);

            // Thực thi SqlCommand
            Sql.ExecuteNonQuery();

            // Đóng kết nối
            CloseConnection();
        }

        public override object FromDataRow(DataRow row)
        {
            return new KhuyenMai()
            {
                Makm = row.Field<string>("makm"),
                Ngaybd = row.Field<DateTime>("ngaybd"),
                Ngaykt = row.Field<DateTime>("ngaykt")
            };
        }

        public override void Insert(object sender)
        {
            KhuyenMai o = (KhuyenMai)sender;
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_khuyenmai_insert", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@makm", o.Makm);
            Sql.Parameters.AddWithValue("@ngaybd", o.Ngaybd);
            Sql.Parameters.AddWithValue("@ngaykt", o.Ngaykt);
            Sql.Parameters.AddWithValue("@maht", o.Maht);
            // Thực thi SqlCommand
            Sql.ExecuteNonQuery();

            // Đóng kết nối
            CloseConnection();
        }
        public DataTable sp_cbo_hinhthuckm()
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_cbo_hinhthuckm", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Tạo một đối tượng SqlDataAdapter
            Adapter = new SqlDataAdapter(Sql);

            // Tạo một đối tượng DataTable để lưu trữ dữ liệu
            DataTable dt = new DataTable();

            // Đổ dữ liệu vào DataTable
            Adapter.Fill(dt);

            // Đóng kết nối
            CloseConnection();
            return dt;
        }
        public override void SelectAll()
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_khuyenmai_select_all", conn);
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

        public override DataTable SelectByID(object id)
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_khuyenmai_select_one", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@makm", id);

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

        public override void Update(object sender)
        {
            KhuyenMai o = (KhuyenMai)sender;
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_khuyenmai_update", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@makm", o.Makm);
            Sql.Parameters.AddWithValue("@ngaybd", o.Ngaybd);
            Sql.Parameters.AddWithValue("@ngaykt", o.Ngaykt);
            Sql.Parameters.AddWithValue("@maht", o.Maht);

            // Thực thi SqlCommand
            Sql.ExecuteNonQuery();

            // Đóng kết nối
            CloseConnection();
        }
    }
}
