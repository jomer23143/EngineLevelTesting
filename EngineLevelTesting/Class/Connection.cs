using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace EngineLevelTesting.Class
{
   public class Connection
    {
        public MySqlConnection connections()
        {
            MySqlConnection conn;
            conn = new MySqlConnection();
            //conn.ConnectionString = "Server=194.163.40.175;Port=3306;DATABASE=Btcp_icehrm; UID=Btcp_admin;PASSWORD=System2022";
            //conn.ConnectionString = "Server=127.0.0.1;Port=3306;DATABASE=icehrm; UID=root;PASSWORD=System2022";
            conn.ConnectionString = SqlCon.connectionString(1);
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                Console.WriteLine("Success");
            }
                catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return conn;
        }
    }
}
