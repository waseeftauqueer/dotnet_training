using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount(3000, "Waseef Tauqueer", 1329567);
            BankAccount bankAccount2 = new BankAccount(7000, "Logeshwaran", 4389789);
            double withdrawlAmmount = 450;

            Console.WriteLine(bankAccount1.ToString());
            Console.WriteLine(bankAccount2.ToString());
            Console.WriteLine();

            BankAccount merging = bankAccount1 + bankAccount2;
            Console.WriteLine("Merging Accounts using + : ");
            Console.WriteLine("Combined Balance : " + merging.Balance);
            Console.WriteLine("--------------------------------------");
            BankAccount withdrawl = bankAccount1 - withdrawlAmmount;
            Console.WriteLine($"Withdrawl Operation using - : (Amount {withdrawlAmmount})");
            Console.WriteLine($"New Balance of {bankAccount1.AccountHolder} is {Math.Abs(withdrawl.Balance)}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Account Comparison : ");
            Console.WriteLine($"{bankAccount1.AccountNumber} == {bankAccount2.AccountNumber} -> {bankAccount1 == bankAccount2}");
            Console.WriteLine($"{bankAccount1.AccountNumber} != {bankAccount2.AccountNumber} -> {bankAccount1 != bankAccount2}");
            Console.WriteLine($"{bankAccount1.AccountNumber} > {bankAccount2.AccountNumber} -> {bankAccount1 > bankAccount2}");
            Console.WriteLine($"{bankAccount1.AccountNumber} < {bankAccount2.AccountNumber} -> {bankAccount1 < bankAccount2}");
            Console.WriteLine("--------------------------------------");
        }
    }
}
