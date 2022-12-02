using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;
using AdventOfCode.Year2022.Day2.Services;

namespace AdventOfCode.Tests.Year2022.Day2.Services;

public class RpsInputParserTests
{
    [Theory]
    [InlineData("A", Choice.Rock)]
    [InlineData("B", Choice.Paper)]
    [InlineData("C", Choice.Scissors)]
    [InlineData("X", Choice.Rock)]
    [InlineData("Y", Choice.Paper)]
    [InlineData("Z", Choice.Scissors)]
    public void Parse_WithValidInput_ReturnsRpsValue(string input, Choice expected)
    {
        //Arrange
        IRpsInputParser parser = new RpsInputParser();

        //Act
        var actual = parser.Parse(input);

        //Assert
        actual.Should().Be(expected);
    }
}