using CQRS.Domain.Data;

namespace CQRS.Domain.Core
{
    public abstract class Query<T> where T : class
    {
        public abstract T Execute(IDbContext context);       
    }
}
