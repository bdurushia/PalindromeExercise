using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("rotavator", true)]
        [InlineData("Reviver", true)]
        [InlineData("Heart", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("Rotator", true)]
        [InlineData("xerox", false)]

        public void IsAPalindromeTest(string word, bool expected)
        {
            // Arrange
            var wordSmith = new WordSmith();
            // Act
            var actual = wordSmith.IsAPalindrome(word);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
