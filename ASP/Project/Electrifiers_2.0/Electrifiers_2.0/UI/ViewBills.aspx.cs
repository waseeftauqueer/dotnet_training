using System;
using System.Collections.Generic;
using Electrifiers_2._0.BLL;
using Electrifiers_2._0.Models;

namespace Electrifiers_2._0.UI
{
    public partial class ViewBills : System.Web.UI.Page
    {
        private ElectricityBoard ebLogic = new ElectricityBoard();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtYear.Text = DateTime.Now.Year.ToString();
            }
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            try
            {
                // Gather filter inputs
                string consumerNumber = txtConsumerNumber.Text.Trim();
                int? month = string.IsNullOrEmpty(ddlMonth.SelectedValue) ? (int?)null : int.Parse(ddlMonth.SelectedValue);
                int? year = string.IsNullOrEmpty(txtYear.Text.Trim()) ? (int?)null : int.Parse(txtYear.Text.Trim());
                double? minAmount = string.IsNullOrEmpty(txtMinAmount.Text.Trim()) ? (double?)null : double.Parse(txtMinAmount.Text.Trim());
                double? maxAmount = string.IsNullOrEmpty(txtMaxAmount.Text.Trim()) ? (double?)null : double.Parse(txtMaxAmount.Text.Trim());
                DateTime? startDate = string.IsNullOrEmpty(txtStartDate.Text.Trim()) ? (DateTime?)null : DateTime.Parse(txtStartDate.Text.Trim());
                DateTime? endDate = string.IsNullOrEmpty(txtEndDate.Text.Trim()) ? (DateTime?)null : DateTime.Parse(txtEndDate.Text.Trim());
                int lastN = string.IsNullOrEmpty(txtLastN.Text.Trim()) ? 0 : int.Parse(txtLastN.Text.Trim());

                // Fetch the filtered bills
                List<ElectricityBill> bills = ebLogic.GetBills(lastN, consumerNumber, month, year, minAmount, maxAmount, startDate, endDate);

                // Display result
                if (bills.Count == 0)
                {
                    lblMsg.Text = "No records found!";
                    gvBills.DataSource = null;
                    gvBills.DataBind();
                    return;
                }

                // Bind the bills to the grid
                gvBills.DataSource = bills;
                gvBills.DataBind();
            }
            catch (FormatException fex)
            {
                lblMsg.Text = "Invalid input format: " + fex.Message;
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;
            }
        }
    }
}
