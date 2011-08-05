using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShowScaffolding.Models;

namespace ShowScaffolding.Controllers
{   
    public class MoviesController : Controller
    {
		private readonly IMovieRepository movieRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public MoviesController() : this(new MovieRepository())
        {
        }

        public MoviesController(IMovieRepository movieRepository)
        {
			this.movieRepository = movieRepository;
        }

        //
        // GET: /Movies/

        public ViewResult Index()
        {
            return View(movieRepository.All);
        }

        //
        // GET: /Movies/Details/5

        public ViewResult Details(long id)
        {
            return View(movieRepository.Find(id));
        }

        //
        // GET: /Movies/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Movies/Create

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid) {
                movieRepository.InsertOrUpdate(movie);
                movieRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Movies/Edit/5
 
        public ActionResult Edit(long id)
        {
             return View(movieRepository.Find(id));
        }

        //
        // POST: /Movies/Edit/5

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid) {
                movieRepository.InsertOrUpdate(movie);
                movieRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Movies/Delete/5
 
        public ActionResult Delete(long id)
        {
            return View(movieRepository.Find(id));
        }

        //
        // POST: /Movies/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            movieRepository.Delete(id);
            movieRepository.Save();

            return RedirectToAction("Index");
        }


        protected override void HandleUnknownAction(string actionName) {
            Response.Write("I have no idea what " + actionName + " is!");
        }


    }
}

















