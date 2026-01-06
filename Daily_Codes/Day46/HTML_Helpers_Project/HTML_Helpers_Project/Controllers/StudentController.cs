using HTML_Helpers_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_Helpers_Project.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Strongly_Typed_Helper()
        {
            return View();
        }

        public ActionResult Templated_Helper_Indu()
        {
            return View();
        }

        //3. templated helper for the entire model (editor template)
        public ActionResult TemplateForModel()
        {
            return View();
        }

        //4. Display template
        public ActionResult StudentDisplay()
        {
            Students student = new Students()
            {
                RNO = 10,
                Name = "Rahul",
                Address = "Chennai",
            };
            ViewData["stddata"] = student;
            return View(student);
        }
        //5. standard helper
        public ActionResult StandardHelper()
        {
            return View();
        }
    }
}