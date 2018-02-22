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
                var response = client.PostAsJsonAsync("api/SearchAccessoriesDetails", s).Result;
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
                    var response = client.PostAsJsonAsync("api/SearchAllAgahis", s).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Console.Write("Success");
                    }
                    else
                        Console.Write("Error");
                
                return "OK";

            }
        }
        public static string SearchBoatsAccessoriess(SearchBoatsAccessoriess s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchBoatsAccessoriess", s).Result;
                if (response.IsSuccessStatusCode)
                {
                   
                    return response.Content.ReadAsStringAsync().Result;

                }
                else
                    return "Nothing";



            }
        }
        public static string SearchCarBoatAccs(SearchCarBoatAccs s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchCarBoatAccs", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchCarHeavys(SearchCarHeavys s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchCarHeavys", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchCarRidings(SearchCarRidings s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchCarRidings", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchCases(SearchCases s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchCases", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchElectronicss(SearchElectronicss s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchElectronicss", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchLapTops(SearchLapTops s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchLapTops", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchMobileTablets(SearchMobileTablets s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchMobileTablets", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchMotorAccessoriess(SearchMotorAccessoriess s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchMotorAccessoriess", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                    
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchMotorcycles(SearchMotorcycles s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchMotorcycles", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchPersonalEntertainments(SearchPersonalEntertainments s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchPersonalEntertainments", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchRentHomes(SearchRentHomes s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchRentHomes", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchRentHouseSubs(SearchRentHouseSubs s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchRentHouseSubs", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchRentOffices(SearchRentOffices s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchRentOffices", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchRentOfficeSubs(SearchRentOfficeSubs s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchRentOfficeSubs", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchSaleApartSubs(SearchSaleApartSubs s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchSaleApartSubs", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchSaleHomes(SearchSaleHomes s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchSaleHomes", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchSaleLandSubs(SearchSaleLandSubs s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchSaleLandSubs", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchSaleOffices(SearchSaleOffices s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchSaleOffices", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchSaleOfficeSubs(SearchSaleOfficeSubs s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchSaleOfficeSubs", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchServicesEmployments(SearchServicesEmployments s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchServicesEmployments", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchServicesHouses(SearchServicesHouses s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchServicesHouses", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchServicesHouseSubs(SearchServicesHouseSubs s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchServicesHouseSubs", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

                return "OK";

            }
        }
        public static string SearchVehicleAccessoriess(SearchVehicleAccessoriess s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/SearchVehicleAccessoriess", s).Result;
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