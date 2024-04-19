using UnitTesting.Calculator;

namespace UnitTesting.Tests
{
    public class CalculatorFixture : IDisposable
    {
        public MathCalculator Calculator { get; set; }
        public CalculatorFixture()
        {
            Calculator = new MathCalculator();
        }

        public void Dispose()
        {
            Calculator.Dispose();
        }
    }
}
