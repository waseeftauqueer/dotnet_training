using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7ConsoleApp
{
    internal class CurrentAccount : BankAccount
    {
        public CurrentAccount(string AccountNumber, double InitialBalance) : base(AccountNumber, InitialBalance) { }
        public override void CalculateInterest()
        {
            Console.WriteLine("No Interest for CUrrent Account");
        }
    }
}
