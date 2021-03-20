using System;

namespace Entities
{
    public class Screening
    {
        public Guid Id { get; set; }

        public Guid MovieId { get; set; }

        public Guid TheaterId { get; set; }

        public DateTime ScreeningTime { get; set; }
    }
}
