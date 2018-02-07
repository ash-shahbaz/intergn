using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGN.Models.Search
{
    public class SearchRentOffices
    {
        public int CategoryID { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelectID { get; set; }
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
}