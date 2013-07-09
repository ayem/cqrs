using System.Linq;
using CQRS.Domain.Core;
using CQRS.Domain.Data;
using CQRS.Domain.Entities;

namespace CQRS.Domain.Commands
{
    public abstract class BaseDashboardCommand : Command
    {
        public Dashboard Dashboard { get; private set; }

        protected BaseDashboardCommand(Dashboard dashboard)
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

        public override abstract void Execute(IDbContext context);
    }
}
