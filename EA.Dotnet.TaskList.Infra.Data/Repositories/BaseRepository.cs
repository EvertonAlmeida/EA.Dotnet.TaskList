using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EA.Dotnet.TaskList.Domain.Interfaces.Repository;
using System.Data.Entity;
using EA.Dotnet.TaskList.Infra.Data.Context;
using System.Linq;
using EA.Dotnet.TaskList.Infra.Data.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace EA.Dotnet.TaskList.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        protected IDbSet<TEntity> DbSet;
        protected readonly IDbContext _DbContext;

        private readonly ContextManager _contextManager = ServiceLocator.Current.GetInstance<IContextManager>() as ContextManager;

        public BaseRepository()
        {
            _DbContext = _contextManager.GetContext();
            DbSet = _DbContext.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual void Update(TEntity obj)
        {
            var entry = _DbContext.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
        }

        public virtual void Remove(TEntity obj)
        {
            DbSet.Remove(obj);
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public void Dispose()
        {
            _DbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
