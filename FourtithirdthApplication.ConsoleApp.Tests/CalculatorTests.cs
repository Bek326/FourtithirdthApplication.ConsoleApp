using Xunit;

namespace FourtithirdthApplication.ConsoleApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Additional(15, 25);
            Assert.Equal(40, result);
        }

        [Fact]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Subtraction(98, 42);
            Assert.Equal(56, result);
        }

        [Fact]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Multiplication(24, 10);
            Assert.Equal(240, result);
        }

        [Fact]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Division(93, 31);
            Assert.Equal(3, result);
        }
    }
}