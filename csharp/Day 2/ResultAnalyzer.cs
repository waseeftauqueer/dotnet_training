using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ResultAnalyzer
    {
        public void resultAnalyzer(int marks)
        {
            if (marks >= 90) Console.WriteLine("Your Grade is A+");
            else if (marks > 80 && marks < 89) Console.WriteLine("Your Grade is A");
            else if (marks > 70 && marks < 79) Console.WriteLine("Your Grade is B");
            else if (marks > 60 && marks < 69) Console.WriteLine("Your Grade is C");
            else if (marks > 50 && marks < 59) Console.WriteLine("Your Grade is D");
            else if (marks < 50) Console.WriteLine("Your Grade is Fail");

        }
    }
}
