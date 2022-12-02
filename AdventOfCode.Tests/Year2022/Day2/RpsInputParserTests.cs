using AdventOfCode.Year2022.Day2;
using AdventOfCode.Year2022.Day2.Interfaces;

namespace AdventOfCode.Tests.Year2022.Day2;

public class RpsInputParserTests
{
    [Theory]
    [InlineData("A", Rps.Rock)]
    [InlineData("B", Rps.Paper)]
    [InlineData("C", Rps.Scissors)]
    [InlineData("X", Rps.Rock)]
    [InlineData("Y", Rps.Paper)]
    [InlineData("Z", Rps.Scissors)]
    public void Parse_WithValidInput_ReturnsRpsValue(string input, Rps expected)
    {
        //Arrange
        IRpsInputParser parser = new RpsInputParser();

        //Act
        var actual = parser.Parse(input);

        //Assert
        actual.Should().Be(expected);
    }
}