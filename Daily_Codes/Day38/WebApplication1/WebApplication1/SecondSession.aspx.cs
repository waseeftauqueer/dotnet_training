using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SecondSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGetSession_Click(object sender, EventArgs e)
        {
            lblname.Text = Session["name"].ToString();
            lblregion.Text = Session["region"].ToString();
        }

        protected void BtnThird_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThirdSession.aspx");

        }
    }
}