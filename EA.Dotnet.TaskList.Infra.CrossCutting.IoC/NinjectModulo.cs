using Ninject.Modules;
using EA.Dotnet.TaskList.Application.Interfaces;
using EA.Dotnet.TaskList.Application;
using EA.Dotnet.TaskList.Domain.Interfaces.Services;
using EA.Dotnet.TaskList.Domain.Services;
using EA.Dotnet.TaskList.Infra.Data.Repositories;
using EA.Dotnet.TaskList.Domain.Interfaces.Repository;
using EA.Dotnet.TaskList.Infra.Data.Repositories.ReadOnly;
using EA.Dotnet.TaskList.Domain.Interfaces.ReadOnly;
using EA.Dotnet.TaskList.Infra.Data.Context;
using EA.Dotnet.TaskList.Infra.Data.Interfaces;
using EA.Dotnet.TaskList.Infra.Data.UoW;

namespace EA.Dotnet.TaskList.Infra.CrossCutting.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {
            // Application
            Bind<ITarefaAppService>().To<TarefaAppService>();
            Bind<IBaseAppService>().To<BaseAppService>();

            // service
            Bind<ITarefaService>().To<TarefaService>();

            // data repos
            Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
            Bind<ITarefaRepository>().To<TarefaRepository>();

            // data repos read only
            Bind<ITarefaReadOnlyRepository>().To<TarefaReadOnlyRepository>();

            // data configs
            Bind<IContextManager>().To<ContextManager>();
            Bind<IDbContext>().To<TaskListContext>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
