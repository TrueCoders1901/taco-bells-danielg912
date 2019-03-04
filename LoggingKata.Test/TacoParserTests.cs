using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything
        }

        [Theory]
        [InlineData("0, 0, test")]
        public void ShouldParse(string str)
        {
            // TODO: Complete Should Parse

            // Arrange
            TacoParser tacoparser = new TacoParser();

            // Act
            ITrackable result = tacoparser.Parse(str);

            // Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("not a number,0.0,Taco Bell Test")]
        [InlineData("0.0,not a number,Taco Bell Test")]
        [InlineData("0.0,0.0,0.0, Taco Bell Test")]
        [InlineData("0.0,0.0")]
        public void ShouldFailParse(string str)
        {
            // Arrange
            TacoParser tacoParser = new TacoParser();

            // Act
            ITrackable result = tacoParser.Parse(str);

            // Assert
            Assert.Null(result);

            // TODO: Complete Should Fail Parse
        }
    }
}
