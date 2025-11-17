using Day10ConsoleApp;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Day10trainning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------- ARRAYLIST DEMO ----------------
            ArrayList arraylist = new ArrayList();
            Console.WriteLine("Initial Capacity: " + arraylist.Capacity);

            arraylist.Add(10);
            Console.WriteLine("Capacity after adding the first item: " + arraylist.Capacity);

            arraylist.Add("Test item 1");
            arraylist.Add(true);
            arraylist.Add(15.5);
            Console.WriteLine("Capacity after adding four items: " + arraylist.Capacity);

            Console.WriteLine("Items in the ArrayList:");
            foreach (var item in arraylist)
                Console.WriteLine(item);

            arraylist.Remove(true);
            Console.WriteLine("After removing 'true':");
            foreach (var item in arraylist)
                Console.WriteLine(item);

            Console.WriteLine("Capacity after removing 'true': " + arraylist.Capacity);

            arraylist.Add("logesh");
            arraylist.Add("prathees");
            arraylist.Add("dileep");
            arraylist.Insert(1, "adhi is inserting at 1");
            Console.WriteLine("After adding seven values: " + arraylist.Capacity);

            foreach (var item in arraylist)
                Console.WriteLine(item);

            ArrayList arraylist2 = new ArrayList
            {
                "first item in array list 2",
                "second item in array list 2"
            };
            arraylist.AddRange(arraylist2);

            Console.WriteLine("After adding 9 values, capacity: " + arraylist.Capacity);

            ArrayList deptList = new ArrayList { "It", "Hr", "admin", "Finance" };
            arraylist.InsertRange(2, deptList);

            Console.WriteLine("After inserting dept list in ArrayList:");
            foreach (var item in arraylist)
                Console.WriteLine(item);

            Console.WriteLine("Capacity after adding 13 values: " + arraylist.Capacity);
            Console.WriteLine($"Hr is contained in ArrayList: {arraylist.Contains("Hr")}");
            Console.WriteLine("Total count: " + arraylist.Count);
            Console.WriteLine($"arraylist[4]: {arraylist[4]}");

            ArrayList arraylist3 = arraylist.GetRange(3, 5);
            Console.WriteLine("ArrayList3 values:");
            foreach (var item in arraylist3)
                Console.WriteLine(item);

            Console.WriteLine("Reversed ArrayList3:");
            arraylist3.Reverse();
            foreach (var item in arraylist3)
                Console.WriteLine(item);

            Console.WriteLine("After removing range (2,2) in ArrayList3:");
            arraylist3.RemoveRange(2, 2);
            foreach (var item in arraylist3)
                Console.WriteLine(item);

            Console.WriteLine("After removing element at index 1:");
            arraylist3.RemoveAt(1);
            foreach (var item in arraylist3)
                Console.WriteLine(item);

            // ---------------- HASHTABLE DEMO ----------------
            Hashtable ht = new Hashtable
            {
                { 1, "Waseef" },
                { 2, "Tauqueer" },
                { "empId", 101 },
                { "dept", "IT" },
                { "location", "banglore" }
            };

            ht["email"] = "waseef@gmail.com";
            ht[56] = "test value";

            Console.WriteLine("\nHashTable Values:");
            Console.WriteLine("Count: " + ht.Count);
            Console.WriteLine("Key 56 available: " + ht.ContainsKey(56));
            Console.WriteLine("Value waseef@gmail.com present: " + ht.ContainsValue("waseef@gmail.com"));

            ht.Remove(2);

            Console.WriteLine("\nHashTable Values:");
            foreach (var item in ht.Values)
                Console.WriteLine("Value: " + item);

            Console.WriteLine("\nHashTable Key-Value Pairs:");
            foreach (DictionaryEntry item in ht)
                Console.WriteLine(item.Key + " : " + item.Value);

            object[] keysArray = new object[ht.Keys.Count];
            ht.Keys.CopyTo(keysArray, 0);

            Console.WriteLine("\nAfter copying all keys into keyArray:");
            foreach (var item in keysArray)
                Console.WriteLine(item);

            Hashtable ht2 = new Hashtable();
            foreach (DictionaryEntry item in ht)
                ht2[item.Key] = item.Value;

            // ---------------- EMPLOYEE PORTAL ----------------
            ArrayList employeeList = new ArrayList
            {
                new Employee { EmpId = 101, Name = "Waseef", Department = "ECE", Salary = 120000 },
                new Employee { EmpId = 102, Name = "Ayushman", Department = "CSE", Salary = 95000 },
                new Employee { EmpId = 103, Name = "Rahul", Department = "ME", Salary = 88000 },
                new Employee { EmpId = 104, Name = "Rajesh", Department = "EEE", Salary = 110000 },
                new Employee { EmpId = 105, Name = "Arjun", Department = "IT", Salary = 102000 }
            };

            while (true)
            {
                Console.WriteLine("\n=== Employee Portal ===");
                Console.WriteLine("1. Add new employee");
                Console.WriteLine("2. Display all employees");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Remove Employee");
                Console.WriteLine("5. Sort Employees by Salary");
                Console.WriteLine("6. Reverse Employee List");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Employee newEmp = new Employee();
                        Console.Write("Enter Employee ID: ");
                        newEmp.EmpId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        newEmp.Name = Console.ReadLine();
                        Console.Write("Enter Department: ");
                        newEmp.Department = Console.ReadLine();
                        Console.Write("Enter Salary: ");
                        newEmp.Salary = Convert.ToDouble(Console.ReadLine());
                        employeeList.Add(newEmp);
                        Console.WriteLine("Employee added successfully!");
                        break;

                    case 2:
                        Console.WriteLine("\nAll Employees:");
                        foreach (Employee emp in employeeList)
                            Console.WriteLine(emp);
                        break;

                    case 3:
                        Console.Write("Enter Employee ID to search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        bool found = false;
                        foreach (Employee emp in employeeList)
                        {
                            if (emp.EmpId == searchId)
                            {
                                Console.WriteLine("Employee found:\n" + emp);
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                            Console.WriteLine("Employee not found!");
                        break;

                    case 4:
                        Console.Write("Enter Employee ID to remove: ");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        Employee toRemove = null;
                        foreach (Employee emp in employeeList)
                        {
                            if (emp.EmpId == removeId)
                            {
                                toRemove = emp;
                                break;
                            }
                        }
                        if (toRemove != null)
                        {
                            employeeList.Remove(toRemove);
                            Console.WriteLine("Employee removed successfully!");
                        }
                        else
                            Console.WriteLine("Employee not found!");
                        break;

                    case 5:
                        employeeList.Sort(new SalaryComparer());
                        Console.WriteLine("Employees sorted by salary:");
                        foreach (Employee emp in employeeList)
                            Console.WriteLine(emp);
                        break;

                    case 6:
                        employeeList.Reverse();
                        Console.WriteLine("Employee list reversed!");
                        foreach (Employee emp in employeeList)
                            Console.WriteLine(emp);
                        break;

                    case 7:
                        Console.WriteLine("Exiting Employee Portal...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
    }

    // Employee class
    internal class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"ID: {EmpId}, Name: {Name}, Dept: {Department}, Salary: {Salary}";
        }
    }

    // Comparer for sorting by Salary
    internal class SalaryComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Employee e1 = (Employee)x;
            Employee e2 = (Employee)y;
            return e1.Salary.CompareTo(e2.Salary);
        }
    }
}
