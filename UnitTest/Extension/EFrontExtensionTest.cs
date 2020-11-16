using Desafio.Extension;
using Desafio.Model;
using Xunit;

namespace UnitTest.Extension
{
    public class EFrontExtensionTest
    {
        [Theory]
        [InlineData(EFront.N, EFront.W)]
        [InlineData(EFront.W, EFront.S)]
        [InlineData(EFront.S, EFront.E)]
        [InlineData(EFront.E, EFront.N)]
        public void Move_L(EFront front, EFront response)
        {
            // Act
            var result = front.Move('L');

            // Assert
            Assert.Equal(response, result);
        }

        [Theory]
        [InlineData(EFront.N, EFront.E)]
        [InlineData(EFront.W, EFront.N)]
        [InlineData(EFront.S, EFront.W)]
        [InlineData(EFront.E, EFront.S)]
        public void Move_R(EFront front, EFront response)
        {
            // Act
            var result = front.Move('R');

            // Assert
            Assert.Equal(response, result);
        }
    }
}
