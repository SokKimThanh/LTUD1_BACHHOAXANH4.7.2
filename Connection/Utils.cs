using System.Data.SqlClient;
using System.IO;
public class Utils
{
    public static string TenQuyenTruyCap { get; internal set; }
    private static string connectionString = "Data Source=.;Initial Catalog = BACHHOAXANH; Integrated Security = True";
    private static string uploadString = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "uploads");
    public static string ConnectionString
    {
        get { return connectionString; }
        set { connectionString = value; }
    }
    /// <summary>
    /// Thư mục chứa các report
    /// </summary>
    public static string ReportsString { get => uploadString; set => uploadString = value; }


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
