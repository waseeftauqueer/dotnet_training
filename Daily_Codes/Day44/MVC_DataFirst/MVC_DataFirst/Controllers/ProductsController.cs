using MVC_DataFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVC_DataFirst.Controllers
{
    public class ProductsController : Controller
    {
        NorthwindEntities1 db = new NorthwindEntities1();
        // GET: Products
        public ActionResult Index()
        {
            //using eager loading by including supplier and category models along
            // with product model
            var products = db.Products.Include(p1=> p1.Category).Include(p1 => p1.Supplier).ToList();
            return View(products);
        }

        // 
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            return View(db);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (!ModelState.IsValid) {
                db.Products.Add(product); 
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            // For the category and the supplier dropdowns
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", product.CategoryID);
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName", product.SupplierID);
            return View(product);
        }
    }
}