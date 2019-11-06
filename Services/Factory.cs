using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Services
{
    public class Factory : IDependencyResolver
    {
        public Factory() { }
        public Factory(Action<ServiceProvider> registerServices)
        {
            registerServices(ServiceProvider.Instance);
        }
        public TType GetRequiredInstance<TType>() where TType : class
        {
            var service = ServiceProvider.Instance.GetService<TType>() as TType;

            if (service is null)
                throw new InvalidOperationException();

            return service;
        }

        public object GetService(Type serviceType)
        {
            return ServiceProvider.Instance.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            List<object> servies = new List<object>();
            servies.Add(ServiceProvider.Instance.GetService(serviceType));
            return servies;
        }
    }
}
