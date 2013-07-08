using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CQRS.Domain.Services
{
    public interface IGadgetService
    {
        List<Gadget> GetAll();
        void Add(Gadget gadget);
    }
    
    public class GadgetService : IGadgetService
    {
        public List<Gadget> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(Gadget gadget)
        {
            throw new NotImplementedException();
        }
    }
}
