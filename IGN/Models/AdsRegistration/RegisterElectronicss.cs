using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace IGN.Models.AdsRegistration
{

    public class RegisterElectronicss
    {
        //Fixed
        public int CategoryID { get; set; }
        public int CityID { get; set; }
        public int RegionID { get; set; }
        public DbGeography Location { get; set; }

        public int AgahiServiceID { get; set; }
        public string TitleAgahi { get; set; }

        public string UntillHour { get; set; }
        public string FromHour { get; set; }

        public string uploadimageone { get; set; }
        public string uploadimagetwo { get; set; }
        public string uploadimagethree { get; set; }
        public string uploadimagefour { get; set; }
        public string AgahiDescription { get; set; }

        public string AdvertiserFullName { get; set; }
        public string AdvertiserEmail { get; set; }
        public string AdvertiserMobile { get; set; }
        public int KindAdsID { get; set; }
        public string RegisterDate { get; set; }
        public int UserID { get; set; }
        public int LanguageID { get; set; }
        public bool? Chatable { get; set; }
        public string OnTime { get; set; }
        public bool? SpecialAgahi { get; set; }
        //Internal

        public int KindTotalPriceID { get; set; }
        public decimal TotalPrice { get; set; }


    }

}