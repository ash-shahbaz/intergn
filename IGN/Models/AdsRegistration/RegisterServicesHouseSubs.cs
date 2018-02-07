using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGN.Models.AdsRegistration
{

    public class RegisterServicesHouseSubs
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

}