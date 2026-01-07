using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_DEC_20
{
    public partial class Question1 : Page
    {
        protected void Page_Load(object sender, EventArgs e) { }
        protected void chkName(object s, ServerValidateEventArgs a)
        {
            a.IsValid = txtN.Text.Trim().ToLower() != txtF.Text.Trim().ToLower();
        }
        protected void chkAdd(object s, ServerValidateEventArgs a)
        {
            a.IsValid = a.Value.Trim().Length >= 2;
        }
        protected void chkCity(object s, ServerValidateEventArgs a)
        {
            a.IsValid = a.Value.Trim().Length >= 2;
        }

        protected void btnChk_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
                lblMsg.Text = "validation successful!";
            else
                lblMsg.Text = "";
        }

    }
}
