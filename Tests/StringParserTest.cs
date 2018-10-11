using System;
using Xunit;

namespace StringParser
{
    public class StringParserTest
    {
        [Fact]
        public void StringParser_Returns_Correct_Int()
        {
            // Arrange
            // Act
            var result = StringParser.ParseStringToInt("123456");

            // Assert
            Assert.Equal(123456, result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("foo")]
        public void StringParser_Throws_If_Empty_String_Is_Passed(string value)
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<ArgumentException>(
                () => StringParser.ParseStringToInt(value));
        }
    }
}
