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
        [InlineData("Example")]
        public void ShouldParse(string str)
        {
            // TODO: Complete Should Parse
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

            // Act

            // Assert

            // TODO: Complete Should Fail Parse
        }
    }
}
