using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iGNProject.Models.Search
{
    public class SearchSaleLandSubs
    {
        public int CategoryID { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelectID { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }
        public int CitySideTypeID { get; set; }
        public int UserTypeID { get; set; }
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
}