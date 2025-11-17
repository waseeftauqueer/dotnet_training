using System;

namespace RideEasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RideEasy!");

          
            Console.WriteLine("\nEnter vehicle type (Hatchback/Sedan/SUV): ");
            string vehicleType = Console.ReadLine();

            Console.WriteLine("Enter vehicle number: ");
            string vehicleNumber = Console.ReadLine();

            Console.WriteLine("Enter vehicle base price: ");
            decimal vehicleBasePrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter per km rate: ");
            decimal vehiclePerKmRate = decimal.Parse(Console.ReadLine());

            Vehicle vehicle = new Vehicle(vehicleNumber, vehicleType, vehicleBasePrice, vehiclePerKmRate);

         
            Console.WriteLine("\nEnter customer name: ");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter customer loyalty points: ");
            int customerLoyaltyPoints = Convert.ToInt32((Console.ReadLine()));

            Customer customer = new Customer(customerName, customerLoyaltyPoints);

            Console.WriteLine("\nEnter ride distance in km: ");
            decimal distance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter ride date (yyyy-MM-dd): ");
            DateTime rideDate = DateTime.Parse(Console.ReadLine());

            Ride ride = new Ride(vehicle, distance, rideDate);

          
            Console.WriteLine("\nEnter add-ons (comma-separated, e.g., child-seat, fast-tag): ");
            string[] addOns = Console.ReadLine().Split(',');

           
            ride.ComputeBill(out decimal subtotal, out decimal gst, out decimal total, addOns);

           
            Console.WriteLine("\nInvoice:");
            Console.WriteLine($"Customer: {customer.customerName}");
            Console.WriteLine($"Vehicle: {vehicle.vehicleType} ({vehicle.vehicleNumber})");
            Console.WriteLine($"Distance: {distance} km");
            Console.WriteLine($"Subtotal: {subtotal:C}");
            Console.WriteLine($"GST (18%): {gst:C}");
            Console.WriteLine($"Total (before coupon): {total:C}");

            Console.WriteLine("\nThank you for using RideEasy!");
        }
    }
}
