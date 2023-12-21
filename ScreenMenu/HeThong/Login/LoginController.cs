using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_BACHHOAXANH472
{
    internal class LoginController
    {
        /// <summary>
        /// Cấp quyền sau khi đăng nhập thành công
        /// </summary>
        /// <param name="tentk"></param>
        /// <param name="matkhau"></param>
        /// <returns></returns>
        public string CapQuyen(string tentk, string matkhau)
        {
            string quyen = null;

            using (SqlConnection conn = new SqlConnection(Utils.ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("sp_CapQuyen", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@TENTK", SqlDbType.Char, 30).Value = tentk;
                    cmd.Parameters.Add("@MATKHAU", SqlDbType.Char, 30).Value = matkhau;
                    cmd.Parameters.Add("@QUYEN", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    quyen = (string)cmd.Parameters["@QUYEN"].Value;
                }
            }

            return quyen;
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

            return ketqua;
        }

    }
}
