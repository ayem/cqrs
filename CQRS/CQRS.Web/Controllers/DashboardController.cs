using CQRS.Domain.Commands;
using CQRS.Domain.Core;
using CQRS.Domain.Entities;
using System.Collections.Generic;
using System.Web.Http;
using CQRS.Domain.Queries;

namespace CQRS.Web.Controllers
{
    public class DashboardController : ApiController
    {
        private readonly ICommandHandler commandHandler;
        private readonly IQueryHandler queryHandler;
        public DashboardController(ICommandHandler commandHandler, IQueryHandler queryHandler)
        {
            this.commandHandler = commandHandler;
            this.queryHandler = queryHandler;
        }

        public List<Dashboard> Get()
        {
            return this.queryHandler.Handle(new GetAllQuery<Dashboard>());
        }

        public Dashboard Post(Dashboard dashboard)
        {
            this.commandHandler.Execute(new CreateDashboardCommand(dashboard));            
            return dashboard;
        }

        public Dashboard Put(Dashboard dashboard)
        {
            this.commandHandler.Execute(new UpdateDashboardCommand(dashboard));
            return dashboard;
        }
    }
}
