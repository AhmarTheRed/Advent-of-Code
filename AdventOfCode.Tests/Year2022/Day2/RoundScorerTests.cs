using AdventOfCode.Year2022.Day2;
using AdventOfCode.Year2022.Day2.Interfaces;

namespace AdventOfCode.Tests.Year2022.Day2;

public class RoundScorerTests
{
    [Fact]
    public void GetScore_WithValidInputs_ReturnsScore()
    {
        //Arrange
        var choice = Rps.Rock;
        var result = Result.Draw;
        var mockChoiceScorer = new Mock<IChoiceScorer>();
        mockChoiceScorer
            .Setup(s => s.GetScore(choice))
            .Returns(7);

        var mockResultScorer = new Mock<IResultScorer>();
        mockResultScorer
            .Setup(s => s.GetScore(result))
            .Returns(3);

        IRoundScorer scorer = new RoundScorer(mockChoiceScorer.Object, mockResultScorer.Object);

        //Act
        var actual = scorer.GetScore(choice, result);

        //Assert
        actual.Should().Be(10);
    }
}