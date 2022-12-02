using AdventOfCode.Year2022.Day2;
using AdventOfCode.Year2022.Day2.Interfaces;

namespace AdventOfCode.Tests.Year2022.Day2;

public class RoundCreatorTests
{
    [Fact]
    public void CreateRound_WithValidInput_ReturnsPopulatedRound()
    {
        //Arrange
        const string opponentChoice = "A";
        const string yourChoice = "Y";
        var input = $"{opponentChoice} {yourChoice}";
        var score = 8;
        var expected = new Round
        {
            YourChoice = Rps.Paper,
            OpponentChoice = Rps.Rock,
            Result = Result.Win,
            Score = score
        };
        var mockInputParser = new Mock<IRpsInputParser>();
        mockInputParser
            .Setup(p => p.Parse(opponentChoice))
            .Returns(Rps.Rock);
        mockInputParser
            .Setup(p => p.Parse(yourChoice))
            .Returns(Rps.Paper);

        var mockRoundDecider = new Mock<IRoundDecider>();
        mockRoundDecider
            .Setup(d => d.DecideRound(It.IsAny<Rps>(), It.IsAny<Rps>()))
            .Returns(Result.Win);

        var mockRoundScorer = new Mock<IRoundScorer>();
        mockRoundScorer
            .Setup(d => d.GetScore(It.IsAny<Rps>(), It.IsAny<Result>()))
            .Returns(score);

        IRoundCreator creator =
            new RoundCreator(mockInputParser.Object, mockRoundDecider.Object, mockRoundScorer.Object);

        //Act
        var actual = creator.CreateRound(input);

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }
}