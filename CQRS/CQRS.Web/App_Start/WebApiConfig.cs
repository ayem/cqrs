using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CQRS.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(name: "Main", routeTemplate: "{controller}", defaults: new { controller = "Home" });
        }
    }
}
