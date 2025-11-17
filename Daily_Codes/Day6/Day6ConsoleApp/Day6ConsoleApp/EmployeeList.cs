using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6ConsoleApp
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeGender { get; set; }
    }
    internal class EmployeeList
    {
        List<Employee> employeeList = new List<Employee>()
        {
            new Employee() { EmployeeId = 1, EmployeeName = "Jhon Doe", EmployeeGender = "Male" },
            new Employee() { EmployeeId = 2, EmployeeName = "Alice", EmployeeGender = "Female" }
        };
        public string this[int empId]
        {
            get
            {
                return employeeList.FirstOrDefault(e => e.EmployeeId == empId)?.EmployeeName;
            }
            set
            {
                employeeList.FirstOrDefault(e => e.EmployeeId == empId).EmployeeName = value;
            }
        }

        public int this[string empGender]
        {
            get
            {
                return (int)(employeeList.FirstOrDefault(e => e.EmployeeGender == empGender)?.EmployeeId);
            }
            set
            {
                employeeList.FirstOrDefault(e => e.EmployeeGender == empGender).EmployeeId = value;
            }
        }
    }
}
