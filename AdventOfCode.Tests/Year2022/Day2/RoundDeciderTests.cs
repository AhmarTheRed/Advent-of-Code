using AdventOfCode.Year2022.Day2;
using AdventOfCode.Year2022.Day2.Interfaces;

namespace AdventOfCode.Tests.Year2022.Day2;

public class RoundDeciderTests
{
    [Theory]
    [InlineData(Rps.Rock, Rps.Rock, Result.Draw)]
    [InlineData(Rps.Rock, Rps.Paper, Result.Loss)]
    [InlineData(Rps.Rock, Rps.Scissors, Result.Win)]
    [InlineData(Rps.Paper, Rps.Rock, Result.Win)]
    [InlineData(Rps.Paper, Rps.Paper, Result.Draw)]
    [InlineData(Rps.Paper, Rps.Scissors, Result.Loss)]
    [InlineData(Rps.Scissors, Rps.Rock, Result.Loss)]
    [InlineData(Rps.Scissors, Rps.Paper, Result.Win)]
    [InlineData(Rps.Scissors, Rps.Scissors, Result.Draw)]
    public void DecideRound_WithValidInputs_ReturnsResult(Rps yourChoice, Rps opponentChoice, Result expected)
    {
        //Arrange
        IRoundDecider decider = new RoundDecider();

        //Act
        var actual = decider.DecideRound(yourChoice, opponentChoice);

        //Assert
        actual.Should().Be(expected);
    }
}