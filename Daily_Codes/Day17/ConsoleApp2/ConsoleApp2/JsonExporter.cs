using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace ConsoleApp2
{
    public class JsonExporter : DataExporter
    {
        protected override List<string> FetchData()
        {
            return new List<string> { "Dog", "Cat", "Mouse" };
        }

        protected override string FormatData(List<string> data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }

}
