using System.Data.SqlClient;
public class Utils
{
    private static string connectionString = "Data Source=.;Initial Catalog = BACHHOAXANH; Integrated Security = True";
    private static string uploadString = @"upload";
    public static string ConnectionString
    {
        get { return connectionString; }
        set { connectionString = value; }
    }

    public static string UploadString { get => uploadString; set => uploadString = value; }

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
