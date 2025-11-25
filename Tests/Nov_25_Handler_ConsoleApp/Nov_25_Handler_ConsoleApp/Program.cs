using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nov_25_Test_ClassLibrary;


namespace Nov_25_Handler_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeDataReader dataReader = new MockEmployeeDataReader();

            PayrollProcessor payrollProcessor = new PayrollProcessor(dataReader);

            for (int id = 1;id <= 3; id++)
            {
                decimal totalComp = payrollProcessor.CalculateTotalCompensation(id);
                Console.WriteLine($"Employee {id} total compensation: {totalComp}");
            }
        }
    }
}
