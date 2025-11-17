using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_ConsoleApp
{
    internal class Calculator
    {
        // Without return and with Arguments
        public void addNumber(int num1, int num2)
        {
            Console.WriteLine("\nAddition Output : " + (num1 + num2));
        }
        public void subtractNumber(int num1, int num2)
        {
            Console.WriteLine("\nSubtraction Output : " + (num1 - num2));
        }
        // With return type and with Arguments
        public int multiplyNumber(int num1, int num2)
        {
            return num1 * num2;
        }

        public void calculate(int num1, int num2, out int addResult, out int subResult, out int multiResult)
        {
            addResult = num1 + num2;
            subResult = num1 - num2;
            multiResult = num1 * num2;
        }
    }
}
