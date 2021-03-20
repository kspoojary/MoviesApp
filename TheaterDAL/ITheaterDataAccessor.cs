using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TheaterDAL
{
    public interface ITheaterDataAccessor
    {
        Task<IEnumerable<TheaterDTO>> FindMovieScreening(Guid MovieId, Guid LocationId);
    }
}
