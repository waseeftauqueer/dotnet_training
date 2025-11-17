using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11ConsoleApp
{
    internal class StackDemo
    {
        public static void StackOperations()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push("TEST");
            stack.Push(3.14);
            Console.WriteLine("Items in Stack : ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Top Item : " + stack.Peek());
            stack.Pop();

            Console.WriteLine("After Pop : ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Test : " + stack.Contains("TEST"));
            Console.WriteLine("Total Items : " + stack.Count);
            stack.Clear();
            Console.WriteLine("Total Items : " + stack.Count);
        }
    }
}
