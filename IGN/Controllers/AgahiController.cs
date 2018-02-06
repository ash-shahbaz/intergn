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
        public ActionResult ثبت_آگهی(string name, string id1, string id2, string id3)
        {
            if (name != "")
            {
                ViewBag.lvl0 = name;
                ViewBag.lvl1 = id1;
                ViewBag.lvl2 = id2;
                ViewBag.CID = id3;



            }
            return View();
        }




        [ActionName("جزئیات-آگهی")]
        public ActionResult جزئیات_آگهی(string name)
        {

            string s = Utility.CreateMD5(name);

            //string sd = Utility.Encrypt(name);
            //string rd = Utility.Decrypt(sd);



            return View();
        }
        [ActionName("آگهی-های-من")]
        public ActionResult آگهی_های_من()
        {
            return View();
        }


        [ActionName("جستجو")]
        public ActionResult جستجو(string name, string id1, string id2, string id3)
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

        //[HttpPost]
        //public JsonResult AgahiAdd(tblAgahi tagahi)
        //{

        public JsonResult CaseOne(CaseOnes item)
        {

        //    Utility.AddAgahi(tagahi);

        //    return Json("Ok");

            return null;
        }
    }


    public class CaseOnes
    {
        //Fixed
        public int lv0 { get; set; }
        public int lv1 { get; set; }
        public int lv2 { get; set; }
        public int Country { get; set; }
        public int City { get; set; }
        public int Region { get; set; }
        public string Location { get; set; }
        public int Kind { get; set; }
        public string TitleAgahi { get; set; }
        public string uploadimageone { get; set; }
        public string uploadimagetwo { get; set; }
        public string uploadimagethree { get; set; }
        public string uploadimagefour { get; set; }
        public string txtDesc { get; set; }

        public string NameAdvertiser { get; set; }
        public string EmailAdvertiser { get; set; }
        public int MobileAdvertiser { get; set; }
        public int KindAds { get; set; }

        public string RegisterDate { get; set; }
        public int UserID { get; set; }
        public int LanguageID { get; set; }
        public int Chatable { get; set; }
        public string OnTime { get; set; }
        public int SpecialAgahi { get; set; }

        //Internal


    }





}