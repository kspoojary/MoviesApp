using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheaterBusinessLogic
{
    public class TheaterBL : ITheaterBL
    {

        public TheaterBL()
        {

        }

        public Task<IEnumerable<TheaterDTO>> FindMovieScreening(Guid MovieId, Guid LocationId)
        {
            throw new NotImplementedException();
        }
    }
}
