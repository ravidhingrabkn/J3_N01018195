using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace J3_N01018195
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{actiion}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
