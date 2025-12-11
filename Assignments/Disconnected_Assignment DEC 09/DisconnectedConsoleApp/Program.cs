using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisconnectedAssignment disconnectedAssignment = new DisconnectedAssignment();
            disconnectedAssignment.DisplayRecords();
            //disconnectedAssignment.FilterForEmployee();
            //disconnectedAssignment.TotalTables();
            //disconnectedAssignment.DeptTableLoader();
            //disconnectedAssignment.MergeDataSets();
            disconnectedAssignment.ReadXMLDataSource();

        }
    }
}
