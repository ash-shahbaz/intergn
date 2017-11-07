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


        //public ActionResult Login()
        //{
           
        //}

        //public ActionResult Register()
        //{

        //}

        public ActionResult MyProfile(string id)
        {
            
            return View();
        }

        public ActionResult AboutUs(string id)
        {
            return View();
        }

        public ActionResult ContactUs(string id)
        {
            return View();
        }

        public ActionResult NewsResource(string id)
        {
            return View();
        }
        public ActionResult Setting(string id)
        {
            return View();
        }
        public ActionResult MyFriends(string id)
        {
            return View();
        }


        public ActionResult BackLinks(string id)
        {
            return View();
        }

        public ActionResult BackLinkAdd(string id)
        {
            return View();
        }

        public ActionResult PostSent(string id)
        {
            return View();
        }
        public ActionResult NewsFavorites(string id)
        {
            return View();
        }


    }


}