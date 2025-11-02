using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class BonusCalculator
    {
        public void bonusCalculator(int years, double salary)
        {
            if (years > 10)
            {
                Console.WriteLine("Your Bonus is 20%");
                Console.WriteLine("Your Salary is : " + ((salary * 0.20) + salary));
            }
            else if (years >= 5 && years <= 10)
            {
                Console.WriteLine("Your Bonus is 10%");
                Console.WriteLine("Your Salary is : " + ((salary * 0.10) + salary));
            }
            else if (years < 5)
            {
                Console.WriteLine("Your Bonus is 5%");
                Console.WriteLine("Your Salary is : " + ((salary * 0.05) + salary));
            }
        }
    }
}
