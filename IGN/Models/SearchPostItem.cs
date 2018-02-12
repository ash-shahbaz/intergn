using System;
using System.Net.Http;
using IGN.Models.Search;
using System.Web.Helpers;
using System.Net;
using System.Text;
using System.IO;

namespace IGN.Models
{
    public static class SearchPostItem
    {
        public static string SearchAccessoriesDetails(SearchAccessoriesDetails s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/Search", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchAllAgahis(SearchAllAgahis s)
        {
            using (var client = new HttpClient())
            {  
                    client.BaseAddress = new Uri(Utility.HostAgahi);
                    var response = client.PostAsJsonAsync("api/Search", s).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Console.Write("Success");
                    }
                    else
                        Console.Write("Error");
                
                return "OK";

            }
        }



    }
}