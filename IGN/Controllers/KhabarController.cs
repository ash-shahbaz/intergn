using IGN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGN.Controllers
{
    public class KhabarController : Controller
    {
        public static int PageNumber = 0;
        // GET: Khabar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTop50NewsByPageNumber(int PageId)
        {
            PageNumber = PageId;
            ViewBag.PageNumber = PageId;
            return View("~/Views/Khabar/دسته-بندی.cshtml");
        }


        [ActionName("منابع-خبری")]
        public ActionResult منابع_خبری()
        {
            return View();
        }

        public ActionResult tags(string name)
        {
            string[] arr = name.Split('-');
            if (arr.Length > 1)
            {
                ViewBag.CID = arr[0];
                ViewBag.TagName = arr[1];
                ViewBag.Catename = arr[2];
                return View();
            }
            else
            {
                ViewBag.TagName = name;
                return View();
            }
        }
        public ActionResult rss(string name)
        {

            ViewBag.TagName = name;
            return View();
        }

      

        [ActionName("دسته-بندی")]

        public ActionResult دسته_بندی(string name, int? pid = null)
        {
            if (pid == null)
            {
                ViewBag.PageNumber = PageNumber;
                ViewBag.CategoryName = name;
                ViewBag.CategoryID = Utility.lstCategory.Where(p => p.CategoryName == name).FirstOrDefault().CategoryID;
                return View();
            }
            else
            {
                PageNumber = Convert.ToInt32(pid);
                ViewBag.PageNumber = PageNumber;
                ViewBag.CategoryName = name;
                ViewBag.CategoryID = Utility.lstCategory.Where(p => p.CategoryName == name).FirstOrDefault().CategoryID;
                return View();

            }
        }
        [ActionName("جستجو")]
        public ActionResult جستجو(string name)
        {

            return View();
        }

        [ActionName("خبر")]
        public ActionResult خبر(string name, string id1, string id2)
        {
            //var q = Utility.GetNewsByNewsID(NewsID);
            Utility.NewsID = Convert.ToInt32(id1);
            return View();
        }

    }
}