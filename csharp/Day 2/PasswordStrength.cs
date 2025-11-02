using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class PasswordStrength
    {
        public void passwordStrength(string password)
        {
            int passLength = password.Length;

            if (passLength < 6) Console.WriteLine("Weak Password");
            else if (passLength > 6 && passLength < 10) Console.WriteLine("Medium Password");
            else if (passLength > 10) Console.WriteLine("Strong Password");
        }
    }
}
