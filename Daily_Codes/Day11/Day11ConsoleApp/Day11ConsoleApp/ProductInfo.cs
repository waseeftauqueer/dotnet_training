using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11ConsoleApp
{
    public class ProductInfo
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
    public class SortByPricingAscending : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Null argument provided");
            }
            return x.Price.CompareTo(y.Price);
        }
    }

    public class SortByPriceDescending : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Null argument provided");
            }
            return y.Price.CompareTo(x.Price);
        }
    }

    public class SortByRating : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Null argument provided");
            }
            return y.Rating.CompareTo(x.Rating);
        }
    }

    public class SortByName : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Null argument provided");
            }
            return x.ProductName.CompareTo(y.ProductName);
        }
    }
    internal class IComparerInterfaceDemo
    {
        static void Main(string[] args)
        {
            List<ProductInfo> products = new List<ProductInfo>()
            {
                new ProductInfo(){ProductID=1,ProductName="Laptop",Price=80000,Rating="4.5"},
                new ProductInfo(){ProductID=2,ProductName="Smartphone",Price=50000,Rating="4.7"},
                new ProductInfo(){ProductID=3,ProductName="Tablet",Price=30000,Rating="4.2"},
                new ProductInfo(){ProductID=4,ProductName="Monitor",Price=15000,Rating="4.3"},
                new ProductInfo(){ProductID=5,ProductName="Keyboard",Price=2000,Rating="4.0"},
                new ProductInfo(){ProductID=6,ProductName="Mouse",Price=1000,Rating="4.1"},
                new ProductInfo(){ProductID=7,ProductName="Printer",Price=12000,Rating="4.4"},
                new ProductInfo(){ProductID=8,ProductName="Webcam",Price=2500,Rating="4.6"},
                new ProductInfo(){ProductID=9,ProductName="Headphones",Price=3000,Rating="4.8"},
                new ProductInfo(){ProductID=10,ProductName="Speakers",Price=4000,Rating="4.2"}
            };

            Console.WriteLine("Product Details: ");
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.Price}, Rating: {product.Rating}");
            }

            Console.WriteLine("\nSort by Price: [Ascending] ");
            products.Sort(new SortByPricingAscending());
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.Price}, Rating: {product.Rating}");
            }

            Console.WriteLine("\nSort by Price: [Descending] ");
            products.Sort(new SortByPriceDescending());
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.Price}, Rating: {product.Rating}");
            }

            Console.WriteLine("\nSort by Rating: ");
            products.Sort(new SortByRating());
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.Price}, Rating: {product.Rating}");
            }

            Console.WriteLine("\nSort by Product Name: ");
            products.Sort(new SortByName());
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.Price}, Rating: {product.Rating}");
            }

            Console.ReadLine();
        }
    }
}