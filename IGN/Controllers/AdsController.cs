using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGN.Controllers
{
    public class AdsController : Controller
    {
        // GET: Ads
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult دسته_بندی(string cate1, string cate2, string cate3)
        {
            return View();
        }

  
        public ActionResult ثبت_آگهی()
        {
            return View();
        }

        public ActionResult جزئیات_آگهی()
        {
            return View();
        }

        public ActionResult آگهی_های_من()
        {
            return View();
        }
        public ActionResult جستجو_آگهی()
        {
            return View();
        }
    }
}