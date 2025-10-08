using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace WONG_BANKING
{
    internal class DBHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["WONG_BANKING.Properties.Settings.BankDBConnectionString"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
