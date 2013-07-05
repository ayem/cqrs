using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities
{
    public class Gadget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Dashboard> Dashboards { get; set; }
    }
}
