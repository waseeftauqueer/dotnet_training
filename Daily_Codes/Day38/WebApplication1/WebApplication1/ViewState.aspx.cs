using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Nothing needed on page load for this example
        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            // Store username and password in ViewState
            ViewState["uname"] = txtusername.Text;
            ViewState["pass"] = txtpass.Text;

            // Clear textboxes to simulate loss of data
            txtusername.Text = "";
            txtpass.Text = "";

            lblmessage.Text = "Data stored in ViewState successfully!";
        }

        protected void BtnLoad_Click(object sender, EventArgs e)
        {
            if (ViewState["uname"] != null && ViewState["pass"] != null)
            {
                string uname = ViewState["uname"].ToString();
                string pass = ViewState["pass"].ToString();

                lblmessage.Text = $"Your Name: {uname} and your Password: {pass}";
            }
            else
            {
                lblmessage.Text = "No data found in ViewState. Please store data first!";
            }
            Response.Redirect("TestForm.aspx");
        }
    }
}