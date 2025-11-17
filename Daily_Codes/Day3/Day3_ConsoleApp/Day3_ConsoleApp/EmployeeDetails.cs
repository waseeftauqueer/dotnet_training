using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day3_ConsoleApp
{
    internal class EmployeeDetails
    {
        private int empId;
        private string empName;
        private int empAge;
        private string empDesignation;
        private string empLocation;

        // All default values should be declared at the end of the parameter list
        public void setEmployeeDetails(int empId, string empName, int empAge, string empDesignation, string empLocation = "Bangalore")
        {
            this.empId = empId;
            this.empName = empName;
            this.empAge = empAge;
            this.empDesignation = empDesignation;
            this.empLocation = empLocation;
        }
        public void getEmployeeDetails()
        {
            Console.WriteLine("Employee ID : " + empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Age : " + empAge);
            Console.WriteLine("Employee Designation : " + empDesignation);
            Console.WriteLine("Employee Location : " + empLocation);
        }
    }
}
