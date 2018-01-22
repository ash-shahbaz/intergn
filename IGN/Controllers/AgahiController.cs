using IGN.Models;
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
        public ActionResult جستجو(string name, string id1, string id2,string id3)
        {

            if (name != "" && name != null)
            {
                var qGetProvince = Utility.lstProvinces.Where(p => p.ProvinceName == name).FirstOrDefault();
                Utility.PrivinceID = qGetProvince.ProvinceID;

               Utility.CityName = name;

                if (id1 == null && id2 == null && id3 == null)
                {
                    ViewBag.AllStatus = true;

                }
                else if (id1 != null && id2 != null && id3 == null)
                {
                    ViewBag.Level1 = id1;
                    ViewBag.Level2 = id2;
                    ViewBag.Level3 = null;

                }
                else
                {
                    ViewBag.Level1 = id1;
                    ViewBag.Level2 = id2;
                    ViewBag.Level3 = id3;
                }


            }
            else
            {
                ViewBag.AllStatus = false;
                Utility.PrivinceID = 8;
            }


            return View();
        }



   
    }
}