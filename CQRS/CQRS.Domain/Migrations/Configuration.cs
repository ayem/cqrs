namespace CQRS.Domain.Migrations
{
    using CQRS.Domain.Data;
    using CQRS.Domain.Entities;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<DashboardContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DashboardContext context)
        {
            context.Set<Gadget>().AddOrUpdate(
                g => g.Name,
                new Gadget { Name = "Test First Gadget" },
                new Gadget { Name = "Test Second Gadget" });

            context.SaveChanges();

            var gadget = context.Set<Gadget>().Single(x => x.Name == "Test First Gadget");

            context.Set<Dashboard>().AddOrUpdate(
                d => d.Title,
                new Dashboard
                {
                    Title = "Test Dashboard",
                    Gadgets = new List<Gadget> { gadget }
                });
        }
    }
}
