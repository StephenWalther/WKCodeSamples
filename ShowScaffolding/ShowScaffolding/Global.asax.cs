using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ShowScaffolding.Constraints;
using ShowScaffolding.Models;

namespace ShowScaffolding {
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            //routes.MapRoute(
            //    "CMS", // Route name
            //    "Document/{*path}", // URL with parameters
            //    new { controller = "CMS", action = "Get" } // Parameter defaults
            //);



            //routes.MapRoute(
            //    "ArchiveById", // Route name
            //    "Archive/{id}", // URL with parameters
            //    new { controller = "Archive", action = "GetEntryById" }, // Parameter defaults
            //    new { id = new NumberConstraint() }
            //);



            //routes.MapRoute(
            //    "Archive", // Route name
            //    "Archive/{entryDate}", // URL with parameters
            //    new { controller = "Archive", action = "GetEntryByDate" } // Parameter defaults
            //);



            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);


            //ModelBinders.Binders.Add(typeof(Movie), new MyMovieBinder());
        
        }
    }
}















