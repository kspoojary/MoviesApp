using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace TheaterBusinessLogic.Tests
{
    public class FindMovieScreeningShould
    {

        private readonly ITheaterBL theaterBL;

        public FindMovieScreeningShould()
        {
            theaterBL = new TheaterBL();
        }
        [Fact]
        public async Task ReturensListOfTheaterDTOs()
        {
            #region Arrange
            Guid movieId = Guid.NewGuid();
            Guid areaId = Guid.NewGuid();
            #endregion

            #region Act
            var response =await theaterBL.FindMovieScreening(movieId, areaId);
            #endregion

            #region Assert
            Assert.IsType<IEnumerable<TheaterDTO>>(response);
            #endregion
        }
    }
}
