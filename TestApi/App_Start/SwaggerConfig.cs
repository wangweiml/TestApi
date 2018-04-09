using System;
using System.Web.Http;
using Swashbuckle.Application;

namespace TestApi.App_Start
{
    public class SwaggerConfig
    {
        /// <summary>
        /// Static method called to register swagger into the service.
        /// </summary>
        /// <param name="config">Current server http feature object.</param>
        public static void Register(HttpConfiguration config)
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            config
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "TestApi");
                    c.IncludeXmlComments(GetXmlCommentsPath(thisAssembly.GetName().Name));
                })
                .EnableSwaggerUi(c =>
                {
                    c.DisableValidator();
                });
        }

        protected static string GetXmlCommentsPath(string name)
        {
            return string.Format(@"{0}\bin\{1}.XML", AppDomain.CurrentDomain.BaseDirectory, name);
        }
    }
}