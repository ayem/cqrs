using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
