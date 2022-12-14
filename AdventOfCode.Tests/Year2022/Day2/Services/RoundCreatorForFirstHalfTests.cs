using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;
using AdventOfCode.Year2022.Day2.Services;

namespace AdventOfCode.Tests.Year2022.Day2.Services;

public class RoundCreatorForFirstHalfTests
{
    [Fact]
    public void CreateRound_WithValidInput_ReturnsPopulatedRound()
    {
        //Arrange
        const string opponentChoice = "A";
        const string yourChoice = "Y";
        const string input = $"{opponentChoice} {yourChoice}";
        const int score = 8;
        var expected = new Round
        {
            Game = new Game
            {
                YourChoice = Choice.Paper,
                OpponentChoice = Choice.Rock,
                Result = Result.Win
            },
            Score = score
        };
        var mockChoiceInputParser = new Mock<IChoiceInputParser>();
        mockChoiceInputParser
            .Setup(p => p.Parse(opponentChoice))
            .Returns(Choice.Rock);
        mockChoiceInputParser
            .Setup(p => p.Parse(yourChoice))
            .Returns(Choice.Paper);

        var mockResultCalculator = new Mock<IResultCalculator>();
        mockResultCalculator
            .Setup(d => d.Calculate(It.IsAny<Choice>(), It.IsAny<Choice>()))
            .Returns(Result.Win);

        var mockRoundScorer = new Mock<IRoundScorer>();
        mockRoundScorer
            .Setup(d => d.GetScore(It.IsAny<Choice>(), It.IsAny<Result>()))
            .Returns(score);

        IRoundCreator creator =
            new RoundCreatorForFirstHalf(mockChoiceInputParser.Object, mockResultCalculator.Object,
                mockRoundScorer.Object);

        //Act
        var actual = creator.CreateRound(input);

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }
}