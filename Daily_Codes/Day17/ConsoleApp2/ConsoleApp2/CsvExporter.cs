using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CsvExporter : DataExporter
    {
        protected override List<string> FetchData()
        {
            return new List<string> { "Apple", "Banana", "Cherry" };
        }

        protected override string FormatData(List<string> data)
        {
            return string.Join(",", data);
        }
    }

}
