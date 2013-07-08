using CQRS.Domain.Data;

namespace CQRS.Domain.Core
{   
    public interface ICommandHandler
    {
        void Execute(params Command[] commands);
    }

    public class CommandHandler : ICommandHandler
    {
        private readonly IDbContext context;
        public CommandHandler(IDbContext context)
        {
            this.context = context;
        }               
        
        public void Execute(params Command[] commands)
        {           
            foreach (var command in commands)
            {
                var valResult = command.Validate();
                if (valResult == null || valResult.IsValid == false)
                    throw new CommandException(valResult);

                command.Execute(this.context);
            }

            this.context.SaveChanges();
        }
    }
}
