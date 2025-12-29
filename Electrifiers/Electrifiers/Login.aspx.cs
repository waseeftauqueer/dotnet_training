using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electrifiers
{
    public partial class Login : System.Web.UI.Page
    {
        private string adminUsername = "waseef";
        private string adminPassword = "12345";

        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username ==adminUsername && password == adminPassword)
            {
                Response.Redirect("AdminDashboard.aspx");
            }
            else
            {
                lblMessage.Text ="invalid username or password";
            }
        }
    }
}