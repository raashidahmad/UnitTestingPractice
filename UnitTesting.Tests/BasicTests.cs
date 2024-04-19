namespace UnitTesting.Tests
{
    public class BasicTests
    {
        [Fact]
        public void TestAddition()
        {
            int a = 5;
            int b = 10;
            int sum = a + b;
            Assert.Equal(15, sum);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(5, 4, 20)]
        [InlineData(0, 7, 0)]
        public void TestMultiplication(int a, int b, int expected)
        {
            int result = a * b;
            Assert.Equal(expected, result);
        }
    }
}