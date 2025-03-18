using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MySqlConnector;

namespace EngineLevelTesting.Class
{
   public static class SqlCon
    {
        public static MySqlConnection connections(string connection)
        {
            MySqlConnection conn;
            //string connnn = @"Server=194.163.32.81;Port=3306;Database=u867954426_board;UID=u867954426_board;Pwd=System@2023; Ssl Mode=Required; convert zero datetime=True;";
            //string connnn1 = @"Server=194.163.32.81;Database=u867954426_board; user=u867954426_board; Pwd=System@2023;";

            //string connnn1 = @"Server=151.106.122.3;Database=u867954426_sample2314; user=u867954426_sample; Pwd=Access1234@;";
            conn = new MySqlConnection(connection);
            //conn.ConnectionString = connection;
            //conn.ConnectionString = connectionString();.
            //Convert.ToInt32(conn);
            try
            {
                //if (conn.State == ConnectionState.Closed)
                conn.Open();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conn;
        }
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return System.IO.Path.GetDirectoryName(path);
            }

        }
        public static string connectionString(int con)
        {
            //string txtpath = $@"D:\TMSMonitoring\TMSMonitoring\bin\Debug\connection\connectionString.txt";
            string txtpath = "";
            string connection = "";
            if (con == 1)
                txtpath = $@"{AssemblyDirectory}\connection\connectionString.txt";
            else
                txtpath = $@"{AssemblyDirectory}\connection\Cloud.txt";
            try
            {
                if (File.Exists(txtpath))
                {
                    using (StreamReader sr = new StreamReader(txtpath))
                    {
                        connection = sr.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
            return connection;
        }
    }
}
