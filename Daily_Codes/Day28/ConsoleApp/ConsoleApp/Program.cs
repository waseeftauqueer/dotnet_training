using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectDB connectDB = new ConnectDB();
            //connectDB.AddEmployee();
            //connectDB.DeleteEmployee(14);
            //connectDB.UpdateEmployee();
            //connectDB.ShowEmployee();
            //connectDB.Showprocedure();
            connectDB.EmpTransaction();
        }
    }
}
