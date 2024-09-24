using ADONETSQLServerConnectionPresentation.App_Start;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ADONETSQLServerConnectionPresentation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static IServiceProvider _serviceProvider;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IServiceCollection services = new ServiceCollection();
            ConfigureServices(services);

            _serviceProvider = services.BuildServiceProvider();

            DependencyResolver.SetResolver(new MyDependencyResolver(_serviceProvider));
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ApplicationConfig>();
        }
    }
}
