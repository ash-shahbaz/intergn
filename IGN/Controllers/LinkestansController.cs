using IGN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace IGN.Controllers
{
    public class LinkestansController : Controller
    {
        // GET: Linkestans
        public ActionResult Index()
        {
            return View();
        }

        // GET: Linkestans/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Linkestans/Create
        public ActionResult Create()
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
                    client.BaseAddress = new Uri("http://192.168.1.10:13311/api/tblLinkestans/PosttblLinkestan");

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

        // GET: Linkestans/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Linkestans/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Linkestans/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Linkestans/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
