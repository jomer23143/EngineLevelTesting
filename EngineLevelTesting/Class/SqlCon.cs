using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Reflection;

namespace EngineLevelTesting.Class
{
   public static class SqlCon
    {
        public static SqlConnection connections()
        {
            SqlConnection conn;
            conn = new SqlConnection();
            conn.ConnectionString = "Data source=194.163.40.175;initial catalog=icehrm; uid=root;pwd=";
            //conn.ConnectionString = connectionString();
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
