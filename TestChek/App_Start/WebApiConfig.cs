using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TestChek
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}/{test}",
                defaults: new { id = RouteParameter.Optional, test = RouteParameter.Optional }
            );
        }
    }
}
