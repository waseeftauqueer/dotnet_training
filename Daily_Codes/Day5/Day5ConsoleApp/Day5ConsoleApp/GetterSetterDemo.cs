using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ConsoleApp
{
    internal class GetterSetterDemo
    {
        private int studentId;
        private string studentName;
        private int studentAge;
        private string studentPassword;

        public int StudentId
        {
            get { return studentId; } set { studentId = value; }
        }

        public string StudentName
        {
            get { return studentName; } set { studentName = value; }
        }

        public int StudentAge
        {
            get { return studentAge; } 
            set { if (value < 120) { studentAge = value; } else { throw new Exception("Age should be between 0-120"); } }
        }

        public string StudentPassword
        {
            get { return studentPassword; } set { studentPassword = value; }
        }

    }
}
