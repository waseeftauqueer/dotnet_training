using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ConsoleApp
{
    internal class ConstructorDemo
    {
        int departmentId;
        string departmentName, departmentLocation;

        // Static Consturctor
        static ConstructorDemo()
        {
            Console.WriteLine("This is a Static Constructor");
        }

        // Default or Parameter less Constructor
        public ConstructorDemo()
        {
            departmentId = 0;
            departmentName = "Not Specified";
            departmentLocation = "Not Specified";
        }

        // Parametrized Constructor
        public ConstructorDemo(int departmentId, string departmentName, string departmentLocation)
        {
            this.departmentId = departmentId;
            this.departmentName = departmentName;
            this.departmentLocation = departmentLocation;
        }


        public ConstructorDemo(int departmentId, string departmentName)
        {
            this.departmentId= departmentId;
            this.departmentName= departmentName;
        }

        // Copy Constructor
        public ConstructorDemo(ConstructorDemo constructorDemo)
        {
            this.departmentId = constructorDemo.departmentId;
            this.departmentName = constructorDemo.departmentName;
            this.departmentLocation = constructorDemo.departmentLocation;
        }

        public void getDepartmentInfo()
        {
            Console.WriteLine("Enter Department Id : \n");
            departmentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Department Name : \n");
            departmentName = Console.ReadLine();
            Console.WriteLine("Enter Department Location : \n");
            departmentLocation = Console.ReadLine();
        }

        public void displayDepartmentInfo()
        {
            Console.WriteLine(" Department ID : " + departmentId);
            Console.WriteLine(" Department Name : " + departmentName);
            Console.WriteLine(" Department Location : " + departmentLocation);


        }
    }
}
