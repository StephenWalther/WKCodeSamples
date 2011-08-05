using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFOldAndBad.Models;

namespace EFOldAndBad.Controllers
{
    public class HomeController : Controller
    {

        private MoviesDBEntities entities = new MoviesDBEntities();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var movies = (from m in entities.Movies select m).ToList();
            return View(movies);
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(Movie movieToCreate)
        {
            if (ModelState.IsValid) {
                entities.AddToMovies(movieToCreate);
                entities.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(movieToCreate);
        }
        
        //
        // GET: /Home/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

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
        // GET: /Home/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

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
