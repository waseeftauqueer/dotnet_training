using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ConsoleApp
{
    internal class CallTypes
    {
        // Call by value
        public static void methodValue(int a)
        {
            a = a + 1;
        }

        // Call by reference
        public static void methodRef(ref int b)
        {
            b = b + 1;
        }
    }
}
