using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electrifiers_2._0.UI
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Welcome, Admin!";
        }
        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/Login.aspx");
        }
    }
}
