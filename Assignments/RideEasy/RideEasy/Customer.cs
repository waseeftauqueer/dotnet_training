using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasy
{
    internal class Customer
    {
        public string customerName;
        public int customerLoyaltyPoints;

        public Customer(string customerName, int customerLoyaltyPoints)
        {
            this.customerName = customerName;
            this.customerLoyaltyPoints = customerLoyaltyPoints;
        }
    }
}
