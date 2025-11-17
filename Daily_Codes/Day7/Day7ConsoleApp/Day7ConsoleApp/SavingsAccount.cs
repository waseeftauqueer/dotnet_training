using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7ConsoleApp
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string AccountNumber, double InitialBalance) : base(AccountNumber, InitialBalance) { }
        public override void CalculateInterest()
        {
            double interest = AccountBalance * 0.04;
            AccountBalance += interest;
            Console.WriteLine($"Interest Added : {interest}, New Balance : {AccountBalance}");
        }
    }
}
