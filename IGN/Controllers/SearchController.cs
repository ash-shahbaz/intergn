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
        public List<tblAgahi> Search(PublicSearchs item)
        {
           
            return null;
        }

        
        public List<tblAgahi> SearchAmlak(SearchAmlaks item)
        {
            return null;
        }
    }
    public class PublicSearchs
    {

        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public string KindSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }

    }
    public class SearchAmlaks
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public string KindSelect { get; set; }
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
}