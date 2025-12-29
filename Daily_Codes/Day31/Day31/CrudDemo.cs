using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day31
{
    internal class CrudDemo
    {
        PracticeDBEntities dc = new PracticeDBEntities();

        public void showallemployees()
        {
            var res = from t in dc.Employees select t;

            foreach (var e in res)
            {
                Console.WriteLine($"{e.EmpID}  {e.EmpName}  {e.DateOfJoin}  {e.Salary}  {e.DeptID}");
                Console.WriteLine("========================");
            }
        }

        public void SearchRecord()
        {
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();

            var res = from t in dc.Employees
                      where t.EmpName.Contains(name)
                      select t;

            foreach (var e in res)
            {
                Console.WriteLine($"{e.EmpID}  {e.EmpName}  {e.DateOfJoin}  {e.Salary}  {e.DeptID}");
                Console.WriteLine("========================");
            }
        }

        public void AddRecord()
        {
            Employee employee = new Employee() { EmpName = "Ajith", Salary = 45000, DateOfJoin = DateTime.Parse("1-1-2000"), DeptID = 10 };
            dc.Employees.Add(employee);

            int i = dc.SaveChanges();
            Console.WriteLine("Total Rows Inserted are " + i);
            Console.WriteLine("========================");
        }

        public void MatchingRecords()
        {
            var result = from e in dc.Employees
                         join d in dc.Departments on e.DeptID equals d.DeptID
                         select new { e.EmpID, e.EmpName, d.DeptID, d.DeptName };

            foreach (var e in result)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("========================");
        }

        public void DisplayDetails()
        {
            var result = from e in dc.Employees join d in dc.Departments on e.DeptID equals d.DeptID 
                         select new { e.EmpID, e.EmpName, d.DeptID, d.DeptName, e.Salary };

            foreach( var e in result)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("========================");
        }

        public void DOJFilter()
        {
            Console.WriteLine("Enter the Start Date : ");
            DateTime startDate = new DateTime();
            Console.WriteLine("Enter the End Date : ");
            DateTime endDate = new DateTime();
            startDate = DateTime.Parse(Console.ReadLine());
            endDate = DateTime.Parse(Console.ReadLine());

            var res = from e in dc.Employees where e.DateOfJoin >= startDate && e.DateOfJoin <= endDate select e;
            
            foreach( var e in res)
            {
                Console.WriteLine($"{e.EmpID}, {e.EmpName}");
            }
        }

        public void ApplyBonus()
        {
            var res = from e in dc.Employees select new { e.EmpName, Salary = e.Salary * 1.30m };
            
            foreach( var e in res)
            {
                Console.WriteLine(e);
            }
        }

        public void DynamicInsert()
        {
            string empName = Console.ReadLine();
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Employee employee = new Employee() { EmpName = "Ajith", Salary = 45000, DateOfJoin = DateTime.Parse("1-1-2000"), DeptID = 10 };
            dc.Employees.Add(employee);

            int i = dc.SaveChanges();
            Console.WriteLine("Total Rows Inserted are " + i);
            Console.WriteLine("========================");
        }

        public void SqlQueryDemo()
        {
            var res = dc.Database.SqlQuery<Employee>("select * from Employee where EmpName like 'W%'");
            foreach (var e in res)
            {
                Console.WriteLine($"{e.EmpID}  {e.EmpName}  {e.DateOfJoin}  {e.Salary}  {e.DeptID}");
                Console.WriteLine("========================");
            }
        }

        public void DMLDemo()
        {
            int ra = dc.Database.ExecuteSqlCommand("delete from Employee where EmpName like 'M%'");
            Console.WriteLine("Rows affected : " + ra);
        }

        public void SpDemo()
        {
        }
    }
}
