using System.Collections.Generic;

namespace CQRS.Domain.Entities
{
    public class Gadget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Dashboard> Dashboards { get; set; }
    }
}
