using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class BankAccount
    {
        public string AccountHolder;
        public int AccountNumber;
        public double Balance { get; set; }

        public string LastOperator = "";
        public BankAccount(double Balance)
        {
            this.Balance = Balance;
        }
        public BankAccount(double Balance, string AccountHolder, int AccountNumber)
        {
            this.Balance = Balance;
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;
        }
        public static BankAccount operator +(BankAccount a, BankAccount b)
        {
            BankAccount result = new BankAccount(a.Balance + b.Balance);
            result.LastOperator = "+ Addition";
            return result;
        }
        public static BankAccount operator -(BankAccount a, double b)
        {
            BankAccount result = new BankAccount(a.Balance - b);
            result.LastOperator = "Merging accounts (using +)";
            return result;
        }
        public static BankAccount operator *(BankAccount a, BankAccount b)
        {
            BankAccount result = new BankAccount(a.Balance - b.Balance);
            result.LastOperator = "Withdrawal operation (using -)";
            return result;
        }
        public static bool operator ==(BankAccount a, BankAccount b)
        {
            return (a.Balance == b.Balance);
        }
        public static bool operator !=(BankAccount a, BankAccount b)
        {
            return !(a == b);
        }
        public static bool operator <(BankAccount a, BankAccount b)
        {
            return (a.Balance < b.Balance);
        }
        public static bool operator > (BankAccount a, BankAccount b)
        {
            return (b.Balance > a.Balance);
        }
 
        public override string ToString()
        {
            return $"Account Holder : {AccountHolder}, Account Number : {AccountNumber}, Balance : {Balance}";
        }
    }
}
