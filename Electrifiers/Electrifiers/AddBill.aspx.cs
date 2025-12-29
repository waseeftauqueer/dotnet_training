using Electrifiers.Models;
using Electrifiers.Validators;
using System;
using System.Web.UI;

namespace Electrifiers
{
    public partial class AddBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblBillAmount.Text = "";
        }

        protected void btnAddBill_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;
            }

            try
            {
                ElectricityBill ebill = new ElectricityBill
                {
                    ConsumerNumber = txtConsumerNumber.Text.Trim(),
                    ConsumerName = txtConsumerName.Text.Trim()
                };

                int units = int.Parse(txtUnitsConsumed.Text.Trim());
                ebill.UnitsConsumed = units;

                ElectricityBoard board = new ElectricityBoard();
                board.CalculateBill(ebill);

                lblBillAmount.Text = $"Bill Amount: {ebill.BillAmount}";

                board.AddBill(ebill);

                txtConsumerNumber.Text = "";
                txtConsumerName.Text = "";
                txtUnitsConsumed.Text = "";

                lblMessage.Text = "Bill successfully added.";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }
    }
}
