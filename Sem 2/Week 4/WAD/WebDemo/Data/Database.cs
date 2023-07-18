using System.Data.SqlClient;

namespace WebDemo.Data
{
    public class Database
    {
        private static readonly string connectionString = "Server=(local);Database=Employees;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
