﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGN.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Tell { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string SecondryPass { get; set; }
        public string UserLinkPage { get; set; }
        public string PersonelImageUrl { get; set; }
        public string RegisterDate { get; set; }
        public string NationalityID { get; set; }
        public string PostalCode { get; set; }
        public string BussinessFieldID { get; set; }
        public string BirthDate { get; set; }
        public string NickName { get; set; }
        public Nullable<int> LanguageID { get; set; }
        public Nullable<byte> UserType { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}