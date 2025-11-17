using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method Overloading
            OverloadingDemo overloadingDemo = new OverloadingDemo();
            overloadingDemo.getCustomerInfo(101);
            overloadingDemo.getCustomerInfo("Waseef Tauqueer"); 
            overloadingDemo.getCustomerInfo(102, "Logeshwaran");

            // Method Overriding
            PaymentMethod creditCardPayment = new CreditCardPayment();
            creditCardPayment.ProcessPayement(6000);

            PaymentMethod cashOnDeliveryy = new CashOnDelivery();
            cashOnDeliveryy.ProcessPayement(132321);

            // Sealed Method
            ElectricCar electricCar1 = new ElectricCar();
            electricCar1.Start();

            // Interset Calculator
            InterestCalculator interestCalculator = new InterestCalculator();
            double simpleInt = interestCalculator.CalculateInterest(20000, 5);
            double simpleInt2 = interestCalculator.CalculateInterest(20000, 5, 3);
            double compundInt = interestCalculator.CalculateInterest(20000, 5, 2, 2);

            Console.WriteLine("Simple Interest : " +  simpleInt);
            Console.WriteLine("Simple Interest : " + simpleInt2);
            Console.WriteLine("Compund Interest : " + compundInt);

            // Online Store Checkout
            StoreCheckout storeCheckout = new StoreCheckout();
            storeCheckout.Checkout(2000);
            storeCheckout.Checkout(2000, 4);
            storeCheckout.Checkout("A09F2OO");
            storeCheckout.Checkout(2000, 4, "A09F2OO");
        }
    }
}
