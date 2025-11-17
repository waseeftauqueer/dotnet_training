using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11ConsoleApp
{
    internal class ActionDelegateDemo
    {
        public delegate void Printdelegate(int num);
        public delegate void greetmessage(string name);
        internal class Actiondelegate
        {
            public static void Main(string[] args)
            {
                //EXAMPLE FOR ACTION DELEGATE
                Printdelegate printdel = ConsolePrint;
                printdel(100);

                //Action delegate example 2
                Action<int> printAction = ConsolePrint;
                printAction(200);


                //Action delegate with anonymous method
                Action<string> greet = delegate (string name)
                {
                    Console.WriteLine("Hello from anonymous method" + name);
                };

                greet("Bob");

                Console.ReadLine();
            }

            public static void ConsolePrint(int i)
            {
                Console.WriteLine("ConsolePrint function" + i);
            }
            public static void greetmessage(string name)
            {
                Console.WriteLine("hello" + name);
            }
        }
    }
}
