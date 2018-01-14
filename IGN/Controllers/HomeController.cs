using IGN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace IGN.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            Utility.CurrentUser = null;
            return View("~/Views/Home/Index.cshtml");
        }


        public string Login(Users u)
        {
            Users user = u;
            Session["user"] = u;
            Utility.CurrentUser = u;
            if (u.UserType == 0)
            {
                return new JavaScriptSerializer().Serialize(u);

            }
            else if (u.UserType == 1)
            {
                return new JavaScriptSerializer().Serialize(u);

            }
            else
            {
                return new JavaScriptSerializer().Serialize(u);
            }
        }


        public string CheckUser(string username, string pass)
        {
            return Utility.CallApiGetResultCheckUser(username, pass);
        }


        [ActionName("تنظیمات")]
        public ActionResult تنظیمات(string id)
        {
            return View();
        }
        [ActionName("تماس-با-ما")]
        public ActionResult تماس_با_ما(string id)
        {
            return View();
        }
        [ActionName("درباره-ما")]
        public ActionResult درباره_ما(string id)
        {
            return View();
        }

        public ActionResult NotificationSetting(string name)
        {
            ViewBag.CategoryName = name;
            return View();
        }
    }
}