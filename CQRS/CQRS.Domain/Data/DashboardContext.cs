using CQRS.Domain.Data.ModelConfigurations;
using System.Data.Entity;

namespace CQRS.Domain.Data
{
    public class DashboardContext : DbContext, IDbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {                 
            modelBuilder.Configurations.Add(new DashboardConfiguration());
            modelBuilder.Configurations.Add(new GadgetConfiguration());
        }

        public IDbSet<T> Item<T>() where T : class
        {
            return this.Set<T>();
        }
    }
}
