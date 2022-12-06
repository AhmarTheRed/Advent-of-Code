using AdventOfCode.Year2022.Day5.Interface;
using AdventOfCode.Year2022.Day5.Models;
using AdventOfCode.Year2022.Day5.Services;

namespace AdventOfCode.Tests.Year2022.Day5.Services;

public class MoveGeneratorTests
{
    [Theory]
    [InlineData("move 3 from 2 to 1", 3, 2, 1)]
    [InlineData("move 27 from 1 to 2", 27, 1, 2)]
    [InlineData("move 3 from 13 to 11", 3, 13, 11)]
    [InlineData("move 20 from 12 to 10", 20, 12, 10)]
    [InlineData("move 20 from 1 to 10", 20, 1, 10)]
    [InlineData("move 21 from 10 to 1", 21, 10, 1)]
    public void GetMove_WithValidInput_ReturnsMove(string input, int expectedAmount, int expectedFrom, int expectedTo)
    {
        //Arrange
        var expected = new Move
        {
            Amount = expectedAmount,
            From = expectedFrom,
            To = expectedTo
        };
        IMoveGenerator generator = new MoveGenerator();

        //Act
        var actual = generator.GetMove(input);

        //Assert
        actual.Should().BeEquivalentTo(actual);
    }
}