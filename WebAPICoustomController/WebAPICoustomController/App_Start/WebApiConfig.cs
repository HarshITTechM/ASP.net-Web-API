﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;

namespace WebAPICoustomController
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
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // my new route
            config.Routes.MapHttpRoute(
                name: "student",
                routeTemplate: "api/std/{id}",
                defaults: new { controller = "school", id = RouteParameter.Optional },
                constraints: new { id = "/d+" }
            );
        }
    }
}
