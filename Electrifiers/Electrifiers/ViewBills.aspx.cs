using Electrifiers.Models;
using Electrifiers.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electrifiers
{
    public partial class ViewBills : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnFetch_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN.Text);
            if (n > 0)
            {
                ElectricityBoard eb = new ElectricityBoard();
                List<ElectricityBill> bills = eb.N_BillDetails(n);

                GridView1.DataSource = bills;
                GridView1.DataBind();
            }
            else
            {

                Response.Write("<script>alert('please enter a valid number');</script>");
            }
        }
    }
}