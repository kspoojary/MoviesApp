using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class TheaterDTO
    {
        public Guid Id { get; set; }

        public string TheaterName { get; set; }

        public Guid AreaId { get; set; }

        public string AreaName { get; set; }

        public string Address { get; set; }

        public DateTime ScreeningTime { get; set; }
    }
}
