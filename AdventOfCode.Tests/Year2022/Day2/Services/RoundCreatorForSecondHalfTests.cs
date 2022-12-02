using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;
using AdventOfCode.Year2022.Day2.Services;

namespace AdventOfCode.Tests.Year2022.Day2.Services;

public class RoundCreatorForSecondHalfTests
{
    [Fact]
    public void CreateRound_WithValidInput_ReturnsPopulatedRound()
    {
        //Arrange
        const string opponentChoice = "A";
        const string result = "Y";
        const string input = $"{opponentChoice} {result}";
        const int score = 4;
        var expected = new Round
        {
            Game = new Game
            {
                OpponentChoice = Choice.Rock,
                YourChoice = Choice.Rock,
                Result = Result.Draw
            },
            Score = score
        };
        var mockChoiceInputParser = new Mock<IChoiceInputParser>();
        mockChoiceInputParser
            .Setup(p => p.Parse(opponentChoice))
            .Returns(Choice.Rock);

        var mockResultInputParser = new Mock<IResultInputParser>();
        mockResultInputParser
            .Setup(p => p.Parse(result))
            .Returns(Result.Draw);

        var mockChoiceCalculator = new Mock<IChoiceCalculator>();
        mockChoiceCalculator
            .Setup(d => d.Calculate(It.IsAny<Choice>(), It.IsAny<Result>()))
            .Returns(Choice.Rock);

        var mockRoundScorer = new Mock<IRoundScorer>();
        mockRoundScorer
            .Setup(d => d.GetScore(It.IsAny<Choice>(), It.IsAny<Result>()))
            .Returns(score);

        IRoundCreator creator = new RoundCreatorForSecondHalf(mockChoiceInputParser.Object,
            mockResultInputParser.Object, mockChoiceCalculator.Object, mockRoundScorer.Object);

        //Act
        var actual = creator.CreateRound(input);

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }
}