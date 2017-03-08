using EA.Dotnet.TaskList.Infra.Data.Interfaces;
using System.Web;

namespace EA.Dotnet.TaskList.Infra.Data.Context
{
    public class ContextManager : IContextManager
    {
        private const string ContextKey = "ContextManager.Context";

        public IDbContext GetContext()
        {
            if (HttpContext.Current.Items[ContextKey] == null)
            {
                HttpContext.Current.Items[ContextKey] = new TaskListContext();
            }

            return (IDbContext)HttpContext.Current.Items[ContextKey];
        }
    }
}
