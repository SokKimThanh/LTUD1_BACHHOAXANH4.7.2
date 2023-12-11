using System;
using System.Data.SqlClient;
using System.Linq;


public class Utils
{
    private static string connectionString = "Data Source=localhost;Initial Catalog=BACHHOAXANH; Integrated Security=true";
    public static string ConnectionString
    {
        get { return connectionString; }
        set { connectionString = value; }
    }
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
    public static string GenerateRandomAlphanumericString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

}
