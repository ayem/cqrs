using CQRS.Domain.Data;

namespace CQRS.Domain.Core
{
    public abstract class Command
    {
        public abstract void Execute(IDbContext context);
        public virtual ValidationResult Validate() { return new ValidationResult { IsValid = true }; }
    }
}
