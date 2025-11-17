using System;

namespace Day7ConsoleApp
{
    static class Calculation
    {
        public static double pi = 3.14;

        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public static void Multiplication(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }

    interface IPaymentProcessor
    {
        void MakePayment(decimal amount);
    }


    class RefundablePaymentProcessor
    {
        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Refunding payment of {amount:C}.");
        }
    }

    class PayPalProcessor : RefundablePaymentProcessor, IPaymentProcessor, ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now} : {message}");
        }

        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C} through PayPal.");
        }
    }

    class UPIPayment : IPaymentProcessor
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C} through UPI.");
        }

        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Refunding payment of {amount:C} through UPI.");
        }
    }

    class NetBanking : IPaymentProcessor
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C} through Net Banking.");
        }

        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Refunding payment of {amount:C} through Net Banking.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation.Add(1, 2);
            Calculation.Subtract(4, 3);
            Calculation.Multiplication(5, 6);

            SavingsAccount savingsAccount = new SavingsAccount("ADSR", 2000);
            savingsAccount.Deposit(500);
            savingsAccount.CalculateInterest();

            CurrentAccount currentAccount = new CurrentAccount("FDGD", 3000);
            currentAccount.Deposit(500);
            currentAccount.CalculateInterest();

            Console.WriteLine("\nEnter the Payment Option you would choose:");
            Console.WriteLine("1. PayPal");
            Console.WriteLine("2. UPI");
            Console.WriteLine("3. Net Banking");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PayPalProcessor paypal = new PayPalProcessor();
                    paypal.MakePayment(1000);
                    paypal.RefundPayment(500.45m);
                    paypal.Log("Payment of 1000 made through PayPal.");
                    break;

                case 2:
                    IPaymentProcessor upi = new UPIPayment();
                    upi.MakePayment(2000);
                    break;

                case 3:
                    IPaymentProcessor netbanking = new NetBanking();
                    netbanking.MakePayment(3000);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
