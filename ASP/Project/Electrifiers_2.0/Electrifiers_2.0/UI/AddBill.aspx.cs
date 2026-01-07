using System;
using Electrifiers_2._0.BLL;
using Electrifiers_2._0.Models;

namespace Electrifiers_2._0.UI
{
    public partial class AddBill : System.Web.UI.Page
    {
        private ElectricityBoard ebLogic = new ElectricityBoard();
        private BillValidator validator = new BillValidator();

        protected void Page_Load(object sender, EventArgs e)
        { 

            if (!IsPostBack)
            {
                txtYear.Text = DateTime.Now.Year.ToString();
            }
        }

        protected void btnAddBill_Click(object sender, EventArgs e)
        {
            lblMsg.ForeColor = System.Drawing.Color.Red;
            lblMsg.Text = "";

            try
            {
                // Gather input
                string consumerNumber = txtConsumerNumber.Text.Trim();
                string consumerName = txtConsumerName.Text.Trim();
                string unitsText = txtUnits.Text.Trim();
                int month = int.Parse(ddlMonth.SelectedValue);
                int year = int.Parse(txtYear.Text.Trim());

                if (string.IsNullOrEmpty(consumerNumber) || string.IsNullOrEmpty(consumerName) || string.IsNullOrEmpty(unitsText))
                {
                    lblMsg.Text = "Please fill all fields!";
                    return;
                }

                if (!int.TryParse(unitsText, out int units))
                {
                    lblMsg.Text = "Units must be a number!";
                    return;
                }

                // Validate inputs
                validator.ValidateConsumerNumber(consumerNumber);
                validator.ValidateUnitsConsumed(units);
                validator.ValidateMonth(month);
                validator.ValidateYear(year);

                // Create bill object
                ElectricityBill bill = new ElectricityBill
                {
                    ConsumerNumber = consumerNumber,
                    ConsumerName = consumerName,
                    UnitsConsumed = units,
                    BillMonth = month,
                    BillYear = year,
                    CreatedDate = DateTime.Now
                };

                // Calculate bill amount
                ebLogic.CalculateBill(bill);

                // Add bill to DB
                ebLogic.AddBill(bill);

                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Text = $"Bill added successfully! Amount: {bill.BillAmount}";
            }
            catch (FormatException ex)
            {
                lblMsg.Text = ex.Message;
            }
            catch (ArgumentException ex)
            {
                lblMsg.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;
            }
        }
    }
}
