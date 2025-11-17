using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8ConsoleApp
{
    internal class OverloadingDemo
    {
        public void getCustomerInfo(int customerId)
        {
            Console.WriteLine("Cusotmer ID : " + customerId);
        }
        public void getCustomerInfo(string cutomerName)
        {
            Console.WriteLine("Customer Name : " + cutomerName);
        }
        public void getCustomerInfo(int customerId, string customerName)
        {
            Console.WriteLine($"Customer Name : {customerName}, Customer ID : {customerId}");
        }
    }
}
