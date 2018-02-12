using IGN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace IGN.Controllers
{
    public class LinkestanController : Controller
    {
        // GET: Linkestans
        public ActionResult Index()
        {
            return View();
        }
        [ActionName("لینک-ها")]
        public ActionResult لینک_ها(string name)
        {
            if (name == null)
            {
                ViewBag.Status = 3;
                return View();
            }
            else
            {
                string[] arr = name.Split('-');

                if (arr[0] == "Det")
                {
                    ViewBag.Status = 0;
                    ViewBag.BackLinkID = arr[1];
                    ViewBag.LinkName = arr[2];
                    return View();
                }
                else if (arr[0] == "Cat")
                {
                    ViewBag.Status = 1;
                    ViewBag.CateID = arr[1];
                    ViewBag.CateName = arr[2];

                    return View();
                }
                else if (arr[0] == "CID")
                {
                    ViewBag.Status = 5;
                    ViewBag.CateID = arr[1];


                    return View();
                }
                else if (arr[0] == "Key")
                {
                    ViewBag.Status = 2;
                    ViewBag.Keywords = arr[1];
                    return View();
                }
                else if (arr[0] == "KeyCat")
                {
                    ViewBag.Status = 4;
                    ViewBag.CateID = arr[1];
                    ViewBag.Keywords = arr[2];

                    return View();
                }
                else
                {
                    ViewBag.Status = 3;

                    return View();
                }
            }
        }

        [ActionName("افزودن-لینک")]
        public ActionResult افزودن_لینک(string id)
        {
            return View();
        }


       

        // POST: Linkestans/Create
        [HttpPost]
        public void Create(Linkestan collection)
        {
            try
            {

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(""+ Utility.HostAgahi + "/api/tblLinkestans/PosttblLinkestan");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<Linkestan>("Linkestan", collection);
                    postTask.Wait();

                    var result = postTask.Result;
                    //if (result.IsSuccessStatusCode)
                    //{
                    //    return RedirectToAction("Index");
                    //}
                    //return View();
                }
            }
            catch
            {
                //return View();
            }
        }

   

     
    }
}
