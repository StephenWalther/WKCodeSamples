using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowScaffolding.Controllers
{
    public class ArchiveController : Controller
    {
        //
        // GET: /Archive/

        public ActionResult GetEntryByDate(DateTime entryDate)
        {
            return Content(entryDate.ToString());
        }



        public ActionResult GetEntryById(long id) {
            return Content(id.ToString());
        }


    }
}
