using MVC_Application_CC08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Application_CC08.Controllers
{
    public class CodeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Code

        // Customers Residing in Germany or any country
        [ActionName("Country")]
        public ActionResult CustomersInGermany()
        {
            return View();
        }


        [HttpPost]
        [ActionName("Country")]
        public ActionResult CustomersInGermany(string country)
        {
            var cust = db.Customers.Where(c => c.Country == country).ToList();
            if (!cust.Any())
            {
                ViewBag.Message = "No customers found for the selected country.";
            }
            return View(cust);
        }

        // Customer detail according to order ID
        [ActionName("OrderId")]
        public ActionResult CustomerById()
        {
            return View();
        }

        [HttpPost]
        [ActionName("OrderId")]
        public ActionResult CustomerById(int orderId)
        {
            var cust = (from o in db.Orders where o.OrderID == orderId select o.Customer).FirstOrDefault();
            if (cust == null)
            {
                ViewBag.Message = "No customer found for the given Order ID.";
            }
            return View(cust);
        }
    }
}