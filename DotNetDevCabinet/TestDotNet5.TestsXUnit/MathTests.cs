using System;
using Xunit;

namespace TestDotNet5.TestsXUnit
{
    public class MathTests
    {
        [Theory]
        [InlineData("0,0,0", 0)]
        [InlineData("0,1,2", 3)]
        [InlineData("1,2,3", 6)]
        public void Add_MultipleNumbers_ReturnsSumOfNumbers(string input, int expected)
        {
            var actual = CustomMath.StringCalculator(input);

            Assert.Equal(expected, actual);
        }
    }
}
