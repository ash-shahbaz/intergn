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


        public JsonResult CaseOne(CaseOnes item)
        {

            return null;
        }

        public JsonResult CaseTwo(CaseTwos item)
        {

            return null;
        }


        public JsonResult CaseThree(CaseThrees item)
        {

            return null;
        }

        public JsonResult CaseFourh(CaseFourhs item)
        {

            return null;
        }

        public JsonResult CaseFive(CaseFives item)
        {

            return null;
        }

        public JsonResult CaseSix(CaseSixs item)
        {

            return null;
        }

        public JsonResult CaseSeventh(CaseSevenths item)
        {

            return null;
        }

        public JsonResult CaseEighth(CaseEighths item)
        {

            return null;
        }

        public JsonResult CaseNine(CaseNines item)
        {

            return null;
        }

        public JsonResult CaseTen(CaseTens item)
        {

            return null;
        }

        public JsonResult CaseEleven(CaseElevens item)
        {

            return null;
        }

        public JsonResult CaseTwelve(CaseTwelves item)
        {

            return null;
        }

        public JsonResult CaseThirteen(CaseThirteens item)
        {

            return null;
        }

        public JsonResult CaseFourteen(CaseFourteens item)
        {

            return null;
        }

        public JsonResult CaseFifteen(CaseFifteens item)
        {

            return null;
        }

        public JsonResult CaseSixteen(CaseSixteens item)
        {

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

        public int KindTotalPrice { get; set; }
        public int TotalPrice { get; set; }
        public int Area { get; set; }
        public int RoomNumber { get; set; }
        public int Countryside { get; set; }
        public int Person { get; set; }
        public int FromYear { get; set; }
        public int FloorNumber { get; set; }
        public int KindBottom { get; set; }
        public int KindHeating { get; set; }

        public bool HasParking { get; set; }
        public bool HasElevator { get; set; }
        public bool HasIranianService { get; set; }
        public bool HasForeignService { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasPool { get; set; }
        public bool HasUnderground { get; set; }
        public bool HasYard { get; set; }
        public bool HasSauna { get; set; }
        public bool HasJacuzzi { get; set; }
        public bool HasSleepMaster { get; set; }
        public bool HasRoofGarden { get; set; }
        public bool HasChiller { get; set; }
        public bool HasBarbecue { get; set; }
        public bool HasAltar { get; set; }
        public bool HasLobby { get; set; }
        public bool HasBabyPlayground { get; set; }
        public bool HasGym { get; set; }
        public bool HasHeir { get; set; }
        public bool HasSingleDocument { get; set; }

        public int Infrastructure { get; set; }
        public int price { get; set; }
        public int LoanAmount { get; set; }
    }




    public class CaseTwos
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

        public int KindTotalPrice { get; set; }
        public int TotalPrice { get; set; }
        public int Area { get; set; }
        public int Countryside { get; set; }
        public int Person { get; set; }
        public int FloorNumber { get; set; }
        public bool HasHeir { get; set; }
        public bool HasSingleDocument { get; set; }
        public int Infrastructure { get; set; }
        public int price { get; set; }
        public int LoanAmount { get; set; }

    }

    public class CaseThrees
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

        public int KindDepositPrice { get; set; }
        public int DepositPrice { get; set; }
        public int KindRentPrice { get; set; }
        public int RentPrice { get; set; }
        public int Area { get; set; }
        public int RoomNumber { get; set; }
        public int Countryside { get; set; }
        public int Person { get; set; }
        public int YearCreated { get; set; }
        public int FloorNumber { get; set; }
        public int KindBottom { get; set; }
        public int KindHeating { get; set; }
        public bool HasParking { get; set; }
        public bool HasElevator { get; set; }
        public bool HasIranianService { get; set; }
        public bool HasForeignService { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasPool { get; set; }
        public bool HasUnderground { get; set; }
        public bool HasYard { get; set; }
        public bool HasSauna { get; set; }
        public bool HasJacuzzi { get; set; }
        public bool HasSleepMaster { get; set; }
        public bool HasRoofGarden { get; set; }
        public bool HasChiller { get; set; }
        public bool HasBarbecue { get; set; }
        public bool HasAltar { get; set; }
        public bool HasLobby { get; set; }
        public bool HasBabyPlayground { get; set; }
        public bool HasGym { get; set; }
    }

    public class CaseFourhs
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

        public int KindTotalPrice { get; set; }
        public int TotalPrice { get; set; }
        public int Area { get; set; }
        public int RoomNumber { get; set; }
        public int Countryside { get; set; }
        public int Person { get; set; }
        public int AdminDoc { get; set; }
        public int YearCreated { get; set; }
        public int FloorNumber { get; set; }
        public int KindBottom { get; set; }
        public int KindHeating { get; set; }
        public bool HasParking { get; set; }
        public bool HasElevator { get; set; }
        public bool HasIranianService { get; set; }
        public bool HasForeignService { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasPool { get; set; }
        public bool HasUnderground { get; set; }
        public bool HasYard { get; set; }
        public bool HasSauna { get; set; }
        public bool HasJacuzzi { get; set; }
        public bool HasSleepMaster { get; set; }
        public bool HasRoofGarden { get; set; }
        public bool HasChiller { get; set; }
        public bool HasBarbecue { get; set; }
        public bool HasAltar { get; set; }
        public bool HasLobby { get; set; }
        public bool HasBabyPlayground { get; set; }
        public bool HasGym { get; set; }
        public bool HasHeir { get; set; }
        public bool HasSingleDocument { get; set; }
        public int Infrastructure { get; set; }
        public int price { get; set; }
        public int LoanAmount { get; set; }




    }

    public class CaseFives
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


        public int KindDepositPrice { get; set; }
        public int DepositPrice { get; set; }
        public int KindRentPrice { get; set; }
        public int RentPrice { get; set; }
        public int Area { get; set; }
        public int RoomNumber { get; set; }
        public int Countryside { get; set; }
        public int Person { get; set; }
        public int AdminDoc { get; set; }
        public int YearCreated { get; set; }
        public int FloorNumber { get; set; }
        public int KindBottom { get; set; }
        public int KindHeating { get; set; }
        public bool HasParking { get; set; }
        public bool HasElevator { get; set; }
        public bool HasIranianService { get; set; }
        public bool HasForeignService { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasPool { get; set; }
        public bool HasUnderground { get; set; }
        public bool HasYard { get; set; }
        public bool HasSauna { get; set; }
        public bool HasJacuzzi { get; set; }
        public bool HasSleepMaster { get; set; }
        public bool HasRoofGarden { get; set; }
        public bool HasChiller { get; set; }
        public bool HasBarbecue { get; set; }
        public bool HasAltar { get; set; }
        public bool HasLobby { get; set; }
        public bool HasBabyPlayground { get; set; }
        public bool HasGym { get; set; }




    }

    public class CaseSixs
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

        public int Person { get; set; }



    }

    public class CaseSevenths
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


        public int KindTotalPrice { get; set; }
        public int TotalPrice { get; set; }
        public int NumberMonthlyInstallment { get; set; }
        public int MonthlyInstallment { get; set; }
        public int BrandName { get; set; }
        public int CarFunction { get; set; }
        public int Year { get; set; }
        public int Person { get; set; }
        public int KindCondition { get; set; }
        public int KindChassis { get; set; }
        public int KindDiff { get; set; }
        public int KindColorOut { get; set; }
        public int KindColorIn { get; set; }
        public int KindModelTip { get; set; }
        public int KindGearbox { get; set; }
        public int KindFuel { get; set; }
        public int KindCrash { get; set; }
        public int KindPelak { get; set; }
        public bool HasSunroof { get; set; }
        public bool HasAlarm { get; set; }
        public bool HasSound { get; set; }




    }

    public class CaseEighths
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


        public int KindTotalPrice { get; set; }
        public int TotalPrice { get; set; }
        public int NumberMonthlyInstallment { get; set; }
        public int MonthlyInstallment { get; set; }
        public int BrandName { get; set; }
        public int CarFunction { get; set; }
        public int Year { get; set; }
        public int Person { get; set; }
        public int KindCondition { get; set; }
        public int KindChassis { get; set; }
        public int KindDiff { get; set; }
        public int KindColorOut { get; set; }
        public int KindColorIn { get; set; }
        public int KindModelTip { get; set; }
        public int KindGearbox { get; set; }
        public int KindFuel { get; set; }
        public int KindCrash { get; set; }
        public int KindPelak { get; set; }
        public bool HasSunroof { get; set; }
        public bool HasAlarm { get; set; }
        public bool HasSound { get; set; }



    }

    public class CaseNines
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

        public int KindTotalPrice { get; set; }
        public int TotalPrice { get; set; }
        public int NumberMonthlyInstallment { get; set; }
        public int MonthlyInstallment { get; set; }
        public int BrandName { get; set; }
        public int CarFunction { get; set; }
        public int Year { get; set; }
        public int Person { get; set; }
        public int KindCondition { get; set; }
        public int KindColorOut { get; set; }
        public int KindModelTip { get; set; }
        public int KindFuel { get; set; }
        public int KindCrash { get; set; }
        public int KindPelak { get; set; }
        public bool HasAlarm { get; set; }

    }

    public class CaseTens
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
        public int KindTotalPrice { get; set; }
        public int TotalPrice { get; set; }

    }

    public class CaseElevens
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

        public int KindTotalPrice { get; set; }
        public int TotalPrice { get; set; }
        public int BrandName { get; set; }
        public int KindColor { get; set; }


    }

    public class CaseTwelves
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


        public int KindTotalPrice { get; set; }
        public int TotalPrice { get; set; }
        public int BrandName { get; set; }
        public int KindColor { get; set; }
        public int KindSizeScreen { get; set; }
        public int KindTouch { get; set; }
        public int MeasureRAM { get; set; }
        public int MeasureCPU { get; set; }
        public int MeasureHard { get; set; }
        public int MeasureGraphic { get; set; }
        public bool HasAntiWater { get; set; }
        public bool HasUSB3 { get; set; }
        public bool HasDVDRW { get; set; }
        public bool HasCamera { get; set; }



    }

    public class CaseThirteens
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


        public int KindTotalPrice { get; set; }
        public int TotalPrice { get; set; }
        public int MeasureRAM { get; set; }
        public int MeasureCPU { get; set; }
        public int MeasureHard { get; set; }
        public int MeasureGraphic { get; set; }
        public bool HasUSB3 { get; set; }
        public bool HasDVDRW { get; set; }
        public bool HasSpeaker { get; set; }


    }

    public class CaseFourteens
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

        public int KindTotalPrice { get; set; }
        public int TotalPrice { get; set; }


    }

    public class CaseFifteens
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

        public int KindTotalPrice { get; set; }
        public int TotalPrice { get; set; }

    }

    public class CaseSixteens
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