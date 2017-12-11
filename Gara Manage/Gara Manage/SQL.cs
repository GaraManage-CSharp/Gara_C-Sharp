using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gara_Manage
{
    class SQL
    {
        private static SqlConnection conn;
        public static SqlConnection Connection
        {
            get
            {
                if (conn != null)
                {
                    return conn;
                }
                conn = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=GARAOTO;Persist Security Info=True;User ID=sa;Password=1");
                conn.Open();
                return conn;
            }
        }
        public static void closeConnection()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
    }
}
