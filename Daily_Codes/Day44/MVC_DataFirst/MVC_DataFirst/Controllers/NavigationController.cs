using MVC_DataFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DataFirst.Controllers
{
    public class NavigationController : Controller
    {
        NorthwindEntities1 db = new NorthwindEntities1();
        // GET: Navigation
        public ActionResult Index()
        {
            return View();
        }

        // Fetching data from multiple tables /objects using navigation property
        public ActionResult MultipleData()
        {
            return View(db.Orders.ToList());
        }
    }
}