using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGN.Controllers
{
    public class AgahiController : Controller
    {
        // GET: Agahi
        public ActionResult Index()
        {
            return View();
        }
        [ActionName("ثبت-آگهی")]
        public ActionResult ثبت_آگهی()
        {
            return View();
        }

     


        [ActionName("جزئیات-آگهی")]
        public ActionResult جزئیات_آگهی()
        {
            return View();
        }
        [ActionName("آگهی-های-من")]
        public ActionResult آگهی_های_من()
        {
            return View();
        }
      
       
        [ActionName("جستجو")]
        public ActionResult جستجو(string name, string id1, string id2)
        {
            return View();
        }



   
    }
}