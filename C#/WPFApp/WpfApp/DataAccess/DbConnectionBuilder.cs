using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataAccess
{
    internal static class DbConnectionBuilder
    {
        public static DbConnection CreateConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
            return new SqlConnection(connectionString);
        } 

        public static DbCommand CreateCommand()
        {
            return new SqlCommand();
        }
    }
}