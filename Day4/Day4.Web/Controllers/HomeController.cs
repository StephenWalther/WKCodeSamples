using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day4.Services.Repositories;
using Day4.DomainModel;
using Day4.Web.Views.Home;
using System.Data.Entity.Validation;
using Day4.Web.Infrastructure;

namespace Day4.Web.Controllers
{
    public class HomeController : Controller
    {

        private IMovieRepository repository;


        public HomeController() : this(new MovieRepository()) { }

        public HomeController(IMovieRepository repository) {
            this.repository = repository;
        }



        //
        // GET: /Home/

        public ActionResult Index()
        {
            var movies = repository.ListAllMovies();
            var vm = new List<IndexViewModel>();
            movies.ToList().ForEach( m => vm.Add(new IndexViewModel {
                Id = m.Id,
                Title = m.Title, 
                Director = m.Director}));

            return View(vm);
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
        public ActionResult Create(CreateViewModel vm)
        {
            if (ModelState.IsValid) {
                var movieToCreate = new Movie {
                    Title = vm.Title,
                    Director = vm.Director
                };
                
                repository.Create(movieToCreate);

                try {
                    repository.SaveChanges();
                } catch (DbEntityValidationException dex) {
                    ModelState.Merge(dex.GetModelErrors());
                    return View(vm);
                }

                return RedirectToAction("Index");
            }
            return View(vm);
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
