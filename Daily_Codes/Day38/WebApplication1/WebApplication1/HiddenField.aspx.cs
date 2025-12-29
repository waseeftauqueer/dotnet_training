using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Nothing needed here for this example
        }

        // Store data in hidden fields
        protected void BtnStore_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = txtusername.Text;
            HiddenField2.Value = txtpass.Text;

            // Clear textboxes to simulate data being saved in hidden fields
            txtusername.Text = string.Empty;
            txtpass.Text = string.Empty;

            lblmessage.Text = "Data stored in hidden fields!";
        }

        // Load data from hidden fields
        protected void BtnLoad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(HiddenField1.Value) && !string.IsNullOrEmpty(HiddenField2.Value))
            {
                lblmessage.Text = $"Your Name: {HiddenField1.Value} and Password: {HiddenField2.Value}";
            }
            else
            {
                lblmessage.Text = "No data found in hidden fields. Please store data first!";
            }
        }
    }
}