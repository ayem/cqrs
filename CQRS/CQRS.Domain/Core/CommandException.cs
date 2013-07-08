using System;

namespace CQRS.Domain.Core
{
    public class CommandException : Exception
    {
        private readonly ValidationResult result;
        public CommandException(ValidationResult result)
        {
            if (result == null)
                throw new ArgumentException("validation result required");
            this.result = result;
        }

        public override string Message
        {
            get { return string.Join(" - ", this.result.ErrorMessages); }
        }  
    }
}
