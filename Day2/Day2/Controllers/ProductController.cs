using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2.Models;

namespace Day2.Controllers
{
    public class ProductController : Controller
    {


        public ActionResult ValidatePrice(decimal price) {
            var result = true;

            if (price < 8m) {
                result = false;
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View("Index");
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id)
        {
            var product = new Product {
                Id = 1,
                Name="Comb",
                Price = 344.22m,
                OnSale = true
            };
            return View(product);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(Product productToCreate)
        {

            if (productToCreate.Price < 0) {
                ModelState.AddModelError("Price", "Price must be greater than zero");
            }

            if (ModelState.IsValid) {
                // stick the product in the db
                return RedirectToAction("Index");
            }
          
            return View(productToCreate);
        }
        
        //
        // GET: /Default1/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Default1/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
