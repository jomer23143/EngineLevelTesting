using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EngineLevelTesting.Utilities;

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

        //public static DataSupport GetWMSConnection
        //{
        //    get
        //    {
        //        return new DataSupport(GetConnectionstring("WMS"));
        //    }
        //}

        //public static string GetWMSConnectionString { get; } = GetConnectionstring("WMS");

        public static string GetConnectionStringReg { get; } = GetConnectionstring("ENGINELEVELTESTING");

        public static string GetConnectionstring(string connName)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            Utils.DBConnection.TryGetValue(connName, out Dictionary<string, string> conn);
            if (conn != null)
            {
                builder.InitialCatalog = conn["DBNAME"];
                builder.DataSource = conn["SERVER"];
                builder.UserID = conn["USERNAME"];
                builder.Password = conn["PASSWORD"];
            }
            return builder.ConnectionString;
        }
    }
}