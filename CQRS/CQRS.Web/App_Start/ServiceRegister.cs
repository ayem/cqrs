using CQRS.Domain.Core;
using CQRS.Domain.Data;
using Ninject;
using Ninject.Web.Common;

namespace CQRS.Web.App_Start
{
    public class ServiceRegister
    {    
        public void Register(IKernel kernel)
        {
            kernel.Bind<ICommandHandler>().To<CommandHandler>();
            kernel.Bind<IQueryHandler>().To<QueryHandler>();
            kernel.Bind<IDbContext>().To<DashboardContext>().InRequestScope();
        }
    }
}