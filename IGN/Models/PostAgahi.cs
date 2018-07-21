using IGN.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace IGN.Models
{
    public class PostAgahi
    {

        public static string AddRegisterAccessoriesDetails(RegisterAccessoriesDetails s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterAccessoriesDetails", s ).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }
        public static string AddRegisterCarHeavys(RegisterCarHeavys s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterCarHeavys", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }
        public static string AddRegisterCarRidings(RegisterCarRidings s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterCarRidings", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }
        public static string AddRegisterCases(RegisterCases s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterCases", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }
        public static string AddRegisterElectronicss(RegisterElectronicss s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterElectronicss", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";
            }
        }

        public static string AddRegisterLapTops(RegisterLapTops s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterLapTops", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }

        public static string AddRegisterMobileTablets(RegisterMobileTablets s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterMobileTablets", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }


        public static string AddRegisterMotorcycles(RegisterMotorcycles s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterMotorcycles", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }


        public static string AddRegisterPersonalEntertainments(RegisterPersonalEntertainments s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterPersonalEntertainments", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";
                
            }
        }


        public static string AddRegisterRentHouseSubs(RegisterRentHouseSubs s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterRentHouseSubs", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }


        public static string AddRegisterRentOfficeSubs(RegisterRentOfficeSubs s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterRentOfficeSubs", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }
        public static string AddRegisterSaleApartSubs(RegisterSaleApartSubs s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterSaleApartSubs", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }
        public static string AddRegisterSaleLandSubs(RegisterSaleLandSubs s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterSaleLandSubs", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }
        public static string AddRegisterSaleOfficeSubs(RegisterSaleOfficeSubs s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterSaleOfficeSubs", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }
        public static string AddRegisterServicesEmployments(RegisterServicesEmployments s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterServicesEmployments", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }
        public static string AddRegisterServicesHouseSubs(RegisterServicesHouseSubs s)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Utility.HostAgahi);
                var response = client.PostAsJsonAsync("api/AddRegisterServicesHouseSubs", s).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "1";
                }
                else
                    return "0";

            }
        }
    }
}