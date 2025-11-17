using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Day11ConsoleApp

{

    public delegate void PrintNumberDelegate(int Number);

    public delegate string GreetDelegate(string str);

    internal class DelegatemethodDemo

    {

        public static void Main(string[] args)

        {

            // singlecast delegate

            PrintNumberDelegate printNumberDelegate = PrintNumber;

            GreetDelegate greetdelegate = Greetmessage;

            printNumberDelegate(15000);

            printNumberDelegate(20000);

            // multicast delegate

            printNumberDelegate += Displaymessage;

            printNumberDelegate += ShowDate;

            Console.WriteLine(" \n\n Multicast delegate demo");

            printNumberDelegate(3000);


            //removing A method from the invocation list

            printNumberDelegate -= Displaymessage;

            Console.WriteLine("\n\n multicast delegate after removing after removing reference of message");

            printNumberDelegate(3000);

            Console.WriteLine(greetdelegate("logesh"));

            Console.ReadLine();

        }

        public static void PrintNumber(int Number)

        {

            Console.WriteLine("Number {0:c}", Number);

        }

        public static void Displaymessage(int customerId)

        {

            Console.WriteLine($"hello from {customerId}");

        }

        public static void ShowDate(int dummy)

        {

            Console.WriteLine(DateTime.Now.ToShortDateString());

        }

        public static string Greetmessage(string str)
        {

            return "hello" + str;

        }

    }

}

