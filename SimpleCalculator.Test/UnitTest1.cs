using SimpleCalculator.Services;
using System;
using System.Linq;
using Xunit;

namespace SimpleCalculator.Test
{
    public class UnitTest1
    {
       

        [Theory]
        [InlineData("4", "3", "7")]
        [InlineData("20.3", "3.7", "24")]
        [InlineData("-309", "-101", "-410")]
        [InlineData("9", "-9", "0")]
        public void ShouldAddTwoNumbers(string x, string y, string expected)
        {
            //Act
            string actual = Calculator.Calculer(x,y);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
