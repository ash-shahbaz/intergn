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
          return  View("~/Views/Fa/Index.cshtml");
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            Utility.CurrentUser = null;
            return View("~/Views/Fa/Index.cshtml");
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

        public ActionResult Page(string name)
        {

            if (Session["user"] != null || Utility.CurrentUser != null)
            {
                Users u = (Users)Utility.CurrentUser;

                if (u.UserType == 0)
                {

                    return View();
                }
                else if (u.UserType == 1)
                {
                    return View();
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return View("../Fa/Index");
            }

        }

    }
}