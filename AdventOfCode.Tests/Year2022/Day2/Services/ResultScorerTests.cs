using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;
using AdventOfCode.Year2022.Day2.Services;

namespace AdventOfCode.Tests.Year2022.Day2.Services;

public class ResultScorerTests
{
    [Theory]
    [InlineData(Result.Win, 6)]
    [InlineData(Result.Loss, 0)]
    [InlineData(Result.Draw, 3)]
    public void GetScore_WithValidResult_ReturnsScore(Result result, int expected)
    {
        //Arrange
        IResultScorer scorer = new ResultScorer();

        //Act
        var actual = scorer.GetScore(result);

        //Assert
        actual.Should().Be(expected);
    }
}