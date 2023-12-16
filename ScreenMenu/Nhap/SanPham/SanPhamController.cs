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
                SanPham sanpham = (SanPham)sender;
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_sanpham_insert", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@MASP", sanpham.MaSP);
                Sql.Parameters.AddWithValue("@TENSP", sanpham.TenSP);
                Sql.Parameters.AddWithValue("@DONVI", sanpham.DonVi);
                Sql.Parameters.AddWithValue("@NSX", sanpham.NgaySX);
                Sql.Parameters.AddWithValue("@HSD", sanpham.HanSD);
                Sql.Parameters.AddWithValue("@SLTONKHO", sanpham.SLTonKho);
                Sql.Parameters.AddWithValue("@Mancc", sanpham.Mancc);
                Sql.Parameters.AddWithValue("@MALOAI", sanpham.MaLoai);
                Sql.Parameters.AddWithValue("@DONGIA", sanpham.Dongia);
                Sql.Parameters.AddWithValue("@MAKM", sanpham.KhuyenMai);

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
                Sql = new SqlCommand("sp_sanpham_select_one", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                string masp = (string)id;
                masp = masp.ToString().Trim();
                Sql.Parameters.AddWithValue("@masp", masp);

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
                if (!ErrFrm.DialogConfirm("Xác nhận cập nhật mới"))
                {
                    // Mở kết nối
                    SanPham sanpham = (SanPham)sender;

                    // Mở kết nối
                    SqlConnection conn = OpenConnection();

                    // Tạo một đối tượng SqlCommand
                    Sql = new SqlCommand("sp_sanpham_update", conn);
                    Sql.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào SqlCommand
                    Sql.Parameters.AddWithValue("@MASP", sanpham.MaSP);
                    Sql.Parameters.AddWithValue("@TENSP", sanpham.TenSP);
                    Sql.Parameters.AddWithValue("@DONVI", sanpham.DonVi);
                    Sql.Parameters.AddWithValue("@NSX", sanpham.NgaySX);
                    Sql.Parameters.AddWithValue("@HSD", sanpham.HanSD);
                    Sql.Parameters.AddWithValue("@SLTONKHO", sanpham.SLTonKho);
                    Sql.Parameters.AddWithValue("@Mancc", sanpham.Mancc);
                    Sql.Parameters.AddWithValue("@MALOAI", sanpham.MaLoai);
                    Sql.Parameters.AddWithValue("@DONGIA", sanpham.Dongia);
                    Sql.Parameters.AddWithValue("@MAKM", sanpham.KhuyenMai);
                    // Thực thi SqlCommand
                    if (Sql.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                    }
                }
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
                if (!ErrFrm.DialogConfirm("Xác nhận xóa"))
                {
                    // Mở kết nối
                    SqlConnection conn = OpenConnection();

                    // Tạo một đối tượng SqlCommand
                    Sql = new SqlCommand("sp_sanpham_delete", conn);
                    Sql.CommandType = CommandType.StoredProcedure;
                    Sql.Parameters.AddWithValue("@MASP", id);
                    // Thêm tham số vào SqlCommand

                    // Thực thi SqlCommand
                    if (Sql.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                }
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
            SanPham o = new SanPham()
            {
                MaSP = row.Field<string>("masp"),
                TenSP = row.Field<string>("tensp"),
                DonVi = row.Field<string>("donvi"),
                Mancc = row.Field<string>("mancc"),
                MaLoai = row.Field<string>("maloai"),
                KhuyenMai = row.Field<string>("makm"),
                Dongia = row.Field<int>("dongia"),
                SLTonKho = row.Field<int>("sltonkho"),
                NgaySX = row.Field<DateTime>("nsx"),
                HanSD = row.Field<DateTime>("hsd"),
            };
            return o;
        }

        internal DataTable PhanTrang(int currentPage, int pageSize, string searchTerm, string loaiSanPham, string nhaCungCap)
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng DataTable để lưu trữ dữ liệu
                DataTable table = new DataTable();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_sanpham_phantrang", conn);
                Sql.CommandType = CommandType.StoredProcedure;


                // Thêm tham số vào SqlCommand
                //Sql.Parameters.Add("@searchTerm", SqlDbType.NVarChar).Value = searchTerm ?? (object)DBNull.Value;
                //Sql.Parameters.Add("@loaiSanPham", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(loaiSanPham) ? (object)DBNull.Value : loaiSanPham;
                //Sql.Parameters.Add("@nhaCungCap", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(nhaCungCap) ? (object)DBNull.Value : nhaCungCap;
                searchTerm = searchTerm ?? null;
                loaiSanPham = string.IsNullOrEmpty(nhaCungCap) ? null : nhaCungCap;
                nhaCungCap = string.IsNullOrEmpty(nhaCungCap) ? null : nhaCungCap;
                Sql.Parameters.AddWithValue("@searchTerm", searchTerm);
                Sql.Parameters.AddWithValue("@loaiSanPham", loaiSanPham);
                Sql.Parameters.AddWithValue("@nhaCungCap", nhaCungCap);

                Sql.Parameters.AddWithValue("@currPage", currentPage);
                Sql.Parameters.AddWithValue("@recodperpage", pageSize);

                // Tạo một đối tượng SqlDataAdapter
                Adapter = new SqlDataAdapter(Sql);

                // Đổ dữ liệu vào DataTable
                Adapter.Fill(table);

                // Đóng kết nối
                CloseConnection();

                // Trả về DataTable
                return table;
            }
            catch (Exception ex)
            {
                throw new Exception("PhanTrang" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public int GetRowCount()
        {
            int count = 0;
            try
            {
                SqlConnection conn = OpenConnection();
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM sanpham", conn);
                count = (int)cmd.ExecuteScalar();

                //đóng kết nối
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("GetRowCount" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
    }
}
