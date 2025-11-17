using FileHandlingDemo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12ConsoleApp
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public Address DeepCopy()
        {
            return new Address
            {
                City = this.City,
                Street = this.Street
            };
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address HomeAddress { get; set; } //reference

        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }
        public Employee DeepCopy()
        {
            Employee clonedEmployee = (Employee)this.MemberwiseClone(); //shallw first
            clonedEmployee.HomeAddress = this.HomeAddress.DeepCopy(); // fix reference
            return clonedEmployee;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Infinite\\file.txt";

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Hello World");
                sw.WriteLine("THe sample file is Updated by Writer");
            }
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Hello World");
                sw.WriteLine("THe sample file is Updated");
            }
            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("Updated File Contet");
                Console.WriteLine(content);
            }

            // File Copying
            string sourceDir = @"C:\\Infinite\\SampleSource";
            string targetDir = @"C:\\Infinite\\SampleDestination";

            DirectoryInfo sdi = new DirectoryInfo(sourceDir);
            DirectoryInfo tdi = new DirectoryInfo(targetDir);

            if (!tdi.Exists)
            {
                tdi.Create();
            }

            // Copy files into new directory
            foreach(FileInfo fi in sdi.GetFiles())
            {
                fi.CopyTo(Path.Combine(tdi.ToString(), fi.Name), true);
                Console.WriteLine(@"Copying {0}\{1}", tdi.FullName, fi.Name);
            }
            //copying each sub dorectories and its files

            foreach (DirectoryInfo sourcesubdir in sdi.GetDirectories())

            {

                DirectoryInfo targetSubdir = tdi.CreateSubdirectory(sourcesubdir.Name);

                //copying each file into it's new directory 

                foreach (FileInfo fi in sourcesubdir.GetFiles())

                {

                    fi.CopyTo(Path.Combine(targetSubdir.ToString(), fi.Name), true);

                    Console.WriteLine(@"coping {0}\{1}", targetSubdir.FullName, fi.Name);
                }

            }

            // Shallow and Deep Copy

            Employee emp1 = new Employee { Name = "John", Age = 30, HomeAddress = new Address { City = "New York", Street = "5th Avenue" } };
            Employee emp2 = emp1.ShallowCopy();
            Employee emp3 = emp1.DeepCopy();

            emp2.Name = "Doe";
            emp2.HomeAddress.City = "Los Angeles";

            Console.WriteLine("emp1.name" + emp1.Name);
            Console.WriteLine($"emp1.Home address" + emp1.HomeAddress.City);

            Console.WriteLine("emp2.name" + emp2.Name);
            Console.WriteLine($"emp2.Home address" + emp2.HomeAddress.City);

            Console.WriteLine("emp3.name" + emp3.Name);
            Console.WriteLine($"emp3.Home address" + emp3.HomeAddress.City);

            // Thread Lifecycle
            ThreadLifeCycle.Run();

            // Garbage Collection
            GarbageCollectorDemo gcDemo = new GarbageCollectorDemo();
            gcDemo.RunGarbageCollectorDemo();
        }
    }
}
