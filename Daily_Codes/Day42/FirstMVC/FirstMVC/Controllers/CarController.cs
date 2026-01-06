using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            
            return View();
        }
        [ActionName ("bag")]
        public ActionResult ViewBagResult()
        {
            List<Car> cars = new List<Car>()
            {
                new Car{Id = 1, Name = "MERCEDES"},
                new Car{Id = 2, Name = "BENETLY"},
                new Car{Id = 3, Name = "ASTON MARTIN"}
            };
            ViewBag.Cars = cars;
            return View();
        }
        [ActionName("data")]
        public ActionResult ViewDataResult()
        {
            List<Car> cars = new List<Car>()
            {
                new Car{Id = 1, Name = "MERCEDES"},
                new Car{Id = 2, Name = "BENETLY"},
                new Car{Id = 3, Name = "ASTON MARTIN"}
            };
            ViewData["Cars"] = cars;
            return View();
        }

        public ActionResult TempDataResult1()
        {
            List<Car> cars = new List<Car>()
            {
                new Car{Id = 1, Name = "MERCEDES"},
                new Car{Id = 2, Name = "BENETLY"},
                new Car{Id = 3, Name = "ASTON MARTIN"}
            };
            TempData["Cars"] = cars;
            return RedirectToAction("TempDataResult2");
        }

        public ActionResult TempDataResult2()
        {
            TempData.Keep("Cars");
            return View(TempData["Cars"]);
        }

        public ActionResult TempDataResult3()
        {
            return View();
        }
        
    }
}