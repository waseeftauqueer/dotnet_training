using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class DataExporter
    {
        public void Export()
        {
            Connect();
            var data = FetchData();
            var formatted = FormatData(data);
            SaveToFile(formatted);
        }

        protected virtual void Connect()
        {
            Console.WriteLine("Connecting to data source...");
        }

        protected abstract List<string> FetchData();
        protected abstract string FormatData(List<string> data);

        protected virtual void SaveToFile(string formattedData)
        {
            Console.WriteLine("Saving file:");
            Console.WriteLine(formattedData);
            Console.WriteLine();
        }
    }

}
