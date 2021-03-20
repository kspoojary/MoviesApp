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

        public async Task<IEnumerable<TheaterDTO>> FindMovieScreening(Guid MovieId, Guid LocationId)
        {
            return await theaterDataAccessor.FindMovieScreening(MovieId, LocationId);
        }
    }
}
