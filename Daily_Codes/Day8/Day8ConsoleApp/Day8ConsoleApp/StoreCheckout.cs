using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8ConsoleApp
{
    internal class StoreCheckout
    {
        public void Checkout(int price)
        {
            Console.WriteLine("PRICE : " + price);
        }
        public void Checkout(int price, int quantity)
        {
            Console.WriteLine($"PRICE : {price}, QUANTITY : {quantity}, TOTAL : {price * quantity}");
        }
        public void Checkout(string coupounCode)
        {
            Console.WriteLine($"Coupoun Code {coupounCode} applied to this bill!");
        }
        public void Checkout(int price, int quantity, string coupounCode)
        {
            Console.WriteLine($"PRICE : {price}, QUANTITY : {quantity}, COUPOUN CODE : {coupounCode}");
        }
        }
}
