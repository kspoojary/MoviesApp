using MoviesBL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MoviesApp.Tests.MoviesBLTests
{
    public class AddMoviesShould
    {
        private readonly IMoviesBL moviesBL;

        public AddMoviesShould()
        {

            //create moq database class
            //inject mocked class in the bl
            moviesBL = new MoviesBL.MoviesBL();
        }

        [Fact]
        public void ReturnsAddedMovie()
        {
            #region Arrange
            //setup the database class with moq data
            #endregion

            #region Act

            #endregion

            #region Assert

            #endregion
        }
    }
}
