﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Mvc_Bootstrap_Knockout.DAL;
using System.Data.Entity;


namespace Mvc_Bootstrap_Knockout
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var bookContext = new BookContext();
            Database.SetInitializer(new BookInitializer());
            bookContext.Database.Initialize(true);
        }
    }
}
