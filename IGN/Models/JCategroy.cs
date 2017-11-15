using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGN.Models
{
    public class JCategroy
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ParrentID { get; set; }
        public int LanguageID { get; set; }
        public bool IsDeleted { get; set; }
    }
}