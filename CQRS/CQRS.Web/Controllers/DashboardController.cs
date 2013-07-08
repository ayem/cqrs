using CQRS.Domain.Entities;
using CQRS.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CQRS.Web.Controllers
{
    public class DashboardController : ApiController
    {
        private readonly IDashboardService dashboardService;
        public DashboardController(IDashboardService dashboardService)
        {
            this.dashboardService = dashboardService;
        }

        public List<Dashboard> Get()
        {
            return this.dashboardService.GetAll();
        }

        public Dashboard Post(Dashboard dashboard)
        {
            this.dashboardService.Add(dashboard);
            return dashboard;
        }
    }
}
