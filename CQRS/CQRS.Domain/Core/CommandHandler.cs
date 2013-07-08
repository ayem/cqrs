using CQRS.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Core
{   
    public class CommandHandler
    {
        private readonly IDbContext context;
        public CommandHandler(IDbContext context)
        {
            this.context = context;
        }        
    }
}
