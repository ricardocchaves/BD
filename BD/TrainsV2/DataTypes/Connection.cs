using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsV2.DataTypes
{
    class Connection
    {
        private static SqlConnection cn;
        public Connection()
        {

        }

        private static SqlConnection getSGBDConnection(String connectionString="")
        {
            if (connectionString.Length == 0)
                connectionString = "Data Source=tcp:193.136.175.33\\SQLSERVER2012,8293;" +
                "Initial Catalog=P3G2;" +
                "User ID=p3g2;" +
                "Password=pousaegay;" +
                "connect timeout = 3";
            else if(connectionString.Equals("local"))
            {
                connectionString = "Server=localhost;Trusted_Connection=true;Database=p3g2;connect timeout = 3";
            }
            return new SqlConnection(connectionString);
        }

        public static bool verifySGBDConnection(String s = "")
        {
            if (cn == null || s.Length>0)
                cn = getSGBDConnection(s);

            if (cn.State != System.Data.ConnectionState.Open)
                cn.Open();

            return cn.State == System.Data.ConnectionState.Open;
        }

        public static SqlConnection get()
        {
            if (cn == null)
            {
                return getSGBDConnection();
            }
            else
            {
                return cn;
            }
        }

        public static void close()
        {
            if (cn != null && cn.State == System.Data.ConnectionState.Open)
                cn.Close();
        }
    }
}
