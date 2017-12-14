using IGN.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using System.Web.Script.Serialization;

namespace IGN.Controllers
{

    public class FaController : Controller
    {
        public static int PageNumber = 0;
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult NotificationSetting(string name)
        {
            ViewBag.CategoryName = name;
            return View();
        }

        public ActionResult News(string CategoryName, string NewsID, string Title)
        {
            //var q = Utility.GetNewsByNewsID(NewsID);
            Utility.NewsID = Convert.ToInt32(NewsID);
            return View();
        }

        public ActionResult Cat(string name, int? pid = null)
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
        public ActionResult Search(string name)
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

        public ActionResult source(string tagName)
        {
            ViewBag.Message = "Your contact page.";

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


        public ActionResult BackLinks(string name)
        {
            if (name == null)
            {
                ViewBag.Status = 3;
                return View();
            }
            else
            {
                string[] arr = name.Split('-');

                if (arr[0] == "Det")
                {
                    ViewBag.Status = 0;
                    ViewBag.BackLinkID = arr[1];
                    ViewBag.LinkName = arr[2];
                    return View();
                }
                else if (arr[0] == "Cat")
                {
                    ViewBag.Status = 1;
                    ViewBag.CateID = arr[1];
                    ViewBag.CateName = arr[2];

                    return View();
                }
                else if (arr[0] == "CID")
                {
                    ViewBag.Status = 5;
                    ViewBag.CateID = arr[1];
                    

                    return View();
                }
                else if (arr[0] == "Key")
                {
                    ViewBag.Status = 2;
                    ViewBag.Keywords = arr[1];
                    return View();
                }
                else if (arr[0] == "KeyCat")
                {
                    ViewBag.Status = 4;
                    ViewBag.CateID = arr[1];
                    ViewBag.Keywords = arr[2];

                    return View();
                }
                else
                {
                    ViewBag.Status = 3;

                    return View();
                }
            }
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

        public ActionResult GetTop50NewsByPageNumber(int PageId)
        {
            PageNumber = PageId;
            ViewBag.PageNumber = PageId;
            return View("~/Views/fa/cat.cshtml");
        }

        private static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
    }


}