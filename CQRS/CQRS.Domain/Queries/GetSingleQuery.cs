using CQRS.Domain.Core;
using CQRS.Domain.Data;

namespace CQRS.Domain.Queries
{
    public class GetSingleQuery<T> : Query<T> where T : class
    {
        public object[] Keys { get; private set; }
        public GetSingleQuery(params object[] keys)
        {
            this.Keys = keys;
        }

        public override T Execute(IDbContext context)
        {
            return context.Item<T>().Find(this.Keys);
        }      
    }
}
