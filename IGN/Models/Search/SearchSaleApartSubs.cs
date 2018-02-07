using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGN.Models.Search
{
    public class SearchSaleApartSubs
    {
        public int CategoryID { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelectID { get; set; }
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
}