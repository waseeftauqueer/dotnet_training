using System;

namespace Electrifiers.Models
{
    public class ElectricityBill
    {
        public string ConsumerNumber { get; set; }
        public string ConsumerName { get; set; }
        public int UnitsConsumed { get; set; }
        public double BillAmount { get; set; }

        public ElectricityBill()
        {
            ConsumerNumber = "";
            ConsumerName = "";
            UnitsConsumed = 0;
            BillAmount = 0;
        }

        public ElectricityBill(string number, string name, int units)
        {
            ConsumerNumber = number;
            ConsumerName = name;
            UnitsConsumed = units;
            BillAmount = 0;
        }
    }
}
