using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        public ActionResult Index()
        {
            List<Department> dList = new List<Department>()
            {
                new Department{ Id= 1, DeptName="CSE"},
                new Department{Id=2, DeptName="ECE"},
                new Department{ Id= 3, DeptName="IT"},
                new Department{Id=4, DeptName="EEE"},
            };
            return View("DepartmentList", dList);
        }

        public ActionResult DepartmentList(List<Department> d)
        {
            return View(d);
        }

        public ActionResult DisplayEmployee()
        {
            Employee employee = new Employee() {ID=1, Name="Rahul",Age=21 };
            return View(employee);  //passing a model object of type Employee
        }

        public ActionResult EmployeeList()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{ID= 10, Name="Waseef", Age=21},
                new Employee{ID=11, Name="Tauqueer",Age=20},
                new Employee {ID=12, Name="Logesh",Age=21}
            };
            return View(emplist);
        }

        [ActionName("Test")]
        public ActionResult DifferentViewName()
        {
            ViewBag.sample = "This is A Different View";
            //return View("DifferentViewName");
            return View();
        }
    }
}