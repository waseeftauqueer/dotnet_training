using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8ConsoleApp
{
    internal class InterestCalculator
    {
        public double CalculateInterest(double principal, double rate)
        {
            return (principal * rate * 1) / 100;
        }

        public double CalculateInterest(double principal, double rate, int time)
        {
            return (principal * rate * time) / 100;
        }

        public double CalculateInterest(double principal, double rate, int years, int n)
        {
            double amount = principal * Math.Pow((1 + rate / n), (n * years));
            return amount - principal;
        }
    }
}
