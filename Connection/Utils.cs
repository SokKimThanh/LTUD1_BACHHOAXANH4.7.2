using LTUD1_BACHHOAXANH472;
using System.Data.SqlClient;
using System.IO;
public class Utils
{
    /// <summary>
    /// Chuỗi kết nối database 
    /// </summary>
    private static string connectionString = "Data Source=.;Initial Catalog = BACHHOAXANH; Integrated Security = True";
    /// <summary>
    /// Đường dẫn thư mục báo cáo rpt
    /// </summary>
    private static string uploadString = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "uploads");

    /// <summary>
    /// Đường dẫn thư mục báo cáo rpt
    /// </summary>
    public static string ConnectionString { get { return connectionString; } set { connectionString = value; } }

    /// <summary>
    /// Thư mục chứa các report
    /// </summary>
    public static string ReportsString { get => uploadString; set => uploadString = value; }

    /// <summary>
    /// Nhân viên lập báo cáo
    /// </summary>
    public static NhanVien NhanVienLapBaoCao { get; internal set; }

    /// <summary>
    /// Quyền truy cập của nhân viên đăng nhập
    /// </summary>
    public static QuyenTruyCap QuyenTruyCapNhanVien { get; internal set; }


    private static bool IsServerConnected(string connectionString)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
