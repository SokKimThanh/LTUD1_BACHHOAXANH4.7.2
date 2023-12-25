using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
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
            ChiTietHoaDon o = new ChiTietHoaDon();
            o.MaHD = row.Field<string>("mahd");
            o.MaSP = row.Field<string>("masp");
            o.SoLuong = row.Field<int>("soluong");
            return o;
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
                Sql.Parameters.AddWithValue("@masp", user.MaSP);
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

        }
        public DataTable SelectOne(object id)
        {
            try
            {
                ChiTietHoaDon cthd = (ChiTietHoaDon)id;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // thực hiện các thao tác trên cơ sở dữ liệu
                Sql = new SqlCommand("sp_chitiethoadon_select_one", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                Sql.Parameters.AddWithValue("@maHD", cthd.MaHD);
                Sql.Parameters.AddWithValue("@maHD", cthd.MaSP);
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
                Sql.Parameters.AddWithValue("@masp", user.MaSP);
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
