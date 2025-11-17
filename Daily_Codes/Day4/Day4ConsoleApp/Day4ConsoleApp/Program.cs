using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Day4ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program program = new Program();
            //program.addition(); (OR)

            addition();
            addition2(50,50);
            int result = addition3(10, 100);
            Console.WriteLine(result);
            //calculation(100, 200, out int sum, out int diff, out int mult);
            //Console.WriteLine($"Addition : {sum} Difference : {diff} Product : {mult}");

            // out with discard
            calculation(100, 200, out int sum, out _, out _);
            Console.WriteLine($"Addition : {sum}");

            int a = 10;
            int b = 100;

            // Call by types
            CallTypes.methodValue(a);
            Console.WriteLine(a);
            CallTypes.methodRef(ref b);
            Console.WriteLine(b);

            // Params Keyword
            Console.WriteLine(ParamsDemo.add(10, 100, 200));
            Console.WriteLine(ParamsDemo.add(10, 100, 200, 300));

            // Static and Non Static Keyword
            StaticDemo.staticMethod();
            StaticDemo staticDemo = new StaticDemo();
            staticDemo.nonStaticMethod();

            // Constructors
            ConstructorDemo constructorDemo = new ConstructorDemo();
            constructorDemo.getDepartmentInfo();
            

            ConstructorDemo constructorDemo1 = new ConstructorDemo(12, "MECH", "Bangalore");
           

            ConstructorDemo constructorDemo2 = new ConstructorDemo(13, "CIRCUIT");
            

            ConstructorDemo constructorDemo3 = new ConstructorDemo(constructorDemo1);
            

            constructorDemo.displayDepartmentInfo();
            constructorDemo1.displayDepartmentInfo();
            constructorDemo2.displayDepartmentInfo();
            constructorDemo3.displayDepartmentInfo();
        }

        // Without return type and without argument
        static void addition()
        {
            int num1 = 10;
            int num2 = 20;
            int result = num1 + num2;
            Console.WriteLine("Addition : " + result);
        }

        // Without return type and with argument
        static void addition2(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition : " + result);
        }

        // With return type and with return type
        static int addition3(int num1, int num2)
        {
            return num1 + num2;
        }

        // out keyword
        static void calculation(int num1, int num2, out int sum, out int diff, out int mult)
        {
            sum = num1 + num2;
            diff = num1 - num2;
            mult = num1 * num2;
        }

    }
}
