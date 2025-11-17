using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11ConsoleApp
{

    public class InfiniteEmployee : IComparable<InfiniteEmployee>
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal EmpSalary { get; set; }
        public int EmpAge { get; set; }
        public string Location { get; set; }

        //public int CompareTo(InfiniteEmployee infiniteEmployee)
        //{
        //    if (infiniteEmployee == null) return 1;
        //    return this.EmpSalary.CompareTo(infiniteEmployee.EmpSalary);
        //}
        public int CompareTo(InfiniteEmployee infiniteEmployee)
        {
            if (infiniteEmployee == null) return 1;
            return this.EmpId.CompareTo(infiniteEmployee.EmpId);
        }
        internal class Icomparable
        {

            public static void Main(string[] args)
            {
                List<InfiniteEmployee> employees = new List<InfiniteEmployee>()
        {
            new InfiniteEmployee(){EmpId=101,EmpName="Alice",EmpSalary=60000,EmpAge=30,Location="New York"},
            new InfiniteEmployee(){EmpId=102,EmpName="Bob",EmpSalary=55000,EmpAge=28,Location="Los Angeles"},
            new InfiniteEmployee(){EmpId=103,EmpName="Charlie",EmpSalary=70000,EmpAge=35,Location="Chicago"},
            new InfiniteEmployee(){EmpId=104,EmpName="David",EmpSalary=65000,EmpAge=32,Location="Houston"},
            new InfiniteEmployee(){EmpId=105,EmpName="Eve",EmpSalary=72000,EmpAge=29,Location="Phoenix"},
            new InfiniteEmployee(){EmpId=106,EmpName="Frank",EmpSalary=58000,EmpAge=31,Location="Philadelphia"},
            new InfiniteEmployee(){EmpId = 1807003, EmpName = "Ashok Kommuru", EmpSalary = 30000, Location = "Hyderabad" },
            new InfiniteEmployee(){EmpId = 1807001, EmpName = "John Doe", EmpSalary = 45000, Location = "New York" },
            new InfiniteEmployee(){EmpId = 1807002, EmpName = "Jane Smith", EmpSalary = 50000, Location = "Los Angeles" },
            new InfiniteEmployee(){EmpId = 1807004, EmpName = "Amal Davis", EmpSalary = 60000, Location = "Chicago" },
            new InfiniteEmployee(){EmpId = 1807005, EmpName = "Sara Lee", EmpSalary = 55000, Location = "Houston" },
            new InfiniteEmployee(){EmpId = 1807006, EmpName = "David Kim", EmpSalary = 70000, Location = "Phoenix" }
        };


                Console.WriteLine("Employee Details are: ");
                foreach (var emp in employees)
                {
                    Console.WriteLine($"ID: {emp.EmpId}, Name: {emp.EmpName}, Salary: {emp.EmpSalary}, Age: {emp.EmpAge}, Location: {emp.Location}");
                }

                employees.Sort();
                Console.WriteLine("\nEmployee Details after sorting by salary");
                foreach (var emp in employees)
                {
                    Console.WriteLine($"ID: {emp.EmpId}, Name: {emp.EmpName}, Salary: {emp.EmpSalary}, Age: {emp.EmpAge}, Location: {emp.Location}");
                }

                Console.ReadLine();


            }
        }
    }
}