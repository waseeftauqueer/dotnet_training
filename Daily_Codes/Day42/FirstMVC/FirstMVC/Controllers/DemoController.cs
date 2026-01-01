using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public string NormalMethod()
        {
            return "HI USER, YOU HAVE BEEN HACKED";
        }

        public ViewResult ViewMethod()
        {
            return View();
        }

        public ContentResult ContentMethod()
        {
            return Content("<h1 style=color:blue;> GOOD BYE</h1>");
        }

        public EmptyResult EmptyMethod()
        {
            int amt = 45000;
            float si = (amt * 3 * 2) / 100;
            return new EmptyResult();
        }

        public ActionResult redirectMethod()
        {
            //return RedirectToAction("ContentMethod");

            return RedirectToAction("index", "home");
        }

    }
}