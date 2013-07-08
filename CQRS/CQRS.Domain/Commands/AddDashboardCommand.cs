using CQRS.Domain.Core;
using CQRS.Domain.Data;
using CQRS.Domain.Entities;
using System;
using System.Linq;

namespace CQRS.Domain.Commands
{
    public class AddDashboardCommand : Command
    {
        private readonly Dashboard dashboard;
        public AddDashboardCommand(Dashboard dashboard)
        {
            this.dashboard = dashboard;
        }

        public override ValidationResult Validate()
        {
            var validationResult = new ValidationResult();
            if(string.IsNullOrWhiteSpace(this.dashboard.Title))
                validationResult.ErrorMessages.Add("Dashboard needs a title");

            validationResult.IsValid = !validationResult.ErrorMessages.Any();

            return validationResult;
        }

        public override void Execute(IDbContext context)
        {    
            context.Item<Dashboard>().Add(this.dashboard);
        }
    }
}
