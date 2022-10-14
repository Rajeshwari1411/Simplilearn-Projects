﻿using System.Web.Optimization;
using System.Web.Routing;
using System.Collections.Generic;
using System.Web;
using System;
using WEB_schoolmanagement;
using System.Web.Security;
using System.Web.SessionState;

namespace WEB_schoolmanagement
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

