using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ConsoleApp
{
    internal class StaticDemo
    {
        static int num = 10;
        int num1 = 20;

        public static void staticMethod()
        {
            num = 11;
            Console.WriteLine("Static Function : " + num);
            // To access non static variable into static function we need object for it.
            StaticDemo staticDemo = new StaticDemo();
            Console.WriteLine("Static Function calling non static variable: " + staticDemo.num1);

        }

        public void nonStaticMethod()
        {
            Console.WriteLine("Non Static Function : " + num1);
        }

    }
}
