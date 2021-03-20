using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesBL moviesBL;


        private readonly ILogger<MoviesController> _logger;

        public MoviesController(ILogger<MoviesController> logger, IMoviesBL moviesBL)
        {
            _logger = logger;
            this.moviesBL = moviesBL;
        }

        [HttpGet]
        public async Task<IEnumerable<Movie>> Get()
        {
            return await moviesBL.GetMoviesAsync();
        }

        [HttpGet]
        [Route("movies/{movieId}/screening/{areaId}")]
        public IEnumerable<WeatherForecast> FindMovieScreening(Guid movieId, Guid areaId)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                //Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
