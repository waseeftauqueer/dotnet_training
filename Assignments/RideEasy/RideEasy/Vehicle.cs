using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasy
{
    internal class Vehicle
    {
        public string vehicleNumber;
        public string vehicleType;
        public decimal vehicleBasePrice;
        public decimal vehiclePerKmRate;

        public Vehicle(string vehicleNumber, string vehicleType, decimal vehicleBasePrice, decimal vehiclePerKmRate)
        {
            this.vehicleNumber = vehicleNumber;
            this.vehicleType = vehicleType;
            this.vehicleBasePrice = vehicleBasePrice;
            this.vehiclePerKmRate = vehiclePerKmRate;
        }
    }
}
