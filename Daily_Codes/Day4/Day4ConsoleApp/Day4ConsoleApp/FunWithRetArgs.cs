using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ConsoleApp
{
    internal class FunWithRetArgs
    {
        // Tow main functions cannot exist, and to specify which one should be taken as the beginning point 
        // we can change that in the build settings.
        static void Main(string[] args)
        {
            int result = addition();
            Console.WriteLine("Addition : " + result);
        }
        static int addition()
        {
            int num1 = 10;
            int num2 = 30;
            int result = num1 + num2;
            return result;
        }
    }
}
