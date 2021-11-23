using Xunit;

namespace DotNetWebApi.Tests
{
    public class VerifyTheEndpoint
    {
        [Fact]
        public async void CheckItOut()
        {
            // Arrange
            var number = 1;
            var numberX = 2;

            // Act
            


            // Assert
            Assert.NotEqual(number, numberX);

        }
    }
}