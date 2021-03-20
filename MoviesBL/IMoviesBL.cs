using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesBL
{
    public interface IMoviesBL
    {
        Task<Movie> AddMovieAsync(Movie movie);

        Task<Movie> GetMovieAsync(Guid movieId);

        Task<IEnumerable<Movie>> GetMoviesAsync();

        Task<IEnumerable<TheaterDTO>> FindMovieScreening(Guid movieId, Guid areaId);
    }
}
