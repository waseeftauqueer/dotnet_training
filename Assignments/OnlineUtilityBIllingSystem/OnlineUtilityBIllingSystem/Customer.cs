using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineUtilityBIllingSystem
{
    internal class Customer
    {
        public static int customerId;
        public static string customerName;

        public static void setCustomer(int Id, string Name)
        {
            customerId = Id;
            customerName = Name;
        }

        public static int getCustomerId()
        {
            return Customer.customerId;
        }
        public static string getCustomerName()
        {
            return Customer.customerName;
        }
    }
}
