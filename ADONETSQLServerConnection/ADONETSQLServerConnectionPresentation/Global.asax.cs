using ADONETSQLServerConnection.Application.Configurations;
using ADONETSQLServerConnection.Application.Interfaces;
using ADONETSQLServerConnection.DataAccess.DataAccess;
using ADONETSQLServerConnection.DataAccess.Repositories;
using ADONETSQLServerConnectionPresentation.App_Start;
using ADONETSQLServerConnectionPresentation.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ADONETSQLServerConnectionPresentation
{
    public class MvcApplication : HttpApplication
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
            var connectionString = ConfigurationManager.ConnectionStrings["WebSiteDataBase"].ConnectionString;
            services.AddSingleton<IApplicationConfig>(provider => new ApplicationConfig(connectionString));
            services.AddScoped<IDataBaseAccess, DataBaseAccess>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<HomeController>();
        }
    }
}
