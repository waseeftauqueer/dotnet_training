using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Day3_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array declaration and initialization
            int[] numArray = new int[5] { 1, 2, 3, 4, 5 };

            // array declaration
            int[] array = new int[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;

            // array declaration and input
            int arrayLen;
            Console.WriteLine("\nEnter your array size : \n");
            arrayLen = Convert.ToInt32(Console.ReadLine());

            int[] inputArray = new int[arrayLen];
            for (int i = 0; i < arrayLen; i++)
            {
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe Array Elements Are : \n");
            foreach (int i in inputArray)
            {
                Console.WriteLine(i);
            }

            // 2D Array declaration and initialization
            int[,] twoDArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    Console.Write(" " + twoDArray[i, j]);
                }
            }

            //2D Array declaratin and input
            int student, subject;
            Console.WriteLine("\nEnter the number of students and subjects : \n");
            student = Convert.ToInt32(Console.ReadLine());
            subject = Convert.ToInt32(Console.ReadLine());

            int[,] studentMarks = new int[student, subject];
            Console.WriteLine("\nEnter the Marks : \n");
            for (int i = 0; i < student; i++)
            {
                for (int j = 0; j < subject; j++)
                {
                    studentMarks[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < student; i++)
            {
                Console.WriteLine($"\n Student {i} marks are : \n");
                for (int j = 0; j < subject; j++)
                {
                    Console.Write(" " + studentMarks[i, j]);
                }
            }

            // total marks calculation for students
            int[] totalMarks = new int[student];
            int temp = 0;

            // Storing total in array
            for (int i = 0; i < student; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < subject; j++)
                {
                    temp += studentMarks[i, j];
                }
                totalMarks[i] = temp;
                temp = 0;
            }

            for (int i = 0; i < student; i++)
            {
                Console.WriteLine($"\nStudent {i} total is : " + totalMarks[i]);
                Console.WriteLine();
            }

            // Printing without storing
            for (int i = 0; i < student; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < subject; j++)
                {
                    Console.Write(" " + studentMarks[i, j]);
                    temp += studentMarks[i, j];
                }
                Console.WriteLine($"\nStudent {i} total is : " + temp);
                temp = 0;
            }

            // Array Reversal
            Array.Reverse(inputArray);
            Console.WriteLine("\nReversed Array : \n");
            foreach (int i in inputArray)
            {
                Console.Write(i + "\t");
            }

            // 2D Array Reversal


            // Jagged Array - An array within an array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[2] { 1, 2 };
            jaggedArray[1] = new int[3] { 3, 4, 5 };
            jaggedArray[2] = new int[4] { 4, 5, 6, 7 };

            Console.WriteLine("\nJagged Array Output : \n");
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(" " + jaggedArray[i][j]);
                }
            }

            // Jagged Array - String
            string[][] jaggedString = new string[3][]
            {
                new string[] { "Waseef", "Logesh" },
                new string[] { "Chiru", "Salman", "Sharuk" },
                new string[] { "Amir", "Tiger", "Akshay", "Karthik" }
            };

            for (int i = 0; i < jaggedString.GetLength(0); i++)
            {
                Console.WriteLine("Name List {0} : ", i + 1);
                for (int j = 0; j < jaggedString[i].Length; j++)
                {
                    Console.Write(" " + jaggedString[i][j]);
                }
                Console.WriteLine();
            }

            // Class creation and function call
            Calculator calculator = new Calculator();
            int num1, num2;
            Console.WriteLine("\nEnter the num1 \n");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the num2 \n");
            num2 = Convert.ToInt32(Console.ReadLine());

            calculator.addNumber(num1, num2);
            calculator.subtractNumber(num1, num2);
            int multipliedResult = calculator.multiplyNumber(num1, num2);
            Console.WriteLine(multipliedResult);

            calculator.calculate(num1, num2, out int addResult, out int subResult, out int multiResult);
            Console.WriteLine(addResult + " " + subResult + " " + multiResult);


            // Students Mark Evaluation
            int totalStudents;
            Console.WriteLine("\n Enter the number of Students : \n");
            totalStudents = Convert.ToInt32(Console.ReadLine());

            string studentName;
            int[] subjectMarks = new int[3];

            while (totalStudents > 0)
            {
                Console.WriteLine("\n Enter Student Name : \n");
                studentName = Console.ReadLine();

                for (int i = 0; i < subjectMarks.Length; i++)
                {
                    Console.WriteLine($"\nEnter marks for Subject {i + 1} : \n");
                    subjectMarks[i] = Convert.ToInt32(Console.ReadLine());
                }

                StudentMarkEvaluator studentMarkEvaluator = new StudentMarkEvaluator();

                studentMarkEvaluator.SetValues(studentName, subjectMarks);
                studentMarkEvaluator.calculateResult();
                studentMarkEvaluator.displayResult();

                totalStudents--;
            }
        }
    }
}
