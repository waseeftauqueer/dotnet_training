using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Assignemnts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1
            Student s1 = new Student();
            s1.Name = "John";
            s1.Age = 20;
            s1.DisplayDetails();


            // Assignment 2
            string str1 = "HELLO";
            string str2 = "Hello";

            Console.WriteLine(str1.IsUpper());
            Console.WriteLine(str2.IsUpper());

            // Assignment 4
            List<int> nums = new List<int> { 2, 3, 4 };
            Console.WriteLine(nums.SumOfSquares());

            // Task Assignment
            Task task1 = Task.Run(() =>
            {
                for (int i = 1; i <= 5; i++)
                    Console.WriteLine(i);
            });

            Task task2 = Task.Run(() =>
            {
                for (int i = 6; i <= 10; i++)
                    Console.WriteLine(i);
            });

            Task task3 = Task.Run(() =>
            {
                Console.WriteLine("All numbers printed!");
            });

            Task.WaitAll(task1, task2, task3);

            Console.WriteLine("Done");

            // Random Integers Assignment
            Task<int> t1 = Task.Run(new Func<int>(GetRandomNumber));
            Task<int> t2 = Task.Run(new Func<int>(GetRandomNumber));
            Task<int> t3 = Task.Run(new Func<int>(GetRandomNumber));

            Task<int[]> all = Task.WhenAll(t1, t2, t3);

            all.ContinueWith(t =>
            {
                int sum = 0;
                foreach (int n in t.Result)
                    sum += n;

                Console.WriteLine("Sum = " + sum);
            }).Wait();

            int GetRandomNumber()
            {
                Random rnd = new Random(Guid.NewGuid().GetHashCode());
                return rnd.Next(1, 100);
            }

            // Factorial Task Assignment
            int number = 5;

            Task<int> factorialTask = Task.Run(() => Factorial(number));

            int result = factorialTask.Result;

            Console.WriteLine("Factorial of " + number + " = " + result);

            int Factorial(int n)
            {
                int results = 1;

                for (int i = 2; i <= n; i++)
                    results *= i;

                return results;
            }
        }
    }
}
/* internal class Features
    {
        // features ...net 2.0 3.0 3.5 4x...
        public void NullableDemo()
        {
            // feature : working with null
            // nullable types are achived using ? symbol
            // very widely used in database programming

            string name = null; // valid
            int? age = 21; // not valid

            if(age.HasValue)
            {
                // print this if its not null
                Console.WriteLine(age.Value);

            }
            else
            {// prints this if its null
                Console.WriteLine("age is null");
            }



        }


        public void GlobalNsDemo()
        {
            // feature : working with namespaces
            // how do u call hi method?
            // using global namespace u can call the class
            // which is present in outside the current namespace
            c1 ob  = new c1();
            ob.Display();

            // search outside the namespace
            global::c1 ob2 = new global::c1();
            ob2.Hi();

        }

        public void inlinedemo()
        {
            // feature : working with warning message
            // how do i remove warning message?
#pragma warning disable // warning is disabled
            int x;
            int y;
#pragma warning restore // warning is restored
            int z;


        }
        public void ExtensionDemo()
        {
            // feature : creating custom method to built in types

            // string s = "Hello";
            // does it starts with h or not?
            // is it in uppercase or not?

            // condition : 1. class and method is static
            //             2. method has to take atleast 1 parameter
            int x = 11;          
            Console.WriteLine(x.IsEven()) ;

        }


        public void propertyDemo()
        {
            // feature: best way to initialize property
            // object initializer
            students s1 = new students() 
            {
                studentid = 100,
                studentname = "Deepa", 
                TotalMarks = 90
            };

            Console.WriteLine($"{s1.studentid} {s1.studentname}  {s1.TotalMarks}");

        }

        public void PartialDemo()
        {

            // features :  how to keep methods in sepereate files?
            //benefit:
            //team members can work simultenosly with there respective files
          


        }
        public void CollectionDemo()
        {
            // feature: easy and best way to initialise List

            //List<students> s1 = new List<students>();
            //students ob1 = new students();
            //ob1.studentid = 100;
            //ob1.studentname = "Ravi";
            //ob1.TotalMarks = 78;

            //students ob2 = new students();
            //ob2.studentid = 200;
            //ob2.studentname = "Pooja";
            //ob2.TotalMarks = 80;

            //students ob3 = new students()
            //{
            //    studentid = 300,
            //    studentname = "Deepa",
            //    TotalMarks = 90
            //};

            //s1.Add( ob1 );
            //s1.Add( ob2 );
            //s1.Add(ob3);
            //s1.Add(new students() { studentid=400, studentname="Karthik" , TotalMarks=93 });


            // collection initializer

            List<students> s1 = new List<students>()
            {
                new students() { studentid=100, studentname="Karthik" , TotalMarks=93 },
                new students() { studentid=200, studentname="Deepa" , TotalMarks=95 },
                new students() { studentid=300, studentname="Pooja" , TotalMarks=90 },
                new students() { studentid=400, studentname="Ravi" , TotalMarks=96 },
              };
            foreach (var item in s1)
            {
                Console.WriteLine($"{item.studentid} {item.studentname}  {item.TotalMarks}");
            }




        }

    }


   static class myclass
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
           
        }

    }

    class students
    {
        public int studentid { get; set; }
        public string studentname { get; set; }
        public int TotalMarks { get; set; }


    }











    public class c1
    {
        public void Display()
        {
            

            Console.WriteLine("Display called");
        }
    }

}


    public class c1
    {
        public void Hi()
        {
            Console.WriteLine("Hi called");
        }
    }



==============================================================




    internal class Features6
    {

        public void staticdemo()
        {
            // feature : how to avoid Console class every time
            // how do u print hello world?

            WriteLine("Hello world");
            WriteLine("Hi Students how r u all");

            // how do u find sqrt?
            var res = Sqrt(100);
            WriteLine(res);

        }

        public void autoinitdemo()
        {
            // feature : how to initialize property without constructor

            employee e = new employee();
            WriteLine(e.empid);
            WriteLine(e.empname);


        }


        public void dictionaryinitdemo()
        {
            // Feature: how to add values to dictionary without add method
            // Dictionary initializer
            Dictionary<int, string> dc = new Dictionary<int, string>()
            {
                [100] = "india",
                [200] = "Canada",
                [300] = "UK",
            };

            foreach (var item in dc)
            {
                WriteLine($"{item.Key}  {item.Value}");
            }

        }

        public void Hi()
        {

        }
        public void nameofdemo()
        {
            // Feature : how do u print function name as it is?
            // we wanted function name for logging features
            WriteLine(nameof(Hi));


        }

        public void ExceptionFilters()
        {
            // Features : working with multiple catch blocks
            // in previous version u can  declare exception only once
            // based on the message call the correponding catch block
            // we oftenly use this feature when working with custom exceptions

            try
            {
                throw new Exception("Major");
            }
            catch (Exception ex) when (ex.Message == "Minor")
            {
                Console.WriteLine("Minor Error Occured.");
            }
            catch (Exception ex) when (ex.Message == "Major")
            {
                Console.WriteLine("Major Error Occured");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception.");
            }

        }


        public void conditionalnull()
        {
            //feature : how do u avoid null error or uninitialised object 
            employee e = null; // u have not initialised
          
                WriteLine(e?.empid); // print the value only if it is initialized
                WriteLine(e?.empname);
          
        }

        // feature : how to print value in single line(without brackets) 
        public void Expressionbody() => WriteLine("Hello students how r u all");



   
        class employee
        {
            // we use constructors to assing the default values
            //public employee()
            //{
            //    empid = 100;
            //    empname = "Infinity";
            //}

            // auto initializer property(constructor not required)
            public int empid { get; set; } = 100;
            public string empname { get; set; } = "Infinity";
        }
    }
}







*/