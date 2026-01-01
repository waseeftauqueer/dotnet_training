using System;
using System.Data;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exception_Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
                DataSet ds = new DataSet();

                // Check if the XML file exists
                string xmlFilePath = Server.MapPath("~/Employees.xml");
                ds.ReadXml(xmlFilePath);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            if (File.Exists(xmlFilePath))
            {

            }
            else
            {
                Label1.Text = "The requested XML file (Employees.xml) was not found on the server.";
            }
        //}
            //catch (Exception ex)
            //{
            //    // If any error occurs, show a generic error message
            //    Label1.Text = "An error occurred while loading the data. Please try again later.";

            //    // Log the detailed error for debugging (optional)
            //    // LogError(ex);  // You can implement your logging function here.
            //}
}

        // This method is called when an unhandled error occurs on the page
        //protected void Page_Error(object sender, EventArgs e)
        //{
        //    // Get the last server error
        //    Exception ex = Server.GetLastError();
        //    Server.ClearError();  // Clear the error from the server
        //    // Redirect the user to a custom error page (err.aspx)
        //    Server.Transfer("~/Err.aspx");
        //}
    }
}
