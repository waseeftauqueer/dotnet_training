using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    internal class Program
    {
       
        static void PrintEmployees(List<Employee> employeeList)
        {
            foreach (var emp in employeeList)
            {
                Console.WriteLine($"EmpId : {emp.EmpId}, Name : {emp.Name}, Department : {emp.Department}, Salary : {emp.Salary}, Experience : {emp.Experience}");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // List Creation
            List<Employee> employeesList = new List<Employee>()
            {
                new Employee{EmpId=101, Name="Waseef Tauqueer", Department="IT", Salary=75000, Experience=6 },
                new Employee{ EmpId=102, Name="Logeshwaran", Department="HR", Salary=45000, Experience=3 },
                new Employee{ EmpId=103, Name="Keerthik Ragul", Department="Finance", Salary=50000, Experience=7 },
                new Employee{EmpId=104, Name="Sakthivel Kannan", Department="IT", Salary=65000, Experience=4 },
                new Employee{EmpId=105, Name="Salmaan Khan", Department="Admin", Salary=30000, Experience=2 },
                new Employee{ EmpId=106, Name="Sharukh Khan", Department="IT", Salary=90000, Experience=10 },
                new Employee{ EmpId=107, Name="Ashok Kumar", Department="Finance", Salary=48000, Experience=5 },
                new Employee{EmpId=108, Name="Vishal", Department="HR", Salary=55000, Experience=8 },
                new Employee{ EmpId=109, Name="Yoogananth", Department="Marketing", Salary=51000, Experience=6 },
                new Employee{ EmpId=110, Name="Sairam", Department="IT", Salary=40000, Experience=1 }
            };

            // Employee list printing
            Console.WriteLine("Employee Details");
            Console.WriteLine();
            foreach(var emp in employeesList)
            {
                Console.WriteLine($"EmpId : {emp.EmpId}, Name : {emp.Name}, Department : {emp.Department}, Salary : {emp.Salary}, Experience : {emp.Experience}");
            }

            // Employee salary > 50000
            var salaryFilter = employeesList.Where(emp => emp.Salary >50000).ToList();
            Console.WriteLine("\nEmployee salary > 50000");
            PrintEmployees(salaryFilter);

            // Employee in IT Department
            var departmentFilter = employeesList.Where(emp =>emp.Department =="IT").ToList();
            Console.WriteLine("\nEmployees from IT Department");
            PrintEmployees(departmentFilter);

            // Experience > 5 years
            var experienceFilter= employeesList.Where(emp =>emp.Experience > 5).ToList();
            Console.WriteLine("\nEmployee with more than 5 years experience");
            PrintEmployees(experienceFilter);

            // Names staring with 'A'
            var nameFilter = employeesList.Where(emp => emp.Name[0] =='A').ToList();
            Console.WriteLine("Employee names starting with A");
            PrintEmployees(nameFilter);

            // Sorting by name
            var sortName = employeesList.OrderBy(emp =>emp.Name).ToList();
            Console.WriteLine("Employee list sorted");
            PrintEmployees(sortName);

            // Sorting by salary
            var sortSalary = employeesList.OrderByDescending(emp=>emp.Salary).ToList();
            Console.WriteLine("Employee list sorted by salary");
            PrintEmployees(sortSalary);

            // Sorting by experience
            var sortExperience = employeesList.OrderBy(emp=> emp.Experience).ToList();
            Console.WriteLine("Employee list sorted by experience");
            PrintEmployees(sortExperience);
        }
    }
}
