using IGN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGN.Controllers
{
    public class PageController : Controller
    {




        // GET: Page
        public ActionResult Page(string name)
        {
            return View();
        }

        public ActionResult Profiles(string name)
        {

            if (Session["user"] != null)
            {
                Users u = (Users)Session["user"];

                if (u.UserType == 0)
                {
                    
                    return View();
                }
                else if (u.UserType == 1)
                {
                    return View();
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return View("../Fa/Index");
            }

        }
        // GET: Page/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Page/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Page/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Page/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Page/Edit/5
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

        // GET: Page/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Page/Delete/5
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
