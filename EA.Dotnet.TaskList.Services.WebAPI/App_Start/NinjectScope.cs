﻿using System.Web.Http.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using Ninject.Activation;
using Ninject.Parameters;
using Ninject.Syntax;

namespace EA.Dotnet.TaskList.Services.WebAPI
{
    public class NinjectScope : IDependencyScope
    {
        protected IResolutionRoot ResolutionRoot;
        public NinjectScope(IResolutionRoot kernel)
        {
            ResolutionRoot = kernel;
        }
        public object GetService(Type serviceType)
        {
            IRequest request = ResolutionRoot.CreateRequest(serviceType, null, new Parameter[0], true, true);
            return ResolutionRoot.Resolve(request).SingleOrDefault();
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            IRequest request = ResolutionRoot.CreateRequest(serviceType, null, new Parameter[0], true, true);
            return ResolutionRoot.Resolve(request).ToList();
        }
        public void Dispose()
        {
            IDisposable disposable = (IDisposable)ResolutionRoot;
            if (disposable != null) disposable.Dispose();
            ResolutionRoot = null;
        }
    }
}