using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheaterDAL;

namespace TheaterBusinessLogic
{
    public class TheaterBL : ITheaterBL
    {
        private readonly ITheaterDataAccessor theaterDataAccessor;

        public TheaterBL(ITheaterDataAccessor theaterDataAccessor)
        {
            this.theaterDataAccessor = theaterDataAccessor;
        }

        public Task<IEnumerable<TheaterDTO>> FindMovieScreening(Guid MovieId, Guid LocationId)
        {
            throw new NotImplementedException();
        }
    }
}
