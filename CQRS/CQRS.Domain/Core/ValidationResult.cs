using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
