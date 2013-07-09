using System.Data.Entity;
using System.Linq;

namespace CQRS.Domain.Data
{
    public interface IDbContext
    {
        IQueryable<T> QueryItems<T>() where T : class;
        IDbSet<T> Item<T>() where T : class;
        void Update<T>(T item) where T : class;
        void Delete<T>(T item) where T : class;
        int SaveChanges();
    }
}
