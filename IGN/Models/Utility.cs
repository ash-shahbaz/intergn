using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Script.Serialization;
using System.Timers;
using Newtonsoft.Json.Linq;

namespace IGN.Models
{
    public  class Utility
    {
        public static Users CurrentUser;
        public static string CategoryName;
        public static int NewsID;
        public static List<newsItem> lstNewsItem = new List<newsItem>();
        public static List<Categroy> lstCategory = new List<Categroy>();



        public static string CallApiGetResultCheckUser(string username , string pass)
        {
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/users/" + username + "-" + pass + "").Result;
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

        public static void SyncNews(object sender, ElapsedEventArgs e)
        {
            if (lstNewsItem.Count == 0)
            {
                lstNewsItem = GetAllNews();
            }

          

        }

        public static void SyncCategory(object sender, ElapsedEventArgs e)
        {

            if (lstCategory.Count == 0 || lstCategory == null)
            {
                lstCategory = GetAllCategroyFromDB();
            }

        }





        public static List<newsItem> GetAllNews()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("/api/tblNews/All-1").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;
                    
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    string json = JsonConvert.SerializeObject(responseString);

                    List<newsItem> deserializedProduct = JsonConvert.DeserializeObject<List<newsItem>>(responseString);
                    return deserializedProduct;
                }
                else
                {
                    return null;
                }
            }
        }

        public static List<Categroy> GetAllCategroyFromDB()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/tblCategories").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    string json = JsonConvert.SerializeObject(responseString);

                    List<Categroy> deserializedProduct = JsonConvert.DeserializeObject<List<Categroy>>(responseString);
                    return deserializedProduct;
                }
                else
                {
                    return null;
                }
            }
        }

        public static List<newsItem> GetAllNewsByCategoryName(string categoryName)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/Categories/1-" + categoryName +"-$1").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    //var data =  JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    //return data;
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    string json = JsonConvert.SerializeObject(responseString);

                    var q = json_serializer.DeserializeObject(responseString);


                    List<newsItem> deserializedProduct = JsonConvert.DeserializeObject<List<newsItem>>(responseString);
                    return deserializedProduct;
                }
                else
                {
                    return null;
                }
            }
        }

        public static string GetNewsByNewsID(string NewsID)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/GettblNews/" + NewsID ).Result;
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
        
        public static string CleanTitle(string title)
        {
            return title.Replace("+", " ").Replace("?", " ").Replace("*", " ").Replace(";", " ").Replace(",", " ").Replace(".", " ").Replace(":", " ").Replace("؛", " ").Replace("؟", " ").Replace("»", " ").Replace("«", " ").Replace("!", " ").Replace("(", " ").Replace(")", " ").Replace("{", " ").Replace("}", " ").Replace("[", " ").Replace("]", " ").Replace("/", " ").Replace("-", " ");

        }


        public List<newsItem> GetTop50NewsCategoryByCategoryID(int CID,int PageID)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/Categories/1-" + CID + "-" + PageID + "").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    //var data =  JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    //return data;
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    //string json = JsonConvert.SerializeObject(responseString);

                    string q = json_serializer.DeserializeObject(responseString).ToString();


                    List<newsItem> deserializedProduct = JsonConvert.DeserializeObject<List<newsItem>>(q);

                    return deserializedProduct;
                }
                else
                {
                    return null;
                }
            }
        }

    }


    public class newsItem
    {

        public int TempID { get; set; }
        public Nullable<int> NewsID { get; set; }
        public string Title { get; set; }
        public string rssname { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
        public string Link { get; set; }
        public Nullable<long> ViewNumber { get; set; }
        public Nullable<int> Likes { get; set; }
        public Nullable<int> Unlike { get; set; }
        public Nullable<int> RecordType { get; set; }
        public Nullable<int> LanguageID { get; set; }
        public Nullable<int> CategoryID { get; set; }
    }
}