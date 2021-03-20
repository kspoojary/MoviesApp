using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBusinessLogic
{
    public interface ITheaterBL
    {
        Task<IEnumerable<TheaterDTO>> FindMovieScreening(Guid MovieId, Guid LocationId);
    }
}
