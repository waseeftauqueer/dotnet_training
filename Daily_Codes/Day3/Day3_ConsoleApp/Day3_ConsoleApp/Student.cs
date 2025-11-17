using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_ConsoleApp
{
    internal class Student
    {
        private string studentName;
        private int[] subjectMarks;

        public void SetValues(string studentName, int[] subjectMarks)
        {
            this.studentName = studentName;
            this.subjectMarks = subjectMarks;
        }

        public void calculateResult(out int totalMarks, out int average, out string grade)
        {
            totalMarks = subjectMarks.Sum();
            average = totalMarks / 3;
            if (average >= 90)
                grade = "A+";
            else if (average >= 80)
                grade = "A";
            else if (average >= 70)
                grade = "B";
            else if (average >= 60)
                grade = "C";
            else if (average >= 50)
                grade = "D";
            else
                grade = "Fail";
        }

        public void displayResult(int totalMarks, int average, string grade)
        {
            Console.WriteLine($"\n Name : {studentName}\n");
            Console.WriteLine($"\n Total Marks : {totalMarks}\n");
            Console.WriteLine($"\n Average : {average}\n");
            Console.WriteLine($"\n Grade : {grade}\n");
        }
    }
}
