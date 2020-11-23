using System;
using PalindromeExercise;
using Xunit;



namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("RacecAR" , true)]
        [InlineData("booK", false)]
        public void Test1(string word , bool expected)
        {
            //arrange
            var tester = new WordSmith();

            //act
            bool actual = tester.IsAPalindrome(word);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
