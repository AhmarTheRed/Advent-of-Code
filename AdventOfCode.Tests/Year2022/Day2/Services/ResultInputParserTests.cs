using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;
using AdventOfCode.Year2022.Day2.Services;

namespace AdventOfCode.Tests.Year2022.Day2.Services;

public class ResultInputParserTests
{
    [Theory]
    [InlineData("X", Result.Loss)]
    [InlineData("Y", Result.Draw)]
    [InlineData("Z", Result.Win)]
    public void Parse_WithValidInput_ReturnsRpsValue(string input, Result expected)
    {
        //Arrange
        IResultInputParser parser = new ResultInputParser();

        //Act
        var actual = parser.Parse(input);

        //Assert
        actual.Should().Be(expected);
    }
}