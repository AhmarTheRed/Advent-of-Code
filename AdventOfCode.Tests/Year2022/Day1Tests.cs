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
    
    [Fact]
    public void GetTop3MostCalories_WithValidInput_ReturnsTop3MostCalories()
    {
        //Arrange
        const string input = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000\n";
        var expected = new[] { 24000, 11000, 10000 };
        var inputFileService = new Mock<IInputFileService>();
        inputFileService
            .Setup(s => s.GetInput(It.IsAny<string>()))
            .Returns(input);

        //Act
        var day1 = new Day1(inputFileService.Object);
        var actual = day1.GetTop3MostCalories();

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }
    
    [Fact]
    public void GetTop3MostCaloriesTotal_WithValidInput_ReturnsSumOfTop3MostCalories()
    {
        //Arrange
        const string input = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000\n";
        var inputFileService = new Mock<IInputFileService>();
        inputFileService
            .Setup(s => s.GetInput(It.IsAny<string>()))
            .Returns(input);

        //Act
        var day1 = new Day1(inputFileService.Object);
        var actual = day1.GetTop3MostCaloriesTotal();

        //Assert
        actual.Should().Be(45000);
    }
}