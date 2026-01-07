using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Electrifiers_2._0.Models
{
    public class ElectricityBill
    {
        public string ConsumerNumber { get; set; }
        public string ConsumerName { get; set; }
        public int UnitsConsumed { get; set; }
        public double BillAmount { get; set; }
        public int BillMonth { get; set; }
        public int BillYear { get; set; }
        public DateTime CreatedDate { get; set; }

        public ElectricityBill() { }

        public ElectricityBill(string consumerNumber, string consumerName, int unitsConsumed, int billMonth, int billYear)
        {
            this.ConsumerNumber = consumerNumber;
            this.ConsumerName = consumerName;
            this.UnitsConsumed = unitsConsumed;
            this.BillMonth = billMonth;
            this.BillYear = billYear;
            this.CreatedDate = DateTime.Now;
        }

        public override string ToString()
        {
            string monthName = new DateTime(BillYear, BillMonth, 1).ToString("MMM");
            return $"{ConsumerNumber} {ConsumerName} {UnitsConsumed} Bill Amount: {BillAmount} Month: {monthName}-{BillYear}";
        }
    }
}