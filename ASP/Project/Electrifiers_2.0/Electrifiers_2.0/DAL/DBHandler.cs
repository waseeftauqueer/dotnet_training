using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Electrifiers_2._0.DAL
{
    public class DBHandler
    {
        public SqlConnection GetConnection()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["EBConnection"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Database connection error: " + ex.Message);
            }
        }
    }
}