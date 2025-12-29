using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Electrifiers.DAL
{
    public class DBHandler
    {
        public SqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["EBConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }
    }
}