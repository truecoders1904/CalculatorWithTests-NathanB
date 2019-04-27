using System;
using Xunit;
using CalculatorWithTests;


namespace CalculatorWithTests.Test
{
    public class CalculatorTests
    {
        //Add Test
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(5, 5, 10)]
        [InlineData(10, 10, 20)]
        [InlineData(23, 4, 27)]
        [InlineData(40, 2, 42)]
        [InlineData(62, 52, 114)]
        [InlineData(0, 4, 4)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -5, -10)]
        public void ShouldAdd(decimal number1, decimal number2, decimal expectedSum)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            decimal actual = calculator.Add(number1, number2);

            //Assert
            Assert.Equal(expectedSum, actual);
        }


        //Subtract Test
        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(5, 0, 5)]
        [InlineData(10, 7, 3)]
        [InlineData(23, 4, 19)]
        [InlineData(40, 2, 38)]
        [InlineData(62, 52, 10)]
        [InlineData(0, 4, -4)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -5, 0)]
        public void ShouldSubtract(decimal number1, decimal number2, decimal expectedDifference)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            decimal actual = calculator.Subtract(number1, number2);

            //Assert
            Assert.Equal(expectedDifference, actual);
        }

        //Multiply Test
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(2, 3, 6)]
        [InlineData(5, 6, 30)]
        [InlineData(8, 3, 24)]
        [InlineData(0, 5, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(5, -5, -25)]
        [InlineData(-5, -5, 25)]
        public void ShouldMultiply(decimal number1, decimal number2, decimal expectedResult)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            decimal actual = calculator.Multiply(number1, number2);

            //Assert
            Assert.Equal(expectedResult, actual);
        }

        //Divide Test
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(25, 5, 5)]
        [InlineData(8, 4, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(0, 5, 0)]
        [InlineData(-8, 4, -2)]
        [InlineData(16, -2, -8)]
        [InlineData(-20, -10, 2)]
        public void ShouldDivide(decimal number1, decimal number2, decimal expectedResult)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            decimal actual = calculator.Divide(number1, number2);

            //Assert
            Assert.Equal(expectedResult, actual);
        }

        //Factorial Test
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        [InlineData(8, 40320)]
        [InlineData(-1, 0)]
        public void ShouldFactorial(int number, int expectedResult)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Factorial(number);

            //Assert
            Assert.Equal(expectedResult, actual);
        }

    }
}
