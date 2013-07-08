using System.Collections.Generic;

namespace CQRS.Domain.Entities
{
    public class Dashboard
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Gadget> Gadgets { get; set; }
    }
}
