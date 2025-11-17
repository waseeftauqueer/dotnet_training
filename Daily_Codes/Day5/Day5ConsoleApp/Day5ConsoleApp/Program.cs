using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ConsoleApp
{
    // ShowRegistration(),DisplayBasicInfo(),DisplayVehicleInfo(),UpdateServiceCount(),PerformInspection(),PerformMaintenance()

    class Vehicle
    {
        private string vehicleType;
        private string vehicleName;
        private string vehicleId;
        public int serviceCount;

        public Vehicle(string vehicleType, string vehicleName, string vehicleId)
        {
            this.vehicleType = vehicleType;
            this.vehicleName = vehicleName;
            this.vehicleId = vehicleId;
            Console.WriteLine("Base Class Called");
        }

        protected void DisplayBasicInfo()
        {
            Console.WriteLine("\n--- Vehicle Basic Info ---");
            Console.WriteLine("Vehicle Type : " + vehicleType);
            Console.WriteLine("Vehicle Name : " + vehicleName);
            Console.WriteLine("Vehicle ID : " + vehicleId);
        }

        protected int UpdateServiceCount()
        {
            serviceCount++;
            return serviceCount;
        }

        public void PerformInspection()
        {
            Console.WriteLine("\nPerforming vehicle inspection...");
            Console.WriteLine("Inspection completed successfully!");
            UpdateServiceCount();
        }

        public void PerformMaintenance()
        {
            Console.WriteLine("\nPerforming routine maintenance...");
            Console.WriteLine("Maintenance completed successfully!");
            UpdateServiceCount();
        }
    }

    // Car Class Inheriting Vehicle

    class Car : Vehicle
    {
        private string carFuelType;
        private string carBrand;
        private string carRegistration;

        public Car(string carFuelType, string carBrand, string carRegistration,
                   string vehicleType, string vehicleName, string vehicleId)
            : base(vehicleType, vehicleName, vehicleId)
        {
            this.carFuelType = carFuelType;
            this.carBrand = carBrand;
            this.carRegistration = carRegistration;
            Console.WriteLine("Derived Class Called");
        }

        public void ShowRegistration()
        {
            Console.WriteLine("\nCar Registration Number : " + carRegistration);
        }

        public void DisplayVehicleInfo()
        {
            DisplayBasicInfo();
            Console.WriteLine("Car Brand : " + carBrand);
            Console.WriteLine("Car Fuel Type : " + carFuelType);
            Console.WriteLine("Car Registration Number : " + carRegistration);
        }
    }


    class Person
    {
        string personName;
        int personAge;

        public Person()
        {
            Console.WriteLine("Base class Constructor");
        }
        public Person(string personName, int personAge)
        {
            this.personName = personName;
            this.personAge = personAge;
            Console.WriteLine("Base class Constructor");
        }

        public void setPersonData()
        {
            Console.WriteLine("Enter Person Name : ");
            personName = Console.ReadLine();
            Console.WriteLine("Enter Person Age : ");
            personAge = Convert.ToInt32(Console.ReadLine());
        }
        protected void display()
        {
            Console.WriteLine("Person Name : " +  personName);
            Console.WriteLine("Person Age : " + personAge);
        }
    }

    // Employee Class inheriting Person
    class Employee : Person
    {
        int employeeId;
        string employeeName;

        public Employee()
        {
            Console.WriteLine("Derived class Consturctor");
        }

        public Employee(string personName, int personAge, int employeeId, string employeeName) : base(personName, personAge) 
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            Console.WriteLine("Derived Class Constructor");
        }

        public void setEmployeeData()
        {
            setPersonData();
            Console.WriteLine("Enter Employee ID : ");
            employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            employeeName = Console.ReadLine();
        }

        // By default private
        public void displayEmployeeDetails()
        {
            display();
            Console.WriteLine("Employee ID : " + employeeId);
            Console.WriteLine("Employee Name : " + employeeName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Petrol", "Toyota", "AB1234", "Car", "Corolla", "V001");


            // Calling Car Methods
            myCar.DisplayVehicleInfo();
            myCar.PerformInspection();
            myCar.PerformMaintenance();
            myCar.ShowRegistration();


            // Getter Setter Example
            GetterSetterDemo student = new GetterSetterDemo();
            student.StudentId = Convert.ToInt32(Console.ReadLine());
            student.StudentName = Console.ReadLine();
            student.StudentAge = Convert.ToInt32(Console.ReadLine());
            student.StudentPassword = "wesdffsd21";

            Console.WriteLine("Student ID : " +  student.StudentId);
            Console.WriteLine("Student Name : " + student.StudentName);
            Console.WriteLine("Student Age : " + student.StudentAge);
        }
    }
}
