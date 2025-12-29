using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFIrstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CrudDemo crudDemo = new CrudDemo();
            //crudDemo.Insert();
            //crudDemo.Display();

            CrudDemo2 crudDemo2 = new CrudDemo2();
            crudDemo2.InsertNewStudents();
        }
    }
}
