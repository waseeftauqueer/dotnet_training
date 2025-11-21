using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataExporter csv = new CsvExporter();
            DataExporter json = new JsonExporter();
            DataExporter xml = new XmlExporter();

            csv.Export();
            json.Export();
            xml.Export();
        }
    }
}
