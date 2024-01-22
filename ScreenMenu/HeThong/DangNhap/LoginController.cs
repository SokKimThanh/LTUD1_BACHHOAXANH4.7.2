using System;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel.Channels;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    internal class LoginController
    {
        // cài đặt quyền truy cập và xác minh nhân viên lập báo cáo
        NhanVienController nvController = new NhanVienController(Utils.ConnectionString);
        QuyenTruyCapController qtcController = new QuyenTruyCapController(Utils.ConnectionString);
        /// <summary>
        /// Cấp quyền sau khi đăng nhập thành công
        /// </summary>
        /// <param name="tentk">Nhập tên tài khoản</param>
        /// <param name="matkhau">Nhập mật khẩu</param>
        /// <returns></returns>
        public void CapQuyen(string tentk, string matkhau)
        {
            using (SqlConnection conn = new SqlConnection(Utils.ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("sp_CapQuyen", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@TENTK", SqlDbType.Char, 30).Value = tentk;
                    cmd.Parameters.Add("@MATKHAU", SqlDbType.Char, 30).Value = matkhau;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string maquyentruycap = reader.GetString(0);
                            string manvLapBaoCao = reader.GetString(1);

                            if (!string.IsNullOrEmpty(maquyentruycap) && !string.IsNullOrEmpty(manvLapBaoCao))
                            {
                                DataTable dtQTC = qtcController.SelectByID(maquyentruycap);
                                DataTable dtNV = nvController.SelectByID(manvLapBaoCao);
                                // khởi tạo đối tượng bằng mã

                                if (dtQTC.Rows.Count > 0 && dtNV.Rows.Count > 0)
                                {
                                    // QuyenTruyCapCap
                                    DataRow drQTC = dtQTC.Rows[0];
                                    QuyenTruyCap quyentruycap = (QuyenTruyCap)qtcController.FromDataRow(drQTC);
                                    Utils.QuyenTruyCapNhanVien = quyentruycap;//Xác minh Quyền truy cập hệ thống

                                    // NhanVien
                                    DataRow drNV = dtNV.Rows[0];
                                    NhanVien nhanvien = (NhanVien)nvController.FromDataRow(drNV);
                                    Utils.NhanVienLapBaoCao = nhanvien;// Xác minh nhân viên truy cập hệ thống

                                }
                                else
                                {

                                    throw new Exception("CapQuyen: Không tìm thấy dữ liệu nào!");
                                }
                            }

                        }
                    }
                }
            }
        }
        /// <summary>
        /// Lưu lại kết quả đăng nhập
        /// </summary>
        /// <param name="tentk"></param>
        /// <param name="matkhau"></param>
        /// <returns></returns>
        public int DangNhap(string tentk, string matkhau)
        {
            int ketqua = 0;// gia su chưa đăng nhập thành công
            try
            {
                using (SqlConnection conn = new SqlConnection(Utils.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_DangNhap", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@TENTK", SqlDbType.Char, 30).Value = tentk;
                        cmd.Parameters.Add("@MATKHAU", SqlDbType.Char, 30).Value = matkhau;
                        cmd.Parameters.Add("@KETQUA", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        //-- đăng nhập vào thành công thì trả về 1
                        //--đăng nhập vào thất bại thì trả về 0
                        ketqua = Convert.ToInt32(cmd.Parameters["@KETQUA"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ketqua;
        }

    }
}
