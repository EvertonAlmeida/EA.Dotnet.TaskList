namespace EA.Dotnet.TaskList.Infra.Data.Interfaces
{
    public interface IContextManager
    {
        IDbContext GetContext();
    }
}
