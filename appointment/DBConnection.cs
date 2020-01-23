using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace appointment
{
    class DBConnection
    {
        private static SqlConnection conn = null;

        public static SqlConnection getConnection()
        {
            string connectionString = @"Data Source=DESKTOP-6KRJG0D\SQLEXPRESS;Initial Catalog=app_sdc;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
