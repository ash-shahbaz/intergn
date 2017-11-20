using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace IGN.Models
{
    public static class Utility
    {
        public static Users CurrentUser;
        public static string CategoryName;
        public static int NewsID;


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



    }
}