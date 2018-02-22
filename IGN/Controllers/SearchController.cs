using IGN.Models;
using IGN.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace IGN.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public string SearchAllAgahi(SearchAllAgahis item)
        {
            return SearchPostItem.SearchAllAgahis(item);
        }

        public string SearchSaleHome(SearchSaleHomes item)
        {
            return SearchPostItem.SearchSaleHomes(item);
        }



        public string SearchRentHome(SearchRentHomes item)
        {
            return SearchPostItem.SearchRentHomes(item);
        }



        public string SearchSaleOffice(SearchSaleOffices item)
        {
            return SearchPostItem.SearchSaleOffices(item);
        }



        public string SearchRentOffice(SearchRentOffices item)
        {
            return SearchPostItem.SearchRentOffices(item);
        }



        public string SearchServicesHouse(SearchServicesHouses item)
        {
            return SearchPostItem.SearchServicesHouses(item);
        }



        public string SearchSaleApartSub(SearchSaleApartSubs item)
        {
            return SearchPostItem.SearchSaleApartSubs(item);
        }



        public string SearchSaleLandSub(SearchSaleLandSubs item)
        {
            return SearchPostItem.SearchSaleLandSubs(item);
        }



        public string SearchRentHouseSub(SearchRentHouseSubs item)
        {
            return SearchPostItem.SearchRentHouseSubs(item);
        }



        public string SearchSaleOfficeSub(SearchSaleOfficeSubs item)
        {
            return SearchPostItem.SearchSaleOfficeSubs(item);
        }



        public string SearchRentOfficeSub(SearchRentOfficeSubs item)
        {
            return SearchPostItem.SearchRentOfficeSubs(item);
        }




        public string SearchServicesHouseSub(SearchServicesHouseSubs item)
        {
            return SearchPostItem.SearchServicesHouseSubs(item);
        }



        public string SearchServicesEmployment(SearchServicesEmployments item)
        {
            return SearchPostItem.SearchServicesEmployments(item);
        }



        public string SearchPersonalEntertainment(SearchPersonalEntertainments item)
        {
            return SearchPostItem.SearchPersonalEntertainments(item);
        }



        public string SearchElectronics(SearchElectronicss item)
        {
            return SearchPostItem.SearchElectronicss(item);
        }



        public string SearchMobileTablet(SearchMobileTablets item)
        {
            return SearchPostItem.SearchMobileTablets(item);
        }



        public string SearchLapTop(SearchLapTops item)
        {
            return SearchPostItem.SearchLapTops(item);
        }



        public string SearchCase(SearchCases item)
        {
            return SearchPostItem.SearchCases(item);
        }



        public string SearchMotorAccessories(SearchMotorAccessoriess item)
        {
            return SearchPostItem.SearchMotorAccessoriess(item);
        }



        public string SearchCarBoatAcc(SearchCarBoatAccs item)
        {
            return SearchPostItem.SearchCarBoatAccs(item);
        }



        public string SearchCarRiding(SearchCarRidings item)
        {
            return SearchPostItem.SearchCarRidings(item);
        }



        public string SearchCarHeavy(SearchCarHeavys item)
        {
            return SearchPostItem.SearchCarHeavys(item);
        }



        public string SearchVehicleAccessories(SearchVehicleAccessoriess item)
        {
            return SearchPostItem.SearchVehicleAccessoriess(item);
        }



        public string SearchMotorcycle(SearchMotorcycles item)
        {
            return SearchPostItem.SearchMotorcycles(item);
        }



        public string SearchAccessoriesDetail(SearchAccessoriesDetails item)
        {
            return SearchPostItem.SearchAccessoriesDetails(item);
        }




        public string SearchBoatsAccessories(SearchBoatsAccessoriess item)
        {
            return SearchPostItem.SearchBoatsAccessoriess(item);
        }


    }





    
   

    

 
   

  
   
 
    


 
   
   
  
  
    
  
 
    
    
    
 

}