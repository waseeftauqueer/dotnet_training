using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Assignemnts
{
    internal static class ExtensionForString
    {
        public static bool IsUpper(this string input)
        {
            if(string.IsNullOrEmpty(input))
                return false;

            return input == input.ToUpper();
        }
    }
}
