﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FamilyTree.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Login",
                url: "login",
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional },
                namespaces: new[] { "FamilyTree.Web.Controllers" }
            );
            routes.MapRoute(
                name: "Logout",
                url: "logout",
                defaults: new { controller = "Login", action = "LogOff", id = UrlParameter.Optional },
                namespaces: new[] { "FamilyTree.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Register",
                url: "register",
                defaults: new { controller = "Login", action = "Register", id = UrlParameter.Optional },
                namespaces: new[] { "FamilyTree.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "FamilyTree.Web.Controllers" }
            );
        }
    }
}
