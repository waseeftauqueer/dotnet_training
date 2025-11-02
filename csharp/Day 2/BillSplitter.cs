using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class BillSplitter
    {
        public void billSplitter(int billAmount, int totalPeople)
        {
            Console.WriteLine("Each has to pay " + billAmount / totalPeople);
        }
    }
}
