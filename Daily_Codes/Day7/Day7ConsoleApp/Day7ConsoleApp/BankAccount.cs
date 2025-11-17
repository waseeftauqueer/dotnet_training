using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7ConsoleApp
{
     public abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public double AccountBalance { get; set; }

        public BankAccount(string AccountNumber, double AccountBalance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountBalance = AccountBalance;
        }

        public abstract void CalculateInterest();

        public void Deposit(double amount)
        {
            AccountBalance += amount;
            Console.WriteLine($"Deposited Amount {amount}, New Balance is {AccountBalance}");
        }
    }
}
