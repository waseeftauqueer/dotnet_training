using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Struct
{
    enum clubs { RealMadrid=1, Barcelona=0, Athletic=2, Atletico=4}
    internal class EnumExample
    {
        public static void EnumOps()
        {
            Console.WriteLine("Enums");
            foreach(int i in Enum.GetValues(typeof(clubs)))
            {
                Console.WriteLine(i);
            }
            foreach (var x in Enum.GetNames(typeof(clubs)))
            {
                Console.WriteLine(x);
            }
        }
    }
}
