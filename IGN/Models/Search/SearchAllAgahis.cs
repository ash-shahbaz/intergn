using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGN.Models.Search
{
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
}