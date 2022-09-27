using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Reflection;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EngineLevelTesting.Class
{
   public static class SqlCon
    {
        public static MySqlConnection connections(string connection)
        {
            MySqlConnection conn;
            conn = new MySqlConnection();
            conn.ConnectionString = connection;
            //conn.ConnectionString = connectionString();
            try
            {
                if (conn.State == ConnectionState.Closed)
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
