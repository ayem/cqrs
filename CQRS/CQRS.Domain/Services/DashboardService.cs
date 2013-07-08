using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CQRS.Domain.Services
{
    public interface IDashboardService
    {
        List<Dashboard> GetAll();
        void Add(Dashboard dashboard);
    }

    public class DashboardService : IDashboardService
    {
        public List<Dashboard> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(Dashboard dashboard)
        {
            throw new NotImplementedException();
        }
    }
}
