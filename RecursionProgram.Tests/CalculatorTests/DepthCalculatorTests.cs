using RecursionProgram.Calculations;
using RecursionProgram.Interfaces;
using RecursionProgram.Models;
using Xunit;

namespace RecursionProgram.Tests.CalculatorTests
{
    public class DepthCalculatorTests
    {
        private readonly ICalculator _sut;

        public DepthCalculatorTests()
        {
            _sut = new DepthCalculator();
        }

        [Fact]
        public void CalculateDepth_InputValidSmall_ReturnsCorrectValue()
        {
            // Arrange
            var testStructure = new Branch(new List<Branch>()
            {
                new Branch(new List<Branch>() {new Branch()}),
                new Branch(new List<Branch>()
                {
                    new Branch(),
                    new Branch(new List<Branch>(){new Branch()}),
                    new Branch(new List<Branch>(){
                        new Branch(new List<Branch>()
                        {
                            new Branch(), new Branch()
                        })}),
                })
            });

            var expected = 5;

            // Act
            var actual = _sut.CalculateDepth(testStructure);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDepth_InputValidLarge_ReturnsCorrectValue()
        {
            // Arrange
            var testStructure = new Branch(new List<Branch>()
            {
                new Branch(new List<Branch>() {new Branch()}),
                new Branch(new List<Branch>()
                {
                    new Branch(),
                    new Branch(new List<Branch>(){new Branch()}),
                    new Branch(new List<Branch>(){
                        new Branch(new List<Branch>()
                        {
                            new Branch(),
                            new Branch(),
                            new Branch(),
                            new Branch(),
                            new Branch(),
                            new Branch(new List<Branch>(){new Branch(),
                                new Branch(new List<Branch>() {
                                    new Branch(),
                                    new Branch(new List<Branch>() { new Branch(), new Branch() }) }) })
                        })})
                })
            });

            var expected = 8;

            // Act
            var actual = _sut.CalculateDepth(testStructure);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}