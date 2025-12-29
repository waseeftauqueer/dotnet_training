using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationDemo
{
    public partial class CustomForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello");
        }

        protected void CustomValidatorUsername(object source, ServerValidateEventArgs args)
        {
            if (string.IsNullOrEmpty(args.Value))
            {
                args.IsValid = false;
            }
            else
            {
                if (args.Value.Length >= 6 && !args.Value.Contains(" "))
                    args.IsValid = true;
                else
                    args.IsValid = false;
            }
        }

        protected void btnSaveClick(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblMsg.Text = "Validation successful!";
                lblMsg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMsg.Text = "Validation failed!";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}