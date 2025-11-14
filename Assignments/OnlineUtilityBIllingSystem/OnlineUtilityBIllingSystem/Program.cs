using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OnlineUtilityBIllingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number of Customers Input
            int numberOfCustomers; int counter = 1;
            Console.WriteLine("Enter the number of Customers : ");
            numberOfCustomers = Convert.ToInt32(Console.ReadLine());



            while (numberOfCustomers > 0)
            {
                Console.WriteLine($"Enter Details for Customer {counter} : \n");

                // Customer Creation
                Console.WriteLine("Customer ID : \n");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Customer Name : \n");
                string name = Console.ReadLine();
                Customer.setCustomer(id, name);

                // Monthly Usage Readings
                Console.WriteLine("Enter Monthly Usage Readings : ");
                int[] readings = new int[3];
                for (int i = 0; i < readings.Length; i++)
                {
                    readings[i] = Convert.ToInt32(Console.ReadLine());
                }
                UtilityBilling.totalUsage(readings);

                // Calculate Bill
                double total, tax, netPayable;
                UtilityBilling.calculatedBill(out total, out tax, out netPayable);

                // Utility Bill Display
                UtilityBilling.display(total, tax, netPayable);

                counter++;
                numberOfCustomers--;
            }

        }
       

    }
}
