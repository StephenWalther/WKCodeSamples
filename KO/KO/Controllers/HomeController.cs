using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KO.Models;

namespace KO.Controllers
{
    public class HomeController : Controller
    {

        private DataContext context = new DataContext();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ListMovies() {
            return Json(context.Movies.ToList());
        }


        public ActionResult EditMovies(IEnumerable<Movie> movies) {
            return Json("success!");
        }
        

    }
}
