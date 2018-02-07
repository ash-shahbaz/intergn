using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGN.Models.Search
{
    public class SearchMobileTablets
    {
        public int CategoryID { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelectID { get; set; }
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
}