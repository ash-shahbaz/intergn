using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace IGN.Models
{
    public static class Utility
    {
        public static Dictionary<string, string> ListCategories()
        {

            Dictionary<string, string> lstC = new Dictionary<string, string>();

            var q = GetDataFromUrl("api/tblCategories/2-1");

            //lstC.Add();

            return lstC;


        }

        private static string GetDataFromUrl(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:13311/");
            // Add an Accept header for JSON format.  
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // List all Names.  
            HttpResponseMessage response = client.GetAsync(url).Result;  // Blocking call!  
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Request Message Information:- \n\n" + response.RequestMessage + "\n");
                Console.WriteLine("Response Message Header \n\n" + response.Content.Headers + "\n");
                return response.ToString();
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return response.ToString();
            }
            
        }


    }
}