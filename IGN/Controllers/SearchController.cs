using IGN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGN.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public List<tblAgahi> SearchAllAgahi(SearchAllAgahis item)
        {

            return null;
        }
        
        public List<tblAgahi> SearchSaleHome(SearchSaleHomes item)
        {
            return null;
        }



        public List<tblAgahi> SearchRentHome(SearchRentHomes item)
        {
            return null;
        }



        public List<tblAgahi> SearchSaleOffice(SearchSaleOffices item)
        {
            return null;
        }



        public List<tblAgahi> SearchRentOffice(SearchRentOffices item)
        {
            return null;
        }



        public List<tblAgahi> SearchServicesHouse(SearchServicesHouses item)
        {
            return null;
        }



        public List<tblAgahi> SearchSaleApartSub(SearchSaleApartSubs item)
        {
            return null;
        }



        public List<tblAgahi> SearchSaleLandSub(SearchSaleLandSubs item)
        {
            return null;
        }



        public List<tblAgahi> SearchRentHouseSub(SearchRentHouseSubs item)
        {
            return null;
        }



        public List<tblAgahi> SearchSaleOfficeSub(SearchSaleOfficeSubs item)
        {
            return null;
        }



        public List<tblAgahi> SearchRentOfficeSub(SearchRentOfficeSubs item)
        {
            return null;
        }




        public List<tblAgahi> SearchServicesHouseSub(SearchServicesHouseSubs item)
        {
            return null;
        }



        public List<tblAgahi> SearchServicesEmployment(SearchServicesEmployments item)
        {
            return null;
        }



        public List<tblAgahi> SearchPersonalEntertainment(SearchPersonalEntertainments item)
        {
            return null;
        }



        public List<tblAgahi> SearchElectronics(SearchElectronicss item)
        {
            return null;
        }



        public List<tblAgahi> SearchMobileTablet(SearchMobileTablets item)
        {
            return null;
        }



        public List<tblAgahi> SearchLapTop(SearchLapTops item)
        {
            return null;
        }



        public List<tblAgahi> SearchCase(SearchCases item)
        {
            return null;
        }



        public List<tblAgahi> SearchMotorAccessories(SearchMotorAccessoriess item)
        {
            return null;
        }



        public List<tblAgahi> SearchCarBoatAcc(SearchCarBoatAccs item)
        {
            return null;
        }



        public List<tblAgahi> SearchCarRiding(SearchCarRidings item)
        {
            return null;
        }



        public List<tblAgahi> SearchCarHeavy(SearchCarHeavys item)
        {
            return null;
        }



        public List<tblAgahi> SearchVehicleAccessories(SearchVehicleAccessoriess item)
        {
            return null;
        }



        public List<tblAgahi> SearchMotorcycle(SearchMotorcycles item)
        {
            return null;
        }



        public List<tblAgahi> SearchAccessoriesDetail(SearchAccessoriesDetails item)
        {
            return null;
        }




        public List<tblAgahi> SearchBoatsAccessories(SearchBoatsAccessoriess item)
        {
            return null;
        }







    }





    public class SearchAllAgahis
    {

        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public string Kind { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }

    }
    public class SearchSaleHomes
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public string Kind { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }

        public int Countryside { get; set; }
        public int Person { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }
        public int UntillArea { get; set; }
        public int FromArea { get; set; }

    }

    public class SearchRentHomes
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchSaleOffices
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchRentOffices
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchServicesHouses
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchSaleApartSubs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchSaleLandSubs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchRentHouseSubs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchSaleOfficeSubs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchRentOfficeSubs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchServicesHouseSubs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchServicesEmployments
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchPersonalEntertainments
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchElectronicss
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchMobileTablets
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchLapTops
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchCases
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchMotorAccessoriess
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchCarBoatAccs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchCarRidings
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchCarHeavys
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchVehicleAccessoriess
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchMotorcycles
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchAccessoriesDetails
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }
    public class SearchBoatsAccessoriess
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }




    }

}