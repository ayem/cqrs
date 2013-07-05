using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Data
{
    public interface IDbContext
    {        
        int SaveChanges();
    }
}
