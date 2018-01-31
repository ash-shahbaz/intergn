using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Script.Serialization;
using System.Timers;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace IGN.Models
{
    public class Utility
    {
        public static Users CurrentUser;
        public static string CategoryName;
        public static int NewsID;
        public static List<newsItem> lstNewsItem = new List<newsItem>();
        public static List<Categroy> lstCategory = new List<Categroy>();
        public static List<TopTag> lstTopTagDay = new List<TopTag>();
        public static List<TopTag> lstTopTagMonth = new List<TopTag>();
        public static List<TopTag> lstTopTagYear = new List<TopTag>();
        public static List<TopTag> lstTopTagWeek = new List<TopTag>();
        public static List<Linkestan> lstLinkestan = new List<Linkestan>();
        public static List<AgahiCategory> lstAgaghiCategory = new List<AgahiCategory>();
        public static int PrivinceID;
        public static string CityName = "تهران";
        public static List<tblProvince> lstProvinces = new List<tblProvince>();
        public static List<tblAgahi> lstAgahi = new List<tblAgahi>();
        public static List<tblCity> lstCities = new List<tblCity>();
        public static List<tblRegions> lstRegions = new List<tblRegions>();






        public static string CallApiGetResultCheckUser(string username, string pass)
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
        public static void SyncTags()
        {
            if (lstTopTagDay.Count == 0)
            {
                lstTopTagDay = GetTagTop10DWMY("Day");
                lstTopTagMonth = GetTagTop10DWMY("Month");
                lstTopTagWeek = GetTagTop10DWMY("Week");
                lstTopTagYear = GetTagTop10DWMY("Year");
                lstLinkestan = GetTopLinkestan();
             


            }
        }

        public static List<tblRegions> GetAllRegions()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/tblRegion").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    //var data =  JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    //return data;
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    //string json = JsonConvert.SerializeObject(responseString);

                    //    string q = json_serializer.DeserializeObject(responseString).ToString();


                    List<tblRegions> deserializedProduct = JsonConvert.DeserializeObject<List<tblRegions>>(responseString);

                    return deserializedProduct.ToList();
                }
                else
                {
                    return null;
                }
            }
        }

        public static List<tblCity> GetAllCity()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/Cities").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    //var data =  JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    //return data;
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    //string json = JsonConvert.SerializeObject(responseString);

                    //    string q = json_serializer.DeserializeObject(responseString).ToString();


                    List<tblCity> deserializedProduct = JsonConvert.DeserializeObject<List<tblCity>>(responseString);

                    return deserializedProduct.ToList();
                }
                else
                {
                    return null;
                }
            }
        }

        public static void SyncCategory(object sender, ElapsedEventArgs e)
        {

            if (lstCategory.Count == 0 || lstCategory == null)
            {
                lstCategory = GetAllCategroyFromDB();
            }

        }



        public static List<tblAgahi> GetAllAgahi()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/Agahis").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    //var data =  JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    //return data;
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    //string json = JsonConvert.SerializeObject(responseString);

                    //    string q = json_serializer.DeserializeObject(responseString).ToString();


                    List<tblAgahi> deserializedProduct = JsonConvert.DeserializeObject<List<tblAgahi>>(responseString);

                    return deserializedProduct.ToList();
                }
                else
                {
                    return null;
                }
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


        public static List<TopTag> GetTagTop10DWMY(string whichType)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/tblHashTags/GetTagTop10DWMY-" + whichType + "").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    //var data =  JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    //return data;
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    string json = JsonConvert.SerializeObject(responseString);

                    var q = json_serializer.DeserializeObject(responseString);


                    List<TopTag> deserializedProduct = JsonConvert.DeserializeObject<List<TopTag>>(responseString);
                    return deserializedProduct.Take(10).ToList();
                }
                else
                {
                    return null;
                }
            }
        }

        // for string result
        public static List<newsItem> GetAllNewsByCategoryName(string categoryName)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/Categories/1-" + categoryName + "-$1").Result;
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
                var response = client.GetAsync("api/GettblNews/" + NewsID).Result;
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


        public List<newsItem> GetTop50NewsCategoryByCategoryID(int CID, int PageID)
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

        public static List<Linkestan> GetTopLinkestan()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/tblLinkestans/All-1").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    //var data =  JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    //return data;
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    //string json = JsonConvert.SerializeObject(responseString);

                    //    string q = json_serializer.DeserializeObject(responseString).ToString();


                    List<Linkestan> deserializedProduct = JsonConvert.DeserializeObject<List<Linkestan>>(responseString);

                    return deserializedProduct.ToList();
                }
                else
                {
                    return null;
                }
            }
        }


        public static List<AgahiCategory> GetAgahiCategory()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/AgahiCategories").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    //var data =  JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    //return data;
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    //string json = JsonConvert.SerializeObject(responseString);

                    //    string q = json_serializer.DeserializeObject(responseString).ToString();


                    List<AgahiCategory> deserializedProduct = JsonConvert.DeserializeObject<List<AgahiCategory>>(responseString);

                    return deserializedProduct.ToList();
                }
                else
                {
                    return null;
                }
            }
        }



        public static List<tblProvince> GetProvince()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/Provinces").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    //var data =  JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    //return data;
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    //string json = JsonConvert.SerializeObject(responseString);

                    //    string q = json_serializer.DeserializeObject(responseString).ToString();


                    List<tblProvince> deserializedProduct = JsonConvert.DeserializeObject<List<tblProvince>>(responseString);

                    return deserializedProduct.ToList();
                }
                else
                {
                    return null;
                }
            }
        }

        public static List<tblCity> GetCites(string ProvinceID)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/Cities/"+ ProvinceID + "").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    //var data =  JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    //return data;
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    //string json = JsonConvert.SerializeObject(responseString);

                    //    string q = json_serializer.DeserializeObject(responseString).ToString();


                    List<tblCity> deserializedProduct = JsonConvert.DeserializeObject<List<tblCity>>(responseString);

                    return deserializedProduct.ToList();
                }
                else
                {
                    return null;
                }
            }
        }


       

        public static List<tblRegions> GetRegions(string CityID)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/Regions/" + CityID + "").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    //var data =  JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    //return data;
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    //string json = JsonConvert.SerializeObject(responseString);

                    //    string q = json_serializer.DeserializeObject(responseString).ToString();


                    List<tblRegions> deserializedProduct = JsonConvert.DeserializeObject<List<tblRegions>>(responseString);

                    return deserializedProduct.ToList();
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<tblRegions> GetRegionsByRegionID(string RegionID)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.10:13311");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/tblRegions/" + RegionID + "").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    //var data =  JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    //return data;
                    response.Content = new StringContent(responseString, System.Text.Encoding.UTF8, "application/json");

                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                    //string json = JsonConvert.SerializeObject(responseString);

                    //    string q = json_serializer.DeserializeObject(responseString).ToString();


                    List<tblRegions> deserializedProduct = JsonConvert.DeserializeObject<List<tblRegions>>(responseString);

                    return deserializedProduct.ToList();
                }
                else
                {
                    return null;
                }
            }
        }


        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        static readonly string PasswordHash = "P@@Sw0rd";
        static readonly string SaltKey = "S@LT&KEY";
        static readonly string VIKey = "@1B2c3D4e5F6g7H8";
        public static string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Decrypt(string encryptedText)
		{
			byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
			byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
			var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

			var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
			var memoryStream = new MemoryStream(cipherTextBytes);
			var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
			byte[] plainTextBytes = new byte[cipherTextBytes.Length];

			int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
			memoryStream.Close();
			cryptoStream.Close();
			return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
		}

    }

    public class AgahiCategory
    {
        public int AgahiCategoryID { get; set; }
        public string AgahiCategoryName { get; set; }
        public Nullable<int> ParrentID { get; set; }
        public Nullable<int> Priority { get; set; }
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

    public class TopTag
    {
        public string HashtagName { get; set; }
        public Nullable<int> repcount { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Day { get; set; }


    }

    public class Linkestan
    {
        public int LikestanID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string LinkName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> LanguageID { get; set; }
        public Nullable<System.DateTime> DateRegister { get; set; }
        public string Title { get; set; }
        public string Keywords { get; set; }




    }

    public class tblProvince
    {
        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; }
    }
    public  class tblCity
    {
        public int CityID { get; set; }
        public Nullable<int> ProvinceId { get; set; }
        public string CityName { get; set; }
        public Nullable<int> CountryID { get; set; }
    }



    public  class tblRegions
    {
        public int RegionID { get; set; }
        public Nullable<int> CityID { get; set; }
        public string RegionName { get; set; }
    }

    public class tblAgahi
    {
        public int AgahiID { get; set; }
        public Nullable<int> CategoryAgahiID { get; set; }
        public Nullable<int> AgahiServiceID { get; set; }
        public string AgahiTitle { get; set; }
        public Nullable<bool> NewOrUsed { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public string RegisterDate { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> AdminUserID { get; set; }
        public Nullable<System.DateTime> AdminAgreeDate { get; set; }
        public Nullable<byte> AgahiStatus { get; set; }
    
        public Nullable<int> LanguageID { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public Nullable<int> RegionID { get; set; }
        public string Tell { get; set; }
        public string Mobile { get; set; }
        public Nullable<int> PriceTypeID { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> PlanShowAgahiID { get; set; }
        public Nullable<bool> HasImage { get; set; }
        public string Chatable { get; set; }
        public string OnTime { get; set; }
        public Nullable<bool> SpecialAgahi { get; set; }
    }
   

}