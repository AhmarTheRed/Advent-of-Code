using AdventOfCode.Year2022;
using Moq;

namespace AdventOfCode.Tests.Year2022;

public class Day1Tests
{
    [Fact]
    public void GetMostCalories_WithValidInput_ReturnsMostCalories()
    {
        //Arrange
        const string input = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000\n";
        var inputFileService = new Mock<IInputFileService>();
        inputFileService
            .Setup(s => s.GetInput(It.IsAny<string>()))
            .Returns(input);

        //Act
        var day1 = new Day1(inputFileService.Object);
        var actual = day1.GetMostCalories();

        //Assert
        actual.Should().Be(24000);
    }
}