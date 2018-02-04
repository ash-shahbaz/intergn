using IGN.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Xml;


namespace IGN.Controllers
{
    public class SyncController : Controller
    {
        // GET: Sync
        public string DataTableToJSONWithJSONNet(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }



        public string ListAgahiCategory()
        {
            return  JsonConvert.SerializeObject(Utility.lstAgaghiCategory);
        }

        public string GetData()
        {
            //using (DbIGNSEntities db = new DbIGNSEntities())
            //{
            //    //foreach (var item in db.tblMagazines)
            //    //{
            //    var item = db.tblMagazines.FirstOrDefault().RssUrl;

            //        WebRequest request = WebRequest.Create(item);
            //        WebResponse response = request.GetResponse();
            //        System.IO.Stream rssStream = response.GetResponseStream();
            //        XmlDocument xmlDoc = new XmlDocument();
            //        xmlDoc.Load(rssStream);


            //        string mydata = "";
            //        XmlNodeList xmlNodeList = xmlDoc.SelectNodes("rss/channel/item");
            //        for (int i = 0; i < xmlNodeList.Count; i++)
            //        {
            //            //XmlNode xmlNode;
            //            //xmlNode = xmlNodeList.Item(i).SelectSingleNode("title");
            //            ////xmlNode.InnerText;
            //            //mydata += xmlNode.InnerText;


            //        tblNew n = new tblNew();
            //        n.Title = xmlNodeList.Item(i).SelectSingleNode("title").InnerXml;
            //        n.PubDate = xmlNodeList.Item(i).SelectSingleNode("pubDate").InnerXml;
            //        n.Descriptions = xmlNodeList.Item(i).SelectSingleNode("description").InnerXml;
            //        n.LinkUrl = xmlNodeList.Item(i).SelectSingleNode("link").InnerXml;
            //        n.ImageUrl = null;
            //        db.tblNews.Add(n);
            //        db.SaveChanges();
            //    }


            //    //}

            //}





            //XmlTextReader reader = new XmlTextReader("http://www.varzesh3.com/rss/all");
            //DataSet ds = new DataSet();
            //ds.ReadXml(reader);
            //var q = ds.Tables[2];
            //var mydata = DataTableToJSONWithJSONNet(ds.Tables[2]);


            ////XmlTextReader reader2 = new XmlTextReader("http://www.dotnettips.info/rss");
            ////DataSet ds2 = new DataSet();
            ////ds2.ReadXml(reader2);
            ////var q2 = ds2.Tables[2];
            ////var mydata2 = DataTableToJSONWithJSONNet(ds2.Tables[2]);

            //WebRequest request = WebRequest.Create("http://www.dotnettips.info/rss");
            //WebResponse response = request.GetResponse();
            //System.IO.Stream rssStream = response.GetResponseStream();
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(rssStream);


            //XmlNodeList xmlNodeList = xmlDoc.SelectNodes("rss/channel/item");


            //for (int i = 0; i < xmlNodeList.Count; i++)
            //{
            //    XmlNode xmlNode;

            //    xmlNode = xmlNodeList.Item(i).SelectSingleNode("title");
            //    //xmlNode.InnerText;
            //}

            return "";

        }


        public string GetRegionByCityID(string name)
        {

            return  JsonConvert.SerializeObject(Utility.GetRegions(name));
        }

        public string GetCityByProvinceID(string name)
        {

            return JsonConvert.SerializeObject(Utility.GetCites(name));
        }

        public string GetPriceType()
        {

            return JsonConvert.SerializeObject(Utility.GetPriceType());
        }

        public string GetRegionByCityName(string name)
        {
            var q = Utility.lstCities.Where(p => p.CityName == name).FirstOrDefault();

            return JsonConvert.SerializeObject(Utility.lstRegions.Where(p => p.CityID == q.CityID));
        }

        public string GetCityByProvinceName(string name)
        {

            var q = Utility.lstProvinces.Where(p => p.ProvinceName == name).FirstOrDefault();

            return JsonConvert.SerializeObject(Utility.lstCities.Where(p=> p.ProvinceId == q.ProvinceID));
        }


    }
}