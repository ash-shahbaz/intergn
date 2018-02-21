using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iGNProject.Models.Search
{
    public class SearchAllAgahis
    {

        public int CategoryID { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelectID { get; set; }
        public string MahaleSelect { get; set; }
        public int Kind { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }

    }
}