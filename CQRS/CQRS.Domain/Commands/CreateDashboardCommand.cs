using CQRS.Domain.Data;
using CQRS.Domain.Entities;

namespace CQRS.Domain.Commands
{
    public class CreateDashboardCommand : BaseDashboardCommand
    {
        public CreateDashboardCommand(Dashboard dashboard)
            : base(dashboard)
        {
        }        

        public override void Execute(IDbContext context)
        {    
            context.Item<Dashboard>().Add(this.Dashboard);
        }
    }
}
