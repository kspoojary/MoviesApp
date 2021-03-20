using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheaterDAL;
using Xunit;
using Moq;

namespace TheaterBusinessLogic.Tests
{
    public class FindMovieScreeningShould
    {

        private readonly ITheaterBL theaterBL;
        private  Mock<ITheaterDataAccessor> mockTheaterDataAccess;

        public FindMovieScreeningShould()
        {
            mockTheaterDataAccess = new Mock<ITheaterDataAccessor>();
            theaterBL = new TheaterBL(mockTheaterDataAccess.Object);
        }
        [Fact]
        public async Task ReturensListOfTheaterDTOs()
        {
            #region Arrange

            Guid movieId = Guid.NewGuid();
            Guid theater1 = Guid.NewGuid();
            Guid areaId = Guid.NewGuid();
            Guid theater2 = Guid.NewGuid();
            IEnumerable<TheaterDTO> theaters =
               new List<TheaterDTO>() {
                   new TheaterDTO()
                   {
                       Id=theater1,
                        AreaId=areaId,
                        AreaName="area1",
                        TheaterName="theater1",
                        ScreeningTime=DateTime.Now,
                        Address="Address1"
                   },
                   new TheaterDTO()
                   {
                       Id=theater2,
                        AreaId=areaId,
                        AreaName="area1",
                        TheaterName="theater2",
                        ScreeningTime=DateTime.Now,
                        Address="Address2"
                   },
               };

            mockTheaterDataAccess.Setup(s => s.FindMovieScreening(It.IsAny<Guid>(), It.IsAny<Guid>())).ReturnsAsync(theaters); 
            #endregion

            #region Act
            var response =await theaterBL.FindMovieScreening(movieId, areaId);
            #endregion

            #region Assert
            Assert.IsType<List<TheaterDTO>>(response);
            #endregion
        }
    }
}
