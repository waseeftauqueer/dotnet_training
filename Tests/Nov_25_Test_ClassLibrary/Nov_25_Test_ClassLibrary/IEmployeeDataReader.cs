using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov_25_Test_ClassLibrary
{
    public interface IEmployeeDataReader
    {
        EmployeeRecord GetEmployeeRecord(int employeeId);
    }
}
