using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ConsoleApp
{
    internal class InheritanceTypes
    {
    }
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
                Balance -= amount;
        }
    }

    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public void AddInterest()
        {
            Balance += Balance * InterestRate;
        }
    }
}
