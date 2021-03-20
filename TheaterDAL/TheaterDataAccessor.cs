using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheaterDAL
{
    public class TheaterDataAccessor : ITheaterDataAccessor
    {
        public async Task<IEnumerable<TheaterDTO>> FindMovieScreening(Guid MovieId, Guid LocationId)
        {
            return await Task.Run(() => {
                IEnumerable<TheaterDTO> theaters =
                new List<TheaterDTO>() {
                   new TheaterDTO()
                   {
                        Id=Guid.NewGuid(),
                        AreaId=Guid.NewGuid(),
                        AreaName="area1",
                        TheaterName="theater1",
                        ScreeningTime=DateTime.Now,
                        Address="Address1"
                   },
                   new TheaterDTO()
                   {
                        Id=Guid.NewGuid(),
                        AreaId=Guid.NewGuid(),
                        AreaName="area2",
                        TheaterName="theater2",
                        ScreeningTime=DateTime.Now,
                        Address="Address2"
                   },
                };
                return theaters;
            });
        }
    }
}
