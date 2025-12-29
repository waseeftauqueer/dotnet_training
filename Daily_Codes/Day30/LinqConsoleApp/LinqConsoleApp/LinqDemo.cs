using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LinqConsoleApp
{
    internal class LinqDemo
    {
        List<EmpDept> employees = new List<EmpDept>
        {
            new EmpDept { EmpId = 1, EmpName = "Aasritha", Salary = 30000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 2 },
            new EmpDept { EmpId = 2, EmpName = "Akshay", Salary = 32000, DateOfJoin = DateTime.Now.AddYears(-2), DeptId = 2 },
            new EmpDept { EmpId = 3, EmpName = "Anvith Reddy", Salary = 35000, DateOfJoin = DateTime.Now.AddMonths(-10), DeptId = 3 },
            new EmpDept { EmpId = 4, EmpName = "ASHOK", Salary = 28000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 1 },
            new EmpDept { EmpId = 5, EmpName = "Deepalakshmi", Salary = 36000, DateOfJoin = DateTime.Now.AddMonths(-6), DeptId = 4 },
            new EmpDept { EmpId = 6, EmpName = "Deepti", Salary = 36000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 4 },
            new EmpDept { EmpId = 7, EmpName = "Dharani sri", Salary = 30000, DateOfJoin = DateTime.Now.AddYears(-3), DeptId = 1 },
            new EmpDept { EmpId = 8, EmpName = "Humera", Salary = 33000, DateOfJoin = DateTime.Now.AddMonths(-8), DeptId = 2 },
            new EmpDept { EmpId = 9, EmpName = "Kanishka", Salary = 31000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 3 },
            new EmpDept { EmpId = 10, EmpName = "KEERTHANA", Salary = 30000, DateOfJoin = DateTime.Now.AddMonths(-4), DeptId = 4 },
            new EmpDept { EmpId = 11, EmpName = "Keerthi", Salary = 35000, DateOfJoin = DateTime.Now.AddMonths(-5), DeptId = 2 },
            new EmpDept { EmpId = 12, EmpName = "Keerthickragul", Salary = 36000, DateOfJoin = DateTime.Now.AddYears(-2), DeptId = 3 },
            new EmpDept { EmpId = 13, EmpName = "Logeshwaran", Salary = 28000, DateOfJoin = DateTime.Now.AddMonths(-9), DeptId = 1 },
            new EmpDept { EmpId = 14, EmpName = "Madavi", Salary = 30000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 1 },
            new EmpDept { EmpId = 15, EmpName = "Manikanta", Salary = 31000, DateOfJoin = DateTime.Now.AddMonths(-7), DeptId = 2 },
            new EmpDept { EmpId = 16, EmpName = "Fatima", Salary = 29000, DateOfJoin = DateTime.Now.AddYears(-3), DeptId = 3 },
            new EmpDept { EmpId = 17, EmpName = "Nagamani", Salary = 35000, DateOfJoin = DateTime.Now.AddMonths(-6), DeptId = 2 },
            new EmpDept { EmpId = 18, EmpName = "Pooja", Salary = 30000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 4 },
            new EmpDept { EmpId = 19, EmpName = "Hymavathi", Salary = 32000, DateOfJoin = DateTime.Now.AddYears(-2), DeptId = 1 },
            new EmpDept { EmpId = 20, EmpName = "Sairam Somaraju", Salary = 40000, DateOfJoin = DateTime.Now.AddMonths(-9), DeptId = 4 },
            new EmpDept { EmpId = 21, EmpName = "Sakthivel", Salary = 31000, DateOfJoin = DateTime.Now.AddMonths(-10), DeptId = 2 },
            new EmpDept { EmpId = 22, EmpName = "Usha sri", Salary = 29000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 3 },
            new EmpDept { EmpId = 23, EmpName = "Waseef", Salary = 36000, DateOfJoin = DateTime.Now.AddMonths(-3), DeptId = 1 }
        };

        public void Demo1()
        {
            string[] studentnames = { "Ashritha", "deepa", "Ashok", "sai", "kanishka", "Anvith" };

            var res = from t in studentnames where t.StartsWith("A") || t.Length == 3 select t;

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        public void Demo2()
        {
            int[] numbers = { 10, 11, 12, 13, 14, 15, 16 };

            var res = from i in numbers where i % 2 == 0 && i > 12 select i;

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        public void Demo3()
        {
            //write a linq query to display all details where name contains a 'K' 

            var res1 = from t in employees where t.EmpName.Contains("K") select t;

            // write a linq query to display all empid between 8  23 and sort names in descending order

            var res2 = from t in employees  where t.EmpId >8 && t.EmpId <=23 orderby t.EmpName descending  select t;

            // write a linq query to show only empid , empname, deptid


            var res3 = from t in employees select new {Employeeid= t.EmpId,Employeename = t.EmpName, departmentid = t.DeptId};

            foreach (var item in res3)
            {
                Console.WriteLine($"{item.Employeeid}  {item.Employeename}   {item.departmentid}");
            }

            var res4 = (from t in employees select t).ToList();


            employees.Add(new EmpDept { EmpId = 9, EmpName = "Kanishka", Salary = 31000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 3 });
            employees.Add(new EmpDept { EmpId = 20, EmpName = "Sairam Somaraju", Salary = 40000, DateOfJoin = DateTime.Now.AddMonths(-9), DeptId = 4 });


            foreach (var item in res4)
            {
                Console.WriteLine($"{item.EmpId}  {item.EmpName}   {item.Salary}  {item.DateOfJoin}  {item.DeptId}");
            }

            //===================================================================

            List<Dept> departments = new List<Dept>
             {
                 new Dept { DeptId = 1, DeptName = "HR" },
                 new Dept { DeptId = 2, DeptName = "IT" },
                 new Dept { DeptId = 3, DeptName = "Finance" },
                 new Dept { DeptId = 4, DeptName = "Training" }
             };

            // show me common records from both the table

            var res5 = from t in employees
                      from t1 in departments
                      where t.DeptId == t1.DeptId
                      select new { t.EmpId, t.DeptId, t.EmpName, t.Salary, t1.DeptName };


            var res6 = from t in employees
                      join t1 in departments
                      on t.DeptId equals t1.DeptId
                      select new { t.EmpId, t.DeptId, t.EmpName, t.Salary, t1.DeptName };



            foreach (var item in res6)// linq query is executed here
            {
                Console.WriteLine($"{item.EmpId}  {item.EmpName}   {item.Salary}  {item.DeptId}  {item.DeptName}");
            }

        }
        public void Demo4()
        {
            //how lambda works?


            // query expression method 
            var res1 = from t in employees where t.DeptId == 1 select t;


            // lambda expression method
            var res2 = employees.Where(t => t.DeptId == 1);

            //=====================================================================================
            // most commonly used methods

            // take , skip , takewhile, skipwhile, order by , orderbydescending, thenby,thenbydecending

            var res3 = employees.Take(3);// display top 3 records

            var res4 = employees.Skip(3);//skips 1st 3 rows


            var res5 = employees.TakeWhile(t => t.Salary != 31000);

            var res6 = employees.SkipWhile(t => t.Salary != 31000);

            // supports chaning model


            // every method output will go as an input for next method
            var res7 = employees.Take(8).Skip(8).TakeWhile(t => t.Salary > 20000);

            var res8 = employees.OrderByDescending(t => t.Salary).Take(4).Skip(1);


            var res = employees.OrderByDescending(t => t.Salary).Skip(1).Take(3);


            foreach (var item in res)// linq query is executed here
            {
                Console.WriteLine($"{item.EmpId}  {item.EmpName}   {item.Salary}  {item.DateOfJoin} {item.DeptId}");
            }
        }


    }
}
