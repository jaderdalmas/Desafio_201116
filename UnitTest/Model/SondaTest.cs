using Desafio.Model;
using Xunit;

namespace UnitTest.Model
{
    public class SondaTest
    {
        [Theory]
        [InlineData(EFront.N, "1 0 N")]
        [InlineData(EFront.W, "0 -1 W")]
        [InlineData(EFront.S, "-1 0 S")]
        [InlineData(EFront.E, "0 1 E")]
        public void Move_M(EFront front, string result)
        {
            // Arrange
            var sonda = new Sonda(front: front);

            // Act
            sonda.Move('M');

            // Assert
            Assert.Equal(result, sonda.GetPosition());
        }

        [Theory]
        [InlineData(EFront.N, "0 0 W")]
        [InlineData(EFront.W, "0 0 S")]
        [InlineData(EFront.S, "0 0 E")]
        [InlineData(EFront.E, "0 0 N")]
        public void Move_L(EFront front, string result)
        {
            // Arrange
            var sonda = new Sonda(front: front);

            // Act
            sonda.Move('L');

            // Assert
            Assert.Equal(result, sonda.GetPosition());
        }

        [Theory]
        [InlineData(EFront.N, "0 0 E")]
        [InlineData(EFront.W, "0 0 N")]
        [InlineData(EFront.S, "0 0 W")]
        [InlineData(EFront.E, "0 0 S")]
        public void Move_R(EFront front, string result)
        {
            // Arrange
            var sonda = new Sonda(front: front);

            // Act
            sonda.Move('R');

            // Assert
            Assert.Equal(result, sonda.GetPosition());
        }
    }
}
