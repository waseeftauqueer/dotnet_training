using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov_25_Test_ClassLibrary
{
    public class MockEmployeeDataReader : IEmployeeDataReader
    {
        public EmployeeRecord GetEmployeeRecord(int employeeId)
        {
            switch (employeeId)
            {
                case 1:
                    return new EmployeeRecord { Id = 1,Name = "Waseef", Role = "Manager", IsVeteran =true };
                case 2:
                    return new EmployeeRecord { Id = 2,Name = "Logesh",Role= "Developer", IsVeteran = false };
                case 3:
                    return new EmployeeRecord { Id = 3,Name = "Ragul", Role = "Designer", IsVeteran= true };
                default:
                    return new EmployeeRecord { Id = employeeId, Name = "Unknown",Role = "Unknown", IsVeteran = false };
            }
        }
    }

}
