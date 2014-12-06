using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;

namespace TransactionTracker
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        public IKernel Kernel { get; private set; }

        public NinjectDependencyResolver(IKernel kernel)
        {
            Kernel = kernel;
        }

        public object GetService(Type serviceType)
        {
            return Kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Kernel.GetAll(serviceType);
        }
    }
}