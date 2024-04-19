using UnitTesting.Calculator;

namespace UnitTesting.Tests
{
    public class CalculatorTests : IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture fixture;

        public CalculatorTests(CalculatorFixture fixtureObject)
        {
            fixture = fixtureObject;
        }

        [Fact]
        public void TestAddition()
        {
            MathCalculator calculator = fixture.Calculator;
            int a = 5;
            int b = 10;

            int result = calculator.Add(a, b);
            Assert.Equal(15, result);
        }

        [Fact]
        public void TestSubtraction()
        {
            MathCalculator calculator = fixture.Calculator;
            int a = 10;
            int b = 5;
            int result = calculator.Subtract(a, b);
            Assert.Equal(5, result);
        }
    }
}
