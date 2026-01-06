using MVC_DataFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataFirst.Models; 
namespace MVC_DataFirst.Controllers
{
    public class ShipperController : Controller
    {
        NorthwindEntities1 db = new NorthwindEntities1();
        // GET: Shipper
        public ActionResult Index()
        {
            return View(db.Shippers);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        // Passing data from view to controller using form collection
        //public ActionResult Create(FormCollection frm) {
        //    Shipper shipper = new Shipper();
        //    shipper.ShipperID = Convert.ToInt32(frm["ShipperID"]);
        //    shipper.CompanyName = frm["CompanyName"].ToString();
        //    shipper.Phone = frm["Phone"].ToString();

        //    db.Shippers.Add(shipper);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        // Passing data from view to controller using parameter collection
        //[ActionName("Create")]
        //public ActionResult CreatePost(string CustomerName, string Phone)
        //{
        //    Shipper shipper = new Shipper();
        //    shipper.CompanyName = CustomerName;
        //    shipper.Phone = Phone;

        //    db.Shippers.Add(shipper);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        // Passing data from view to controller using request object
        [ActionName("Create")]
        public ActionResult CreatePost()
        {
            Shipper shipper = new Shipper();
            shipper.ShipperID = Convert.ToInt32(Request["ShipperID"]);
            shipper.CompanyName = Request["CompanyName"].ToString();
            shipper.Phone = Request["Phone"].ToString();

            db.Shippers.Add(shipper);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // Calling Stored Procedure
        public ActionResult SP_With_Parameter()
        {
            return View(db.CustOrdersOrders("Vinet"));
        }
        }
    }