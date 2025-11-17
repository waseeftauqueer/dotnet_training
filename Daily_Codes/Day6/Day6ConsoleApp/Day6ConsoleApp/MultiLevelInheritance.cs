using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day6ConsoleApp
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("This is Person Constructor");
        }
        public string Name;
        public void showName() { Console.WriteLine("Name : " + Name); }
    }

    public class Teacher : Person
    {
        public Teacher()
        {
            Console.WriteLine("This is Teacher Constructor");
        }
        public string Course;
        public void showCourse() { Console.WriteLine($"Name : {Name}, Course : {Course}"); }
    }

    public class Professor : Teacher
    {
        public Professor()
        {
            Console.WriteLine("This is Professor Constructor");
        }
        public void ConductResearch() { Console.WriteLine($"{Name} conducting research on {Course}"); }
    }

    internal class MultiLevelInheritance
    {
        
        
        
    }
}
