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
        public List<tblAgahi> Search(SearchItems s)
        {




            return null;
        }


    }
    public class SearchItems
    {

        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public string KindSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }

    }
}