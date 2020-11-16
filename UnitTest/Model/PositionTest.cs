using Desafio.Model;
using Xunit;

namespace UnitTest.Model
{
    public class PositionTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        public void Valid(int x, int y)
        {
            // Arrange
            var position = new Position(x, y);

            // Assert
            Assert.False(position.IsInvalid());
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, -1)]
        [InlineData(-1, -1)]
        public void Invalid(int x, int y)
        {
            // Arrange
            var position = new Position(x, y);

            // Assert
            Assert.True(position.IsInvalid());
        }
    }
}
