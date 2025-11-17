using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8ConsoleApp
{
    internal class CashOnDelivery : PaymentMethod
    {
        public override string Provider => "Cash On Delivery";
        public override bool ProcessPayement(decimal amount)
        {
            base.ProcessPayement(amount);
            if (amount > 10000)
            {
                Console.WriteLine($"Processing Amount {amount} through {Provider}");
                return true;
            }
            Console.WriteLine("Payment Failed");
            return false;
        }
    }
}
