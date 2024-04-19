using Moq;
using UnitTesting.Calculator;

namespace UnitTesting.Tests
{
    public class MockTests
    {
        [Fact]
        public void TestPocessing()
        {
            var mockDataSource = new Mock<IDataSource>();
            mockDataSource.Setup(d => d.GetData()).Returns("I AM RASHID");

            var dataService = new DataService(mockDataSource.Object);
            string result = dataService.ProcessData();

            Assert.Equal("I AM RASHID", result);
        }
    }
}
