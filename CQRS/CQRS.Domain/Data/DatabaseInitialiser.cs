using CQRS.Domain.Migrations;
using System.Data.Entity;

namespace CQRS.Domain.Data
{
    public class DatabaseInitialiser : MigrateDatabaseToLatestVersion<DashboardContext, Configuration>
    {
        public DatabaseInitialiser(string connectionName)
            : base(connectionName)
        {
        }
    }
}
