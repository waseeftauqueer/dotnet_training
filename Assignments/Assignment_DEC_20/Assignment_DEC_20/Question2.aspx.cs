using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_DEC_20
{
    public partial class Question2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }
        protected void ddlChg(object sender, EventArgs e)
        {
            string val = ddlProd.SelectedValue;

            if (val == "1") imgProd.ImageUrl = "1.jpg";
            else if (val == "2") imgProd.ImageUrl = "2.jpg";
            else if (val == "3") imgProd.ImageUrl = "3.jpg";
            else imgProd.ImageUrl = "";
        }
        protected void btnPr(object sender, EventArgs e)
        {
            string val = ddlProd.SelectedValue;

            if (val == "1") lblPrice.Text = "Price: 100";
            else if (val == "2") lblPrice.Text = "Price: 200";
            else if (val == "3") lblPrice.Text = "Price: 300";
            else lblPrice.Text = "please select a product";
        }
    }
}
