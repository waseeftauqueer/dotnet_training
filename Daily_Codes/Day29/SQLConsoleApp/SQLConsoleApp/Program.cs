using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectDB connectDB = new ConnectDB();
            connectDB.ShowAllEmployee();
            //connectDB.SearchEmployee();
            //connectDB.AddEmployee();
            //connectDB.DeleteEmployee();
            //connectDB.UpdateEmployee();
            //connectDB.FilterEmployee();
            //connectDB.StoreinXML();
            connectDB.changes();
        }
    }
}
