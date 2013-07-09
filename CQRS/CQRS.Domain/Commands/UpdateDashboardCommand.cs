using CQRS.Domain.Data;
using CQRS.Domain.Entities;

namespace CQRS.Domain.Commands
{
    public class UpdateDashboardCommand : BaseDashboardCommand
    {
        public UpdateDashboardCommand(Dashboard dashboard)
            : base(dashboard)
        {
        }

        public override void Execute(IDbContext context)
        {
            context.Update(this.Dashboard);
        }
    }
}
