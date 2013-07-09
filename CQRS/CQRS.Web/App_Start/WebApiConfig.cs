using System.Web.Http;

namespace CQRS.Web.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "Main", routeTemplate: "{controller}/{id}",
                defaults: new {controller = "Home", id = RouteParameter.Optional});
        }
    }
}
