using CQRS.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CQRS.Domain.Data.ModelConfigurations
{
    public class DashboardConfiguration : EntityTypeConfiguration<Dashboard>
    {
        public DashboardConfiguration()
        {
            Property(t => t.Id).HasColumnName("Dashboard_Id");
            Property(t => t.Title).HasColumnName("Dashboard_Title").HasMaxLength(300);
            HasMany(t => t.Gadgets).WithMany(t => t.Dashboards)
                .Map(m =>
                {
                    m.ToTable("Dashboard_Gadget");
                    m.MapLeftKey("Dashboard_Id");
                    m.MapRightKey("Gadget_Id");
                });
        }
    }
}
