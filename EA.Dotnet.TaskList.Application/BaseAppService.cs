using EA.Dotnet.TaskList.Application.Interfaces;
using EA.Dotnet.TaskList.Infra.Data.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace EA.Dotnet.TaskList.Application
{
    public class BaseAppService : IBaseAppService
    {
        private IUnitOfWork _uow;

        public void BeginTransaction()
        {
            _uow = ServiceLocator.Current.GetInstance<IUnitOfWork>();
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.SaveChanges();
        }
    }
}
