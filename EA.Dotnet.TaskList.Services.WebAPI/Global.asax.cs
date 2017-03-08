using EA.Dotnet.TaskList.Application.AutoMapper;
using System.Web.Http;

namespace EA.Dotnet.TaskList.Services.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
