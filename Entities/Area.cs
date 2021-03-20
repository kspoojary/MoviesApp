using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Area
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid LocationId { get; set; }

        public string Address { get; set; }
    }
}
