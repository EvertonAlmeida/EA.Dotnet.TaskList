using EA.Dotnet.TaskList.Infra.Data.Interfaces;
using System.Data.Entity;
using System;

namespace EA.Dotnet.TaskList.Infra.Data.Context
{
    public class BaseDbContext : DbContext, IDbContext
    {
        public BaseDbContext(string nameOrConnectionString)
          : base(nameOrConnectionString)
        {

        }

        IDbSet<T> IDbContext.Set<T>()
        {
            return base.Set<T>();
        }
    }
}
