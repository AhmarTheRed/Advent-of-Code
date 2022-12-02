using AdventOfCode.Year2022.Day2;
using AdventOfCode.Year2022.Day2.Interfaces;

namespace AdventOfCode.Tests.Year2022.Day2;

public class ChoiceScorerTests
{
    [Theory]
    [InlineData(Rps.Rock, 1)]
    [InlineData(Rps.Paper, 2)]
    [InlineData(Rps.Scissors, 3)]
    public void GetScore_WithValidChoice_ReturnsScore(Rps choice, int expected)
    {
        //Arrange
        IChoiceScorer scorer = new ChoiceScorer();

        //Act
        var actual = scorer.GetScore(choice);

        //Assert
        actual.Should().Be(expected);
    }
}