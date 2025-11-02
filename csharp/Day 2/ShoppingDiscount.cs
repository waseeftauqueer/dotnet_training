using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ShoppingDiscount
    {
        public void shoppingDiscount(int amount)
        {
            if (amount < 1000) Console.WriteLine("No Discount for You");
            else if (amount > 1000 &&  amount < 5000)
            {
                Console.WriteLine("Your Discount is 10 %");
                Console.WriteLine("Your Disounted bill amount : " + (amount - (amount * 0.10)));
            }
            else if(amount > 5000)
            {
                Console.WriteLine("Your Discount is 20 %");
                Console.WriteLine("Your Disounted bill amount : " + (amount - (amount * 0.20)));
            }

        }
    }
}
