namespace EA.Dotnet.TaskList.Application.Interfaces
{
    public interface IBaseAppService
    {
        void BeginTransaction();
        void Commit();
    }
}
