using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class MovieTicket
    {
        public void ticketPrice(int pAge, int time)
        {
            if (pAge < 12) Console.WriteLine("Your ticket price is $150");
            else if (pAge >= 12 && time < 6) Console.WriteLine("Your ticket price is $250");
            else if (pAge >= 12 && time > 6) Console.WriteLine("Your ticket price is $300"); 
        }
    }
}
