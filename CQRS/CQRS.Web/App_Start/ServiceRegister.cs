using CQRS.Domain.Core;
using Ninject;

namespace CQRS.Web.App_Start
{
    public class ServiceRegister
    {    
        public void Register(IKernel kernel)
        {
            kernel.Bind<ICommandHandler>().To<CommandHandler>();
        }
    }
}