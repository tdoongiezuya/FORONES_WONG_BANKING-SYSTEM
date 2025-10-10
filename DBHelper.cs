using System.Data.SqlClient;
using System.Configuration;

namespace WONG_BANKING
{
    internal class DBHelper
    {
        private static readonly string connectionString =
            ConfigurationManager.ConnectionStrings["WONG_BANKING.Properties.Settings.BankDBConnectionString"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
