using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Rectangle r = new Rectangle(5.0, 4.0);
            double area = r.GetArea();
            Console.WriteLine("Area of rectangle : " + area);

            Console.WriteLine("*******************Enum Output******************");
            EnumExample.EnumOps();
            Console.Read();
        }
    }
}
