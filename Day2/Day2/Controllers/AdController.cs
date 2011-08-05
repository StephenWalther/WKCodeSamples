using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2.Controllers
{
    public class AdController : Controller
    {
        //
        // GET: /Ad/

        [ChildActionOnly]
        public ActionResult GetAd()
        {
            var adText = "Buy some coffee!";

            if (DateTime.Now.Hour > 12) {
                adText = "Buy some wine!";
            }


            return PartialView("_Ad", adText);
        }

    }
}
