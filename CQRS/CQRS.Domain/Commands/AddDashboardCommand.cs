using CQRS.Domain.Core;
using CQRS.Domain.Data;
using CQRS.Domain.Entities;
using System.Linq;

namespace CQRS.Domain.Commands
{
    public class AddDashboardCommand : Command
    {
        public Dashboard Dashboard { get; private set; }
        public AddDashboardCommand(Dashboard dashboard)
        {
            this.Dashboard = dashboard;
        }

        public override ValidationResult Validate()
        {
            var validationResult = new ValidationResult();
            if (string.IsNullOrWhiteSpace(this.Dashboard.Title))
                validationResult.ErrorMessages.Add("Dashboard needs a title");

            validationResult.IsValid = !validationResult.ErrorMessages.Any();

            return validationResult;
        }

        public override void Execute(IDbContext context)
        {    
            context.Item<Dashboard>().Add(this.Dashboard);
        }
    }
}
