using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqDemo linqDemo = new LinqDemo();
            linqDemo.Demo1();
            Console.WriteLine("------------------------------------------------");
            linqDemo.Demo2();
            Console.WriteLine("------------------------------------------------");
            linqDemo.Demo3();
            Console.WriteLine("------------------------------------------------");
            linqDemo.Demo4();
        }
    }
}
