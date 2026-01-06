using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository<Products> _productsRepository = null;

        // Calling Controller's Constructor

        public ProductController()
        {
            _productsRepository = new ProductRepository<Products>();
        }

        // GET: Product
        public ActionResult Index()
        {
            var products = _productsRepository.GetAll();
            return View(products);
        }


        // Creating a New Product

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Products products)
        {
            if (ModelState.IsValid)
            {
                _productsRepository.Insert(products);
                _productsRepository.Save();
                return RedirectToAction("Index");
            }
            return View(products);
        }

        // Get Data By ID
        public ActionResult GetDataById(int Id)
        {
            var product = _productsRepository.GetById(Id);
            return View(product);
        }

        // Update Data in Products

        public ActionResult Edit(int id)
        {
            var product = _productsRepository.GetById(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Products product)
        {
            if (ModelState.IsValid)
            {
                _productsRepository.Update(product);
                _productsRepository.Save();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // Deleting the Product

        public ActionResult Delete(int id)
        {
            var product = _productsRepository.GetById(id);
            return View(product);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _productsRepository.Delete(id);
            _productsRepository.Save();
            return RedirectToAction("Index");
        }


    }
}