using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6ConsoleApp
{
    class studentMarks
    {
        private int[] marks = new int[5];
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > marks.Length)
                {
                    Console.WriteLine("Invalid index returning -1");
                    return -1;
                }
                return marks[index];
            }
            set
            {
                if (index < 0 || index > marks.Length)
                {
                    Console.WriteLine("Invalid index, Cannot set value");
                }
                marks[index] = value;
            }
        }

        public void displayMarks()
        {
            Console.WriteLine("Marks of Students : ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }

        }
    }

internal class Program
{
     static void Main(string[] args)
            {
                studentMarks studentMarks = new studentMarks();
                studentMarks[0] = 85;
                studentMarks[1] = 85;
                studentMarks[2] = 85;
                studentMarks[3] = 85;
                studentMarks[4] = 85;

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(studentMarks[i]);
                }
                studentMarks.displayMarks();

                EmployeeList employeeList = new EmployeeList();

                Console.WriteLine(employeeList[1]);
                employeeList[1] = "Joe Rogan";
                Console.WriteLine(employeeList[2]);

                employeeList["Female"] = 100;
                Console.WriteLine(employeeList["Female"]);

            Professor professor = new Professor() { Name = "Logesh" , Course = "FSD"};
            professor.Name = "Waseef";
            professor.Course = "AWS";
            professor.showName();
            professor.showCourse();
            professor.ConductResearch();

            Customers customer = new Customers();
            customer.GetProductInfo();
            customer.DisplayProductInfo();

            }
        }


    
}