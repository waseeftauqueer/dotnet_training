using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class DataController : Controller
    {
        //===========================================================
        // 1. Passing an object to the view as a Model
        //===========================================================
        public ActionResult Index()
        {
            // Example: accessing TempData from previous request
            List<string> stlist = TempData["stores"] as List<string>;

            // Option 1: pass model to current view
            // return View(stlist);

            // Option 2: redirect to another controller to see TempData across controllers
            return RedirectToAction("Test_TempData_across_controllers", "Demo");
        }

        //===========================================================
        // 2. Checking if ViewBag/ViewData can pass data to further requests
        //===========================================================
        public ActionResult TestDataTransfer()
        {
            // ViewBag and ViewData are only available in the current request
            ViewBag.data1 = "Data One";
            ViewData["data2"] = "Data Two";

            // Data is passed to the current view
            return View();

            // ❌ Not available after redirect
            // return RedirectToAction("Index");
        }

        //===========================================================
        // 3. Passing data via ViewBag and ViewData
        //===========================================================
        public ActionResult OfficeRules()
        {
            List<string> rules = new List<string>
            {
                "Be on Time",
                "Carry your ID card",
                "Complete work as per deadlines",
                "Avoid T-Shirts"
            };

            // 3.1 Transfer data via ViewBag
            ViewBag.offrules = rules;

            // 3.2 Transfer data via ViewData
            ViewData["or"] = rules;

            // Pass data to the current view
            // return View();

            // Redirecting loses ViewBag/ViewData, so data won't be available after redirect
            return RedirectToAction("TestDataTransfer");
        }

        //===========================================================
        // 4. Passing data via TempData
        //===========================================================
        public ActionResult FirstTempRequest()
        {
            List<string> stationeries = new List<string>
            {
                "Pens",
                "Pencils",
                "NoteBooks",
                "Markers",
                "Erasers"
            };

            // TempData survives one redirect
            TempData["stores"] = stationeries;

            // Option 1: use TempData in current view
            // return View();

            // Option 2: redirect to another action to see TempData
            return RedirectToAction("SecondTempRequest");
        }

        public ActionResult SecondTempRequest()
        {
            // TempData is still available here
            // List<string> stnlist = TempData["stores"] as List<string>;
            // return View(stnlist);

            // Redirecting to Index (TempData still survives this one request)
            return RedirectToAction("Index");
        }
    }
}
