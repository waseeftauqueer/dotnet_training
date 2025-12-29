using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class DataForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = null;
            sqlConnection = new SqlConnection("Integrated security=true;database=PracticeDB;server=(localdb)\\MSSQLLocalDB");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select * from Employees", sqlConnection);
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
        }
    }
}