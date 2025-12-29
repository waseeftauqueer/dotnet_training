using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electrifiers
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAddBill_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBill.aspx");
        }

        protected void btnViewBills_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBills.aspx");
        }
    }
}