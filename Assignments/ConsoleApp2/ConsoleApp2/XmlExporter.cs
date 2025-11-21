using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class XmlExporter : DataExporter
    {
        protected override List<string> FetchData()
        {
            return new List<string> { "Red", "Green", "Blue" };
        }

        protected override string FormatData(List<string> data)
        {
            var xml = "<Items>\n";
            foreach (var item in data)
                xml += $"  <Item>{item}</Item>\n";
            xml += "</Items>";
            return xml;
        }
    }

}
