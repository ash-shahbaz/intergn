using IGN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace IGN
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static Timer UpdateNewsTimer;
        protected void Application_Start()
        {

            Utility.lstNewsItem = Utility.GetAllNews();
            Utility.lstCategory= Utility.GetAllCategroyFromDB();
            Utility.lstAgaghiCategory = Utility.GetAgahiCategory();
            Utility.SyncTags();

            UpdateNewsTimer = new System.Timers.Timer(200000);
            // Hook up the Elapsed event for the timer. 
            UpdateNewsTimer.Elapsed += Utility.SyncNews;
            UpdateNewsTimer.Enabled = true;


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
