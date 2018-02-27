using IGN.Models;
using IGN.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGN.Controllers
{
    public class PostAgahiController : Controller
    {
        
        public string AddRegisterAccessoriesDetails(RegisterAccessoriesDetails item)
        {
            return PostAgahi.AddRegisterAccessoriesDetails(item);
        }
        public string AddRegisterCarHeavys(RegisterCarHeavys item)
        {
            return PostAgahi.AddRegisterCarHeavys(item);
        }
        public string AddRegisterCarRidings(RegisterCarRidings item)
        {
            return PostAgahi.AddRegisterCarRidings(item);
        }
        public string AddRegisterCases(RegisterCases item)
        {
            return PostAgahi.AddRegisterCases(item);
        }
        public string AddRegisterElectronicss(RegisterElectronicss item)
        {
            return PostAgahi.AddRegisterElectronicss(item);
        }
        public string AddRegisterLapTops(RegisterLapTops item)
        {
            return PostAgahi.AddRegisterLapTops(item);
        }
        public string AddRegisterMobileTablets(RegisterMobileTablets item)
        {
            return PostAgahi.AddRegisterMobileTablets(item);
        }
        public string AddRegisterMotorcycles(RegisterMotorcycles item)
        {
            return PostAgahi.AddRegisterMotorcycles(item);
        }
        public string AddRegisterPersonalEntertainments(RegisterPersonalEntertainments item)
        {
            return PostAgahi.AddRegisterPersonalEntertainments(item);
        }
        public string AddRegisterRentHouseSubs(RegisterRentHouseSubs item)
        {
            return PostAgahi.AddRegisterRentHouseSubs(item);
        }
        public string AddRegisterRentOfficeSubs(RegisterRentOfficeSubs item)
        {
            return PostAgahi.AddRegisterRentOfficeSubs(item);
        }
        public string AddRegisterSaleApartSubs(RegisterSaleApartSubs item)
        {
            return PostAgahi.AddRegisterSaleApartSubs(item);
        }
        public string AddRegisterSaleLandSubs(RegisterSaleLandSubs item)
        {
            return PostAgahi.AddRegisterSaleLandSubs(item);
        }
        public string AddRegisterSaleOfficeSubs(RegisterSaleOfficeSubs item)
        {
            return PostAgahi.AddRegisterSaleOfficeSubs(item);
        }
        public string AddRegisterServicesEmployments(RegisterServicesEmployments item)
        {
            return PostAgahi.AddRegisterServicesEmployments(item);
        }
        public string AddRegisterServicesHouseSubs(RegisterServicesHouseSubs item)
        {
            return PostAgahi.AddRegisterServicesHouseSubs(item);
        }
       







    }
}