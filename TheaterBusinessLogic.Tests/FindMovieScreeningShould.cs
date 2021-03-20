using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheaterDAL;
using Xunit;

namespace TheaterBusinessLogic.Tests
{
    public class FindMovieScreeningShould
    {

        private readonly ITheaterBL theaterBL;
        private readonly Moq.IMock<ITheaterDataAccessor> mockTheaterDataAccess;

        public FindMovieScreeningShould()
        {
            mockTheaterDataAccess = new Moq.Mock<ITheaterDataAccessor>();
            theaterBL = new TheaterBL(mockTheaterDataAccess.Object);
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
