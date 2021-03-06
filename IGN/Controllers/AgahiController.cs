﻿using IGN.Models;
using IGN.Models.AdsRegistration;
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

            //string s = Utility.CreateMD5(name);

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



        [ActionName("جستجو-اطراف-من")]
        public ActionResult جستجو_اطراف_من(string name, string id1, string id2, string id3)
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



        public JsonResult RegisterSaleApartSub(RegisterSaleApartSubs item)
        {

            string result = PostAgahi.AddRegisterSaleApartSubs(item);

            return null;
        }

        public JsonResult RegisterSaleLandSub(RegisterSaleLandSubs item)
        {
            string result = PostAgahi.AddRegisterSaleLandSubs(item);
            return null;
        }


        public JsonResult RegisterRentHouseSub(RegisterRentHouseSubs item)
        {
            string result = PostAgahi.AddRegisterRentHouseSubs(item);
            return null;
        }

        public JsonResult RegisterSaleOfficeSub(RegisterSaleOfficeSubs item)
        {
            string result = PostAgahi.AddRegisterSaleOfficeSubs(item);
            return null;
        }

        public JsonResult RegisterRentOfficeSub(RegisterRentOfficeSubs item)
        {
            string result = PostAgahi.AddRegisterRentOfficeSubs(item);
            return null;
        }

        public JsonResult RegisterServicesHouseSub(RegisterServicesHouseSubs item)
        {
            string result = PostAgahi.AddRegisterServicesHouseSubs(item);
            return null;
        }

        public JsonResult RegisterCarRiding(RegisterCarRidings item)
        {
            string result = PostAgahi.AddRegisterCarRidings(item);
            return null;
        }

        public JsonResult RegisterCarHeavy(RegisterCarHeavys item)
        {
            string result = PostAgahi.AddRegisterCarHeavys(item);
            return null;
        }

        public JsonResult RegisterMotorcycle(RegisterMotorcycles item)
        {
            string result = PostAgahi.AddRegisterMotorcycles(item);
            return null;
        }

        public JsonResult RegisterAccessoriesDetail(RegisterAccessoriesDetails item)
        {
            string result = PostAgahi.AddRegisterAccessoriesDetails(item);
            return null;
        }

        public JsonResult RegisterMobileTablet(RegisterMobileTablets item)
        {
            string result = PostAgahi.AddRegisterMobileTablets(item);
            return null;
        }

        public JsonResult RegisterLapTop(RegisterLapTops item)
        {
            string result = PostAgahi.AddRegisterLapTops(item);
            return null;
        }

        public JsonResult RegisterCase(RegisterCases item)
        {
            string result = PostAgahi.AddRegisterCases(item);
            return null;
        }

        public JsonResult RegisterElectronics(RegisterElectronicss item)
        {
            string result = PostAgahi.AddRegisterElectronicss(item);
            return null;
        }

        public JsonResult RegisterPersonalEntertainment(RegisterPersonalEntertainments item)
        {


            string result = PostAgahi.AddRegisterPersonalEntertainments(item);
            return null;
        }

        public JsonResult RegisterServicesEmployment(RegisterServicesEmployments item)
        {
            string result = PostAgahi.AddRegisterServicesEmployments(item);
            return null;
        }

    }






































}