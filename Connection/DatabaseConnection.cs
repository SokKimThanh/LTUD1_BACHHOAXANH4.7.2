using System.Data.SqlClient;
using System.Data;


public class DatabaseConnection
{
#pragma warning disable IDE0044 // Add readonly modifier
    private SqlConnection conn;
#pragma warning restore IDE0044 // Add readonly modifier

    public DatabaseConnection(string connectionString)
    {
        conn = new SqlConnection(connectionString);
    }

    public SqlConnection OpenConnection()
    {
        if (conn != null && conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        return conn!;
    }

    public void CloseConnection()
    {
        if (conn != null && conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
    }
}


