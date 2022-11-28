using RecursionProgram.Extensions;
using Xunit;

namespace RecursionProgram.Tests.ExtensionsTests
{
    public class ResultPrinterTests
    {
        private readonly ResultPrinter _sut;

        public ResultPrinterTests()
        {
            _sut = new ResultPrinter();
        }

        [Fact]
        public void Print_InputValid_ConsoleWritesCorrectValueInCorrectFormat()
        {
            // Arrange
            var testResult = 5;
            var expected = $"The depth of structure: {testResult}\r\n";
            var actual = new StringWriter();

            Console.SetOut(actual);

            // Act
            _sut.Print(testResult);

            // Assert
            Assert.Equal(expected, actual.ToString());
            Assert.Equal(testResult, int.Parse(actual.ToString().Split(':')[1]));
        }
    }
}