using CQRS.Domain.Data.ModelConfigurations;
using System.Data.Entity;
using System.Linq;

namespace CQRS.Domain.Data
{
    public class DashboardContext : DbContext, IDbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {                 
            modelBuilder.Configurations.Add(new DashboardConfiguration());
            modelBuilder.Configurations.Add(new GadgetConfiguration());
        }        

        public IQueryable<T> QueryItems<T>() where T : class
        {
            return this.Set<T>();
        }

        public IDbSet<T> Item<T>() where T : class
        {
            return this.Set<T>();
        }
    }
}
