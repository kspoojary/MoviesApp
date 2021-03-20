using System;

namespace Entities
{
    public class Movie
    {
        public Guid Id { get; set; }

        public string  Name { get; set; }

        public string Description { get; set; }

        public string Director { get; set; }

        public string Laungauage { get; set; }

        public string Cast { get; set; }
    }
}
