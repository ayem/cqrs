using CQRS.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Core
{
    public abstract class Command
    {
        public abstract void Execute(IDbContext context);
        public virtual ValidationResult Validate() { return new ValidationResult { IsValid = true }; }
    }
}
