using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day6ConsoleApp
{
    public interface Product
    {
        int ProductId { get; set; }
        string ProductName { get; set; }
        double ProductPrice { get; set; }
        void GetProductInfo();
        void DisplayProductInfo();
        
    }

    interface Review
    {
        int ReviewId { get; set; }
        string Comments { get; set; }
        int Ratings { get; set; }
        int ProductId { get; set; }
        void GetReviews();
        void DisplayReviews();

    }

    public class Customers : Product, Review
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public int ReviewId { get; set; }
        public string Comments { get; set; }
        public int Ratings { get; set; }
        

        public void GetProductInfo()
        {
            Console.WriteLine("Enter Product Info:");
            ProductId = Convert.ToInt32(Console.ReadLine());
            ProductName = Console.ReadLine();
            ProductPrice = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product ID: {ProductId}");
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Product Price: {ProductPrice}");
        }

        public void GetReviews()
        {
            Console.WriteLine("Enter Product Review Info:");
            ReviewId = Convert.ToInt32(Console.ReadLine());
            Comments = Console.ReadLine();
            Ratings = Convert.ToInt32(Console.ReadLine());
            ProductId = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayReviews()
        {
            Console.WriteLine($"Review ID: {ReviewId}");
            Console.WriteLine($"Comments: {Comments}");
            Console.WriteLine($"Ratings: {Ratings}");
            Console.WriteLine($"Product ID (linked): {ProductId}");
        }
    }

    internal class MultipleInheritance
    {
        // Multiple Inheritance using Interface
    }
}
