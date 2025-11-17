using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8ConsoleApp
{
    public class PaymentMethod
    {
        public virtual string Provider => "Generic Payment Provider";
        public virtual bool ProcessPayement(decimal amount)
        {
            if(amount > 0)
            {
                Console.WriteLine($"Processing Amount {amount} through {Provider}");
                return true;
            }
            Console.WriteLine("Payment Failed");
            return false;
        }
    }
}
