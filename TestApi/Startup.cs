using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using TestApi.App_Start;

[assembly: OwinStartup(typeof(TestApi.Startup))]

namespace TestApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);  // Use Cors in message handling.
            HttpConfiguration config = new HttpConfiguration();
            SwaggerConfig.Register(config);         // Register swagger middleware.
            UnityConfig.RegisterComponents(config); // Use unity as ioc container. Global dependency resolver.
            WebApiConfig.Register(config);          // Setup web api route SocialSecurity.
            app.UseWebApi(config);
        }
    }
}
