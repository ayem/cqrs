using CQRS.Domain.Core;
using CQRS.Domain.Data;
using CQRS.Domain.Entities;

namespace CQRS.Domain.Commands
{
    public class DeleteDashboardCommand : Command
    {
        public int DashboardId { get; private set; }

        public DeleteDashboardCommand(int dashboardId)
        {
            this.DashboardId = dashboardId;
        }

        public override void Execute(IDbContext context)
        {
            context.Item<Dashboard>().Remove(new Dashboard {Id = this.DashboardId});
        }
    }
}
