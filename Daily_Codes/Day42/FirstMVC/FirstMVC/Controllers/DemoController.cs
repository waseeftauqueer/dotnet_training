using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class DemoController : Controller
    {
        //===========================================================
        // 1. Default GET action
        //===========================================================
        public ActionResult Index()
        {
            return View();
        }

        //===========================================================
        // 2. Returning a simple string
        //===========================================================
        public string NormalMethod()
        {
            // Returns plain text, not a view
            return "HI USER, YOU HAVE BEEN HACKED";
        }

        //===========================================================
        // 3. Returning a ViewResult
        //===========================================================
        public ViewResult ViewMethod()
        {
            // Returns a view named "ViewMethod" (or default view for this action)
            return View();
        }

        //===========================================================
        // 4. Returning raw HTML content
        //===========================================================
        public ContentResult ContentMethod()
        {
            return Content("<h1 style='color:blue;'>GOOD BYE</h1>");
        }

        //===========================================================
        // 5. Returning an empty response
        //===========================================================
        public EmptyResult EmptyMethod()
        {
            int amt = 45000;
            float si = (amt * 3 * 2) / 100;

            // Nothing is returned to the browser
            return new EmptyResult();
        }

        //===========================================================
        // 6. Redirecting to another action/controller
        //===========================================================
        public ActionResult RedirectMethod()
        {
            // Redirect to an action in the same controller
            // return RedirectToAction("ContentMethod");

            // Redirect to an action in a different controller
            return RedirectToAction("Index", "Home");
        }

        //===========================================================
        // 7. Accessing TempData across controllers
        //===========================================================
        public ActionResult Test_TempData_across_controllers()
        {
            // Keep TempData for subsequent requests
            TempData.Keep();

            // Pass TempData["stores"] to the view
            return View(TempData["stores"]);
        }

        //===========================================================
        // 8. Checking TempData persistence across multiple requests
        //===========================================================
        public ActionResult CheckTempData()
        {
            // Keep TempData for future requests
            TempData.Keep();

            // Display TempData["stores"] in the view
            return View(TempData["stores"]);
        }
    }
}
