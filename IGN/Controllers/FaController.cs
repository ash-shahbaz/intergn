using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGN.Controllers
{
    public class FaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult cat(string CategoryName,string NewsID,string Title)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult tags(string tagName)
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }


        public ActionResult source(string tagName)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }




    }


}