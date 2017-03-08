using EA.Dotnet.TaskList.Application.AutoMapper;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EA.Dotnet.TaskList.Presentation.MVC
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
