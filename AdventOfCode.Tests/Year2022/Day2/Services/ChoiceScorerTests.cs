using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;
using AdventOfCode.Year2022.Day2.Services;

namespace AdventOfCode.Tests.Year2022.Day2.Services;

public class ChoiceScorerTests
{
    [Theory]
    [InlineData(Choice.Rock, 1)]
    [InlineData(Choice.Paper, 2)]
    [InlineData(Choice.Scissors, 3)]
    public void GetScore_WithValidChoice_ReturnsScore(Choice choice, int expected)
    {
        //Arrange
        IChoiceScorer scorer = new ChoiceScorer();

        //Act
        var actual = scorer.GetScore(choice);

        //Assert
        actual.Should().Be(expected);
    }
}