using CQRS.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CQRS.Domain.Data.ModelConfigurations
{
    public class GadgetConfiguration : EntityTypeConfiguration<Gadget>
    {
        public GadgetConfiguration()
        {
            Property(t => t.Id).HasColumnName("Gadget_Id");
            Property(t => t.Name).HasColumnName("Gadget_Name");
        }
    }
}
