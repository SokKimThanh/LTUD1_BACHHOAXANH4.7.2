using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.NhaCungCapCT
{
    internal class ChiTietNCCController : MyController
    {
        public ChiTietNCCController(string connectionString) : base(connectionString)
        {
        }

        public override void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public override object FromDataRow(DataRow row)
        {
            NhaCCCT o = new NhaCCCT();
            o.MaNCC = row.Field<string>("MANCC");
            o.MaSP = row.Field<string>("MASP");
            o.SoLuong = 0;
            return o;
        }

        public override void Insert(object sender)
        {
            try
            {
                NhaCCCT o = (NhaCCCT)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_chitietcc_insert", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@MANCC", o.MaNCC);
                Sql.Parameters.AddWithValue("@SLCUNGCCAP", o.SoLuong);
                Sql.Parameters.AddWithValue("@MASP", o.MaSP);

                // Thực thi SqlCommand
                if (Sql.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công!");
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
        }

        public override void SelectAll()
        {
            try
            {
                SqlConnection con = OpenConnection();

                Sql = new SqlCommand("sp_chitietcc_select_all", con);
                Sql.CommandType = CommandType.StoredProcedure; ;

                Adapter = new SqlDataAdapter(Sql);

                DataSource = new DataTable();

                Adapter.Fill(DataSource);

                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override DataTable SelectByID(object id)
        {

            try
            {
                NhaCCCT o = (NhaCCCT)id;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_chitietcc_select_one", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@MANCC", o.MaNCC);
                Sql.Parameters.AddWithValue("@MASP", o.MaSP);

                // Thực thi SqlCommand
                Adapter = new SqlDataAdapter(Sql);

                DataSource = new DataTable();

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
                CloseConnection();
            }
            return DataSource;
        }


        public override void Update(object sender)
        {
            try
            {
                NhaCCCT o = (NhaCCCT)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_chitietcc_update", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@MANCC", o.MaNCC);
                Sql.Parameters.AddWithValue("@SLCUNGCCAP", o.SoLuong);
                Sql.Parameters.AddWithValue("@MASP", o.MaSP);

                // Thực thi SqlCommand
                if (Sql.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công!");
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
        }
    }
}
