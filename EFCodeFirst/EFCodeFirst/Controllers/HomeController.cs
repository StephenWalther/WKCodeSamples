using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFCodeFirst.Models;

namespace EFCodeFirst.Controllers
{
    public class HomeController : Controller
    {

        private DataContext context = new DataContext(); 

        //
        // GET: /Home/

        public ActionResult Index()
        {

            var result = HttpUtility.HtmlDecode("the script is &lt;script&gt;evil");

            var movies = from m in context.Movies select m;
            return View(movies.ToList());
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        } 

        
        [HttpPost]
        public ActionResult Create(Movie movieToCreate)
        {
            if (ModelState.IsValid) {

                context.Movies.Add(movieToCreate);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(movieToCreate);
        }
        
        //
        // GET: /Home/Edit/5
 
        public ActionResult Edit(int id)
        {
            var movieToEdit = context.Movies.Find(id);

            return View(movieToEdit);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(Movie movieToEdit)
        {
            if (ModelState.IsValid) {

                //var originalMovie = context.Movies.Find(movieToEdit.MovieId);

                //originalMovie.UserName = this.User.Identity.Name;

                //orignalMovie.Director = movieToEdit.Director;


                context.Entry(movieToEdit).State = System.Data.EntityState.Modified;
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(movieToEdit);
        }

        //
        // GET: /Home/Delete/5
 
        public ActionResult Delete(int id)
        {
            var movieToDelete = context.Movies.Find(id);

            return View(movieToDelete);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var movieToDelete = context.Movies.Find(id);

            context.Movies.Remove(movieToDelete);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
