using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Assignemnts
{
    internal static class ExtensionForSquares
    {
        public static int SumOfSquares(this IEnumerable<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number * number;
            }
            return sum;
        }
    }
}
