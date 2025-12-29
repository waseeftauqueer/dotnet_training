using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CrudDemo demo = new CrudDemo();
            demo.showallemployees();
            //demo.SearchRecord();
            //demo.AddRecord();
            //demo.MatchingRecords();
            //demo.DisplayDetails();
            //demo.DOJFilter();
            //demo.ApplyBonus();
            //demo.SqlQueryDemo();
            demo.DMLDemo();
        }
    }
}
