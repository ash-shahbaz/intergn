using IGN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGN.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
          return  View("~/Views/Fa/Index.cshtml");
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