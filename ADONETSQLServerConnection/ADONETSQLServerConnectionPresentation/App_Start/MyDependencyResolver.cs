using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADONETSQLServerConnectionPresentation.App_Start
{
    public class MyDependencyResolver : IDependencyResolver
    {
        private readonly IServiceProvider _serviceProvider;

        public MyDependencyResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public object GetService(Type serviceType)
        {
            return _serviceProvider.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _serviceProvider.GetServices(serviceType);
        }
    }
}