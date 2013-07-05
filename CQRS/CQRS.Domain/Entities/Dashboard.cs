using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities
{
    public class Dashboard
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Gadget> Gadgets { get; set; }
    }
}
