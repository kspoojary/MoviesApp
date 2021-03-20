using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class MovieScreening
    {
        public Guid MovieId { get; set; }

        public string MovieName { get; set; }

        public IEnumerable<TheaterDTO> Theaters { get; set; }
    }
}
