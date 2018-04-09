using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TestApi.Interface;
using TestApi.Logic;
using TestApi.DataAccessor;
using Microsoft.Practices.Unity;
using Unity.WebApi;

namespace TestApi.App_Start
{
    public class UnityConfig
    {
        /// <summary>
        /// This method is used to regist container components.
        /// </summary>
        /// <param name="config">Instance of HttpConfiguration which is used by current service.</param>
        public static void RegisterComponents(HttpConfiguration config)
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            // EmOperation
            container.RegisterType<IEmOperationInterface, EmOperationLogic>();
            container.RegisterType<IEmOperationDataSource, EmOperationDataSource>();
            config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}