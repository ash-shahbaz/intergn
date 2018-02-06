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


        public int KindRentPrice { get; set; }
        public int UntillRentPrice { get; set; }
        public int FromRentPrice { get; set; }

        public int KindDepositPrice { get; set; }
        public int UntillDepositPrice { get; set; }
        public int FromDepositPrice { get; set; }

        public int UntillArea { get; set; }
        public int FromArea { get; set; }
        public int Countryside { get; set; }
        public int Person { get; set; }
        public int Kind { get; set; }


    }
    public class SearchSaleOffices
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }


        public int AdminDoc { get; set; }
        public int Person { get; set; }
        public int Kind { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }
        public int UntillArea { get; set; }
        public int FromArea { get; set; }

    }
    public class SearchRentOffices
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }


        public int KindRentPrice { get; set; }
        public int UntillRentPrice { get; set; }
        public int FromRentPrice { get; set; }
        public int KindDepositPrice { get; set; }
        public int UntillDepositPrice { get; set; }
        public int FromDepositPrice { get; set; }
        public int UntillArea { get; set; }
        public int FromArea { get; set; }
        public int Countryside { get; set; }
        public int Person { get; set; }
        public int Kind { get; set; }



    }
    public class SearchServicesHouses
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }

        public int Person { get; set; }


    }
    public class SearchSaleApartSubs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }



        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }
        public int RoomNumber { get; set; }
        public int UntillArea { get; set; }
        public int FromArea { get; set; }
        public int Countryside { get; set; }
        public int Person { get; set; }
        public int Kind { get; set; }
        public int UntillInfrastructure { get; set; }
        public int FromInfrastructure { get; set; }
        public int UntillLoan { get; set; }
        public int FromLoan { get; set; }
        public int UntillYear { get; set; }
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
        public bool HasLoan { get; set; }

    }
    public class SearchSaleLandSubs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }



        public int Countryside { get; set; }
        public int Person { get; set; }
        public int Kind { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }
        public int UntillArea { get; set; }
        public int FromArea { get; set; }
        public int UntillInfrastructure { get; set; }
        public int FromInfrastructure { get; set; }
        public int UntillLoan { get; set; }
        public int FromLoan { get; set; }
        public int FloorNumber { get; set; }

        public bool HasHeir { get; set; }
        public bool HasSingleDocument { get; set; }
        public bool HasLoan { get; set; }


    }
    public class SearchRentHouseSubs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }


        public int RoomNumber { get; set; }
        public int KindRentPrice { get; set; }
        public int UntillRentPrice { get; set; }
        public int FromRentPrice { get; set; }
        public int KindDepositPrice { get; set; }
        public int UntillDepositPrice { get; set; }
        public int FromDepositPrice { get; set; }
        public int UntillArea { get; set; }
        public int FromArea { get; set; }
        public int Countryside { get; set; }
        public int Person { get; set; }
        public int Kind { get; set; }
        public int UntillYear { get; set; }
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

    }
    public class SearchSaleOfficeSubs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }





        public int RoomNumber { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }
        public int UntillArea { get; set; }
        public int FromArea { get; set; }
        public int Countryside { get; set; }
        public int Person { get; set; }
        public int Kind { get; set; }
        public int UntillInfrastructure { get; set; }
        public int FromInfrastructure { get; set; }
        public int UntillLoan { get; set; }
        public int FromLoan { get; set; }
        public int UntillYear { get; set; }
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
        public bool HasLoan { get; set; }


    }
    public class SearchRentOfficeSubs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }



        public int RoomNumber { get; set; }
        public int KindRentPrice { get; set; }
        public int UntillRentPrice { get; set; }
        public int FromRentPrice { get; set; }
        public int KindDepositPrice { get; set; }
        public int UntillDepositPrice { get; set; }
        public int FromDepositPrice { get; set; }
        public int UntillArea { get; set; }
        public int FromArea { get; set; }
        public int Countryside { get; set; }
        public int Person { get; set; }
        public int Kind { get; set; }
        public int UntillYear { get; set; }
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



    }
    public class SearchServicesHouseSubs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }


        public int Person { get; set; }

    }
    public class SearchServicesEmployments
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }
        public int KindService { get; set; }
        


    }
    public class SearchPersonalEntertainments
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }



        public int Kind { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }


    }
    public class SearchElectronicss
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }


        public int Kind { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }



    }
    public class SearchMobileTablets
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }



        public int Kind { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }
        public int KindColor { get; set; }
        public int KindBrand { get; set; }

    }
    public class SearchLapTops
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }



        public int Kind { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }
        public int KindColor { get; set; }
        public int KindBrand { get; set; }
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
    public class SearchCases
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }


        public int Kind { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }
        public int MeasureRAM { get; set; }
        public int MeasureCPU { get; set; }
        public int MeasureHard { get; set; }
        public int MeasureGraphic { get; set; }

        public bool HasUSB3 { get; set; }
        public bool HasDVDRW { get; set; }
        public bool HasSpeaker { get; set; }

    }
    public class SearchMotorAccessoriess
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }



        public int Kind { get; set; }
        public int UntillYear { get; set; }
        public int FromYear { get; set; }
        public int UntillCarFunction { get; set; }
        public int FromCarFunction { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }


    }
    public class SearchCarBoatAccs
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }


        public int Kind { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }


    }
    public class SearchCarRidings
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }


        public int UntillMonthlyInstallment { get; set; }
        public int FromMonthlyInstallment { get; set; }
        public int UNumberMonthlyInstallment { get; set; }
        public int FNumberMonthlyInstallment { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }
        public int UntillYear { get; set; }
        public int FromYear { get; set; }
        public int BrandName { get; set; }
        public int Kind { get; set; }
        public int UntillCarFunction { get; set; }
        public int FromCarFunction { get; set; }
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
    public class SearchCarHeavys
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }

        

        public int UntillMonthlyInstallment { get; set; }
        public int FromMonthlyInstallment { get; set; }
        public int UNumberMonthlyInstallment { get; set; }
        public int FNumberMonthlyInstallment { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }
        public int UntillYear { get; set; }
        public int FromYear { get; set; }
        public int BrandName { get; set; }
        public int Kind { get; set; }
        public int UntillCarFunction { get; set; }
        public int FromCarFunction { get; set; }
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
    public class SearchVehicleAccessoriess
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }


        public int Kind { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }


    }
    public class SearchMotorcycles
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }



        public int UntillMonthlyInstallment { get; set; }
        public int FromMonthlyInstallment { get; set; }
        public int UNumberMonthlyInstallment { get; set; }
        public int FNumberMonthlyInstallment { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }
        public int UntillYear { get; set; }
        public int FromYear { get; set; }
        public int BrandName { get; set; }
        public int Kind { get; set; }
        public int UntillCarFunction { get; set; }
        public int FromCarFunction { get; set; }
        public int KindCondition { get; set; }
        public int KindColorOut { get; set; }
        public int KindModelTip { get; set; }
        public int KindFuel { get; set; }
        public int KindCrash { get; set; }
        public int KindPelak { get; set; }

        public bool HasAlarm { get; set; }

    }
    public class SearchAccessoriesDetails
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }



        public int Kind { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }


    }
    public class SearchBoatsAccessoriess
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }


        public int Kind { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }



    }

}