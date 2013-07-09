using System.Collections.Generic;
using System.Linq;
using CQRS.Domain.Core;
using CQRS.Domain.Data;


namespace CQRS.Domain.Queries
{
    public class GetAllQuery<T> : Query<List<T>> where T : class
    {
        public override List<T> Execute(IDbContext context)
        {
            return (from t in context.QueryItems<T>() select t).ToList();
        }
    }
}
