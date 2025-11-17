using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8ConsoleApp
{
    public class CreditCardPayment : PaymentMethod
    {
        public override string Provider => "Credit Card Payment";
        public override bool ProcessPayement(decimal amount)
        {
            base.ProcessPayement(amount);
            if(amount > 5000 && amount < 10000)
            {
                Console.WriteLine($"Processing Amount {amount} through {Provider}");
                return true;
            }
            Console.WriteLine("Payment Failed");
            return false;
        }
    }
}
