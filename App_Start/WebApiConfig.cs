using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI_All_Sesions.UtilityClasses;

namespace WebAPI_All_Sesions
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.DependencyResolver = new APIDependancyResolve(); 
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
