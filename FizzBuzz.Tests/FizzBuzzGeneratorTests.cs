
using Xunit;
using Moq;
using System.Reflection;
using FizzBuzz.Interfaces;

namespace FizzBuzz.Tests;
public class FizzBuzzGeneratorTests
{
    [Fact]
    public void Generate_ShouldPrintNumbers1To100()
    {
        // Arrange
        var printerMock = new Mock<IPrinter>();
        var numberEvaluatorMock = new Mock<INumberEvaluator>();
        var fizzBuzzGenerator = new FizzBuzzGenerator(printerMock.Object, numberEvaluatorMock.Object);

        // Act
        fizzBuzzGenerator.Generate(1,100);

        // Assert
        printerMock.Verify(x => x.Print(It.IsAny<string>()), Times.Exactly(100));
        for (int i = 1; i <= 100; i++)
        {
            printerMock.Verify(x => x.Print($"{i}"), Times.Once);
        }
    }

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    [InlineData(12)]
    public void Generate_ShouldPrintFizz_WhenNumberIsMultipleOf3(int number)
    {
        // Arrange
        var printerMock = new Mock<IPrinter>();
        var numberEvaluatorMock = new Mock<INumberEvaluator>();
        numberEvaluatorMock.Setup(x => x.IsMultipleOf3(number)).Returns(true);
        var fizzBuzzGenerator = new FizzBuzzGenerator(printerMock.Object, numberEvaluatorMock.Object);

        // Act
        fizzBuzzGenerator.Generate(1, 100);

        // Assert
        printerMock.Verify(x => x.Print("Fizz"), Times.Once);
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    [InlineData(25)]
    public void Generate_ShouldPrintBuzz_WhenNumberIsMultipleOf5(int number)
    {
        // Arrange
        var printerMock = new Mock<IPrinter>();
        var numberEvaluatorMock = new Mock<INumberEvaluator>();
        numberEvaluatorMock.Setup(x => x.IsMultipleOf5(number)).Returns(true);
        var fizzBuzzGenerator = new FizzBuzzGenerator(printerMock.Object, numberEvaluatorMock.Object);

        // Act
        fizzBuzzGenerator.Generate(1,100);

        // Assert
        printerMock.Verify(x => x.Print("Buzz"), Times.Once);
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    [InlineData(60)]
    public void Generate_ShouldPrintFizzBuzz_WhenNumberIsMultipleOf3And5(int number)
    {
        // Arrange
        var printerMock = new Mock<IPrinter>();
        var numberEvaluatorMock = new Mock<INumberEvaluator>();
        numberEvaluatorMock.Setup(x => x.IsMultipleOf3And5(number)).Returns(true);
        var fizzBuzzGenerator = new FizzBuzzGenerator(printerMock.Object, numberEvaluatorMock.Object);

        // Act
        fizzBuzzGenerator.Generate(1,100);

        // Assert
        printerMock.Verify(x => x.Print("FizzBuzz"), Times.Once);
    }
}