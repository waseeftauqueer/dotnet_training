using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_ConsoleApp
{
    internal class StudentMarkEvaluator
    {
        private string studentName;
        private int[] subjectMarks;
        private int totalMarks;
        private int average;
        private string grade;
       

        public void SetValues(string studentName, int[] subjectMarks)
        {
            this.studentName = studentName;
            this.subjectMarks = subjectMarks;
        }

        public void totalMarksCalc()
        {
            for (int i = 0; i < subjectMarks.Length; i++)
            {
                this.totalMarks += subjectMarks[i];
            }
        }

        public void averageCalc()
        {
            this.average = totalMarks / 3;  
        }

        public void GradeCalc()
        {
            if (this.average >= 90)
                this.grade = "A+";
            else if (this.average >= 80)
                this.grade = "A";
            else if (this.average >= 70)
                this.grade = "B";
            else if (this.average >= 60)
                this.grade = "C";
            else if (this.average >= 50)
                this.grade = "D";
            else
                this.grade = "Fail";
        }


        public void calculateResult()
        {

            totalMarksCalc();
            averageCalc();
            GradeCalc();
        }

        public void displayResult()
        {
            Console.WriteLine($"\n Name : {studentName}\n");
            Console.WriteLine($"\n Total Marks : {totalMarks}\n");
            Console.WriteLine($"\n Average : {average}\n");
            Console.WriteLine($"\n Grade : {grade}\n");
        }
    }
}
