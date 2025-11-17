using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day9ConsoleApp
{
    public class EmployeeDirectory
    {
        private string[] EmpNames = { "Waseef", "Sharuk", "Salman", "Aamir" };
        private int[] EmpId = { 101, 102, 103, 104 };

        public string this[int index]
        {
            get { return EmpNames[index]; }
            set { EmpNames[index] = value; }
        }
        public string this[string Empid]
        {
            get
            {
                for (int i = 0; i < EmpId.Length; i++)
                {
                    if (EmpId[i].ToString() == Empid)
                    {
                        return EmpNames[i];
                    }
                }
                return "Employee Not Found";
            }
        }   
    }
    internal class Program
    {
        public static void MethodDivide(){
            try
            {
                int x, y, z;
                Console.WriteLine("Enter the two numbers : ");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;
            }
            catch(DivideByZeroException e1)
            {
                throw new Exception("Exception occured while dividing by zero");
                throw e1;
            }
            catch(Exception e2)
            {
                throw new Exception(e2.Message);
            }
            finally { Console.WriteLine("End of the Program"); }
        }       
        static void Main(string[] args)
        {
            // Indexer Overloading
            EmployeeDirectory employeeDirectory = new EmployeeDirectory();
            Console.WriteLine(employeeDirectory[0]);
            Console.WriteLine(employeeDirectory[1]);
            Console.WriteLine(employeeDirectory[2]);
            employeeDirectory[3] = "Saif";
            Console.WriteLine(employeeDirectory["104"]);

            // Operator Overloading
            Complex c1 = new Complex(2, 3);
            Complex c2 = new Complex(2, 3);
            Complex sum = c1 + c2;
            Console.WriteLine(c1==c2);
            Console.WriteLine(sum.Real);
            Console.WriteLine(sum.Imaginary);
            Console.WriteLine(sum.LastOperator);
            Console.WriteLine(sum.ToString());
            Console.WriteLine(c1.Equals(c2));

            // Exception Handling
            try
            {
                MethodDivide();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

}