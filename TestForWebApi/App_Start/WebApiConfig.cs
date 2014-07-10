using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Thinktecture.IdentityModel.Http.Cors.WebApi;

namespace TestForWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            WebApiCorsConfiguration corsConfig = new WebApiCorsConfiguration();
            corsConfig.RegisterGlobal(config);

            corsConfig.ForAllResources().ForAllOrigins().AllowAll();
        }
    }
}
