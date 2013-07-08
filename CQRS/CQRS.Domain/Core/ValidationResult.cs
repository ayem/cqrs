using System.Collections.Generic;
using System.Linq;

namespace CQRS.Domain.Core
{
    public class ValidationResult
    {
        public ValidationResult()
        {
            this.ErrorMessages = new List<string>();
        }

        public bool IsValid { get; set; }
        public List<string> ErrorMessages { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as ValidationResult;
            if (other == null) return false;

            var except = this.ErrorMessages.Except(other.ErrorMessages);
            
            return other.IsValid == this.IsValid && except.Any() == false;
        }
    }
}
