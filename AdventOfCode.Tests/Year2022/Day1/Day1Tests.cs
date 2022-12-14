namespace AdventOfCode.Tests.Year2022.Day1;

public class Day1Tests : DayTestsBase
{
    protected override IEnumerable<string> TestInputs => new[]
    {
        $"1000{Environment.NewLine}2000{Environment.NewLine}3000",
        "4000",
        $"5000{Environment.NewLine}6000",
        $"7000{Environment.NewLine}8000{Environment.NewLine}9000",
        $"10000{Environment.NewLine}"
    };

    [Fact]
    public void GetMostCalories_WithValidInput_ReturnsMostCalories()
    {
        //Arrange
        //Act
        var day1 = new AdventOfCode.Year2022.Day1.Day1(MockInputFileService.Object);
        var actual = day1.GetMostCalories();

        //Assert
        actual.Should().Be(24000);
    }

    [Fact]
    public void GetTop3MostCalories_WithValidInput_ReturnsTop3MostCalories()
    {
        //Arrange
        var expected = new[] {24000, 11000, 10000};

        //Act
        var day1 = new AdventOfCode.Year2022.Day1.Day1(MockInputFileService.Object);
        var actual = day1.GetTop3MostCalories();

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void GetTop3MostCaloriesTotal_WithValidInput_ReturnsSumOfTop3MostCalories()
    {
        //Arrange
        //Act
        var day1 = new AdventOfCode.Year2022.Day1.Day1(MockInputFileService.Object);
        var actual = day1.GetTop3MostCaloriesTotal();

        //Assert
        actual.Should().Be(45000);
    }
}