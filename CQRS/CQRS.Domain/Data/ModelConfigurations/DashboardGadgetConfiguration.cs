using CQRS.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CQRS.Domain.Data.ModelConfigurations
{
    public class DashboardGadgetConfiguration : EntityTypeConfiguration<Dashboard>
    {
        public DashboardGadgetConfiguration()
        {
            HasMany(t => t.Gadgets)
                .WithMany()
                .Map(m =>
                {
                    m.ToTable("DashboardGadget");
                    m.MapLeftKey("Dashboard_Id");
                    m.MapRightKey("Gadget_Id");
                });
        }
    }
}
