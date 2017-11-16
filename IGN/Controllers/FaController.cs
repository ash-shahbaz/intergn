using IGN.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using System.Web.Script.Serialization;

namespace IGN.Controllers
{
    public class FaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult News(string CategoryName,string NewsID,string Title)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cat(string name)
        {

            //Utility.ListCategories();
            ViewBag.CategoryID = name;
            return View();
        }
        public ActionResult Search(string name)
        {

            return View();
        }


        public ActionResult tags(string tagName)
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }


        public ActionResult source(string tagName)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }





        //public ActionResult Login()
        //{
           
            
        //}

        //public ActionResult Register()
        //{

        //}

        public string Login(Users u )
        {

            Users user = u;
            Session["user"] = u;
            if (u.UserType == 0)
            {
                return new JavaScriptSerializer().Serialize(u);

            }
            else if (u.UserType == 1)
            {
                return new JavaScriptSerializer().Serialize(u);

            }
            else
            {
                return new JavaScriptSerializer().Serialize(u);
            }
        }
        public ActionResult MyProfile()
        {
            
            if (Session["user"] != null)
            {
                Users u = (Users)Session["user"];
                if (u.UserType == 0)
                {
                    return View();
                }
                else if(u.UserType == 1)
                {
                    return View();
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return View("Index");
            }
            
        }

        public string CheckUser(string username,string pass)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/users/"+username +"-" + pass +"").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    //var data =  JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    //return data;
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    return responseString;
                }
                else
                {
                    return null;
                }
            }
            
        }









        public ActionResult AboutUs(string id)
        {
            return View();
        }

        public ActionResult ContactUs(string id)
        {
            return View();
        }

        public ActionResult NewsResource(string id)
        {
            return View();
        }
        public ActionResult Setting(string id)
        {
            return View();
        }
        public ActionResult MyFriends(string id)
        {
            return View();
        }


        public ActionResult BackLinks(string id)
        {
            return View();
        }

        public ActionResult BackLinkAdd(string id)
        {
            return View();
        }

        public ActionResult PostSent(string id)
        {
            return View();
        }
        public ActionResult NewsFavorites(string id)
        {
            return View();
        }


        private static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
    }


}