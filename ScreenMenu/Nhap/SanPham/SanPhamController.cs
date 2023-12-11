using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    internal class SanPhamController : MyController
    {



        public SanPhamController(string connectionString) : base(connectionString)
        {

        }



        public override void Insert(object sender)
        {

            try
            {
                ////Mở kết nối
                //SqlConnection conn = OpenConnection();

                ////================================================== 
                //// Thực hiện các thao tác trên cơ sở dữ liệu tại đây
                ////==================================================  
                //// SanPham sanpham = (SanPham)sender;
                //Sql.Connection = conn;
                //Sql.CommandText = "sp_sanpham_insert";
                //Sql.CommandType = CommandType.StoredProcedure;
                //// bind params
                //// add params
                //Sql.Parameters.AddWithValue("@ma", sanpham.Ma);
                //Sql.Parameters.AddWithValue("@ten", sanpham.Ten);
                //Sql.Parameters.AddWithValue("@gia", sanpham.Gia);
                //Sql.Parameters.AddWithValue("@soluong", sanpham.Soluong);
                //Sql.Parameters.AddWithValue("@nhacungcap", sanpham.Nhacungcap.Ma);
                //Sql.Parameters.AddWithValue("@danhmuc", sanpham.Danhmuc.Ma);
                //int result = Sql.ExecuteNonQuery();
                //// kiem tra thuc thi cau lenhsql
                //if (result == 0)
                //{
                //    throw new Exception("Thêm không thành công");
                //}

                SanPham sanpham = (SanPham)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_sanpham_insert", conn);
                Sql.CommandType = CommandType.StoredProcedure;
              
                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@MASP", sanpham.Ma);
                Sql.Parameters.AddWithValue("@TENSP", sanpham.Ten);
                Sql.Parameters.AddWithValue("@DONVI", sanpham.DonVi);
                Sql.Parameters.AddWithValue("@NSX", sanpham.NgaySX);
                Sql.Parameters.AddWithValue("@HSD", sanpham.HanSD);
                Sql.Parameters.AddWithValue("@SLTONKHO", sanpham.Soluong);
                Sql.Parameters.AddWithValue("@MANCC", sanpham.NCC);
                Sql.Parameters.AddWithValue("@MALOAI", sanpham.LoaiSP);
                Sql.Parameters.AddWithValue("@DONGIA", sanpham.Gia);
                Sql.Parameters.AddWithValue("@MAKM", sanpham.KhuyenMai);

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
                Sql = new SqlCommand("sp_sanpham_select_all", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Tạo đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Tạo một đối tượng Database để lưu trữ dữ liệu
                DataSource = new DataTable();

                // đổ dữ liệu vào DataTable
                Adapter.Fill(DataSource);

                //đóng kết nối
                //CloseConnection();
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
                Sql = new SqlCommand();
                Sql.Connection = conn;
                Sql.CommandText = "sp_sanpham_select_one";
                Sql.CommandType = CommandType.StoredProcedure;
                Sql.Parameters.AddWithValue("@MASP", id);
                Adapter = new SqlDataAdapter(Sql);
                Adapter.Fill(DataSource);
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

        public override void Update(object sender)
        {
            try
            {
                // Mở kết nối
                SanPham sanpham = (SanPham)sender;

                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_sanpham_update", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@MASP", sanpham.Ma);
                Sql.Parameters.AddWithValue("@TENSP", sanpham.Ten);
                Sql.Parameters.AddWithValue("@DONVI", sanpham.DonVi);
                Sql.Parameters.AddWithValue("@NSX", sanpham.NgaySX);
                Sql.Parameters.AddWithValue("@HSD", sanpham.HanSD);
                Sql.Parameters.AddWithValue("@SLTONKHO", sanpham.Soluong);
                Sql.Parameters.AddWithValue("@MANCC", sanpham.NCC);
                Sql.Parameters.AddWithValue("@MALOAI", sanpham.LoaiSP);
                Sql.Parameters.AddWithValue("@DONGIA", sanpham.Gia);
                Sql.Parameters.AddWithValue("@MAKM", sanpham.KhuyenMai);
                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();
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
        public override void Delete(object id)
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_sanpham_delete", conn);
                Sql.CommandType = CommandType.StoredProcedure;
                Sql.Parameters.AddWithValue("@MASP", id);
                // Thêm tham số vào SqlCommand

                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();
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

        public override object FromDataRow(DataRow row)
        {
            return new SanPham()
            {
              /*  Ma = row.Field<string>("ma"),
                Ten = row.Field<string>("ten"),
                Gia = row.Field<double>("gia"),
                Soluong = row.Field<int>("soluong"),
                Danhmuc = row.Field<DanhMuc>("danhmuc"),
                Nhacungcap = row.Field<NhaCungCap>("nhacungcap")*/
            };
        }
    }
}
