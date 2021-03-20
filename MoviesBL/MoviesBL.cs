using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesBL
{
    public class MoviesBL : IMoviesBL
    {
        //Inject database access class and logger claaa here
        public MoviesBL()
        {

        }
        public Task<Movie> AddMovieAsync(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TheaterDTO>> FindMovieScreening(Guid movieId, Guid areaId)
        {
            //Call theater service to get all the theater list where the given movies is screened for the given area
            //TO Replace below code with actual service call
            return Task.Run(() => {
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

        public Task<Movie> GetMovieAsync(Guid movieId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
