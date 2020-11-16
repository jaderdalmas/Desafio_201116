using Desafio.Extension;
using Desafio.Model;
using Xunit;

namespace UnitTest.Extension
{
    public class PositionExtensionTest
    {
        [Theory]
        [InlineData(0, 0, 1, 1)]
        [InlineData(1, 0, 1, 1)]
        [InlineData(0, 1, 1, 1)]
        [InlineData(1, 1, 1, 1)]
        public void Valid(int x, int y, int lX, int lY)
        {
            // Arrange
            var position = new Position(x, y);
            var limit = new Position(lX, lY);

            // Assert
            Assert.False(position.OutOfLimit(limit));
        }

        [Theory]
        [InlineData(1, 0, 0, 0)]
        [InlineData(0, 1, 0, 0)]
        [InlineData(1, 1, 0, 0)]
        public void Invalid(int x, int y, int lX, int lY)
        {
            // Arrange
            var position = new Position(x, y);
            var limit = new Position(lX, lY);

            // Assert
            Assert.True(position.OutOfLimit(limit));
        }
    }
}
