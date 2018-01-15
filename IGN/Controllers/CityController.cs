using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGN.Controllers
{
    public class CityController : Controller
    {
        // GET: City

        [ActionName("شهر")]
        public ActionResult شهر(string name)
        {
            //View("~/Agahi/جستجو/" + name + "");
            //return RedirectToAction("", "Agahi", name);
            return RedirectToAction("جستجو", "Agahi", new { name = name });
        }


    }
}