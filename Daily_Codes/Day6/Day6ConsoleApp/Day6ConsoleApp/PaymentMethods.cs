using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6ConsoleApp
{
    public interface PaymentMethods
    {
        void CreditCardOpt();
        void UpiOpt();
        void WalletOpt();
    }

    public class Pay : PaymentMethods
    {
        public int CardNumber { get; set; }
        public int Cvv { get; set; }
        public string Expiry { get; set; }



        public void CreditCardOpt()
        {
            Console.WriteLine("Enter Card Number : ");
            CardNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter CVV Number : ");
            Cvv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Card Expiry : ");
            Expiry = Convert.ToString(Console.ReadLine());
        }

        public void DispayCardInfo()
        {
            Console.WriteLine("Card Number : " + CardNumber);
            Console.WriteLine("CVV Number : " + Cvv);
            Console.WriteLine("Card Expiry : " + Expiry);
        }

        public void UpiOpt() { }
        public void WalletOpt() { }


    }
}
