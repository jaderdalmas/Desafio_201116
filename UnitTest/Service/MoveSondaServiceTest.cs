using Desafio.Model;
using Desafio.Service;
using Xunit;

namespace UnitTest.Service
{
    public class MoveSondaServiceTest
    {
        [Theory]
        [InlineData("LMLMLMLMM", "1 0 N")]
        [InlineData("RMRMRMRMM", "1 0 N")]
        public void MoveSonda(string moves, string response)
        {
            // Arrange
            var sonda = new Sonda();
            var service = new MoveSondaService();

            // Act
            var result = service.MoveSonda(sonda, moves);

            // Assert
            Assert.Equal(response, result.ToString());
        }

        [Theory]
        [InlineData("LMLMLMLMM", "Invalid")]
        [InlineData("RMRMRMRMM", "Invalid")]
        public void MoveSonda_Invalid(string moves, string response)
        {
            // Arrange
            var sonda = new Sonda();
            var service = new MoveSondaService();
            var limit = new Position();

            // Act
            var result = service.MoveSonda(sonda, moves, limit);

            // Assert
            Assert.Equal(response, result.ToString());
        }
    }
}
