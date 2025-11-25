using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov_25_Test_ClassLibrary
{
    public class PayrollProcessor
    {
        private IEmployeeDataReader dataReader;

        public PayrollProcessor(IEmployeeDataReader dataReader)
        {
            this.dataReader = dataReader;
        }

        private static readonly Dictionary<int, decimal>BaseSalaries = new Dictionary<int, decimal>
    {
        { 1, 100000m },
        { 2, 80000m },
        { 3, 70000m }
    };
        public decimal CalculateTotalCompensation(int employeeId)
        {
            var employee = dataReader.GetEmployeeRecord(employeeId);

            decimal bonus = 0m;

            if (employee.Role == "Manager" && employee.IsVeteran)
                bonus = 20000m;
            else if (employee.Role == "Manager" && !employee.IsVeteran)
                bonus = 15000m;
            else if (employee.Role == "Developer" && employee.IsVeteran)
                bonus = 10000m;
            else if (employee.Role == "Developer" && !employee.IsVeteran)
                bonus = 5000m;
            else if (employee.Role == "Designer" && employee.IsVeteran)
                bonus = 6000m;
            else if (employee.Role == "Designer" && !employee.IsVeteran)
                bonus = 3000m;
            else
                bonus = 0m;

            decimal baseSalary = BaseSalaries.ContainsKey(employeeId) ?BaseSalaries[employeeId] : 0m;
            return baseSalary + bonus;
        }
    }
}
