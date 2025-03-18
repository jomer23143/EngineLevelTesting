using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EngineLevelTesting.Utilities;
using MySqlConnector;
//using MySql.Data.MySqlClient;

namespace EngineLevelTesting
{
    public static class Connection
    {
        public static MySqlDatasupport GetOTMSConnection
        {
            get
            {
                return new MySqlDatasupport(GetConnectionstring("ENGINELEVELTESTING"));
            }
        }


        public static string GetConnectionStringReg
        { 
            get 
            {
                return GetConnectionstring("ENGINELEVELTESTING");
            }
        }  

        public static string GetConnectionstring(string connName)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            //SqlConnectionStringBuilder builder1 = new SqlConnectionStringBuilder();
            Utils.DBConnection.TryGetValue(connName, out Dictionary<string, string> conn);
            if (conn != null)
            {
                //builder.Add("DRIVER", "{MySQL JDBC 10.11.6 Driver}");
                builder.Server = conn["SERVER"];
                builder.Database = conn["DBNAME"];
                builder.UserID = conn["USERNAME"];
                builder.Password = conn["PASSWORD"];
                builder.Add("Port",3306);
                builder.Add("Convert Zero Datetime", true);
            }
            return builder.ConnectionString;
        }
    }
}