using System;
using System.IO;
using System.Web;

namespace Exception_Project
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            Server.ClearError();

            string errorDetails =
                "Date: " + DateTime.Now + Environment.NewLine +
                "Message: " + ex.Message + Environment.NewLine +
                "Source: " + ex.Source + Environment.NewLine +
                "StackTrace: " + ex.StackTrace + Environment.NewLine +
                "----------------------------------------" + Environment.NewLine;
            string path = Server.MapPath("~/Errorfile.txt");

            File.AppendAllText(path, errorDetails);

            Server.Transfer("~/PageNotFound.aspx");
        }
    }
}
