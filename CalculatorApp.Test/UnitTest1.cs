using CalculatorApp;
using Xunit;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            // Arrange
            double a = 5;
            double b = 3;
            double expected = 8;

            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_NegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            double a = -2;
            double b = -3;
            double expected = -5;

            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            double a = 5;
            double b = 3;
            double expected = 2;

            // Act
            double result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtract_NegativeNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            double a = -2;
            double b = -3;
            double expected = 1;

            // Act
            double result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}