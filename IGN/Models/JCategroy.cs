using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGN.Models
{
    public class Categroy
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public Nullable<int> ParrentID { get; set; }
        public Nullable<int> LanguageID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}