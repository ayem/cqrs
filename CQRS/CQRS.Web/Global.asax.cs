using System.Web;
using System.Web.Http;
using CQRS.Web.App_Start;

namespace CQRS.Web
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}