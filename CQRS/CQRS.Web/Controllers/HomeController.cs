using System.Web.Http;

namespace CQRS.Web.Controllers
{
    public class HomeController : ApiController
    {
        public string Get()
        {
            return "CQRS API - Hello World";
        }
    }
}
