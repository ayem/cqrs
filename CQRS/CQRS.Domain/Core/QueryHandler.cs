using CQRS.Domain.Data;

namespace CQRS.Domain.Core
{
    public interface IQueryHandler
    {
        T Handle<T>(Query<T> query) where T : class;
    }

    public class QueryHandler : IQueryHandler
    {
        private readonly IDbContext dbContext;
        public QueryHandler(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public T Handle<T>(Query<T> query) where T : class
        {
            return query.Execute(this.dbContext);
        }
    }
}
