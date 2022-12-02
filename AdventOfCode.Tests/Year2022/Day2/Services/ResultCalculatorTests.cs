using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;
using AdventOfCode.Year2022.Day2.Services;

namespace AdventOfCode.Tests.Year2022.Day2.Services;

public class ResultCalculatorTests
{
    [Theory]
    [InlineData(Choice.Rock, Choice.Rock, Result.Draw)]
    [InlineData(Choice.Rock, Choice.Paper, Result.Loss)]
    [InlineData(Choice.Rock, Choice.Scissors, Result.Win)]
    [InlineData(Choice.Paper, Choice.Rock, Result.Win)]
    [InlineData(Choice.Paper, Choice.Paper, Result.Draw)]
    [InlineData(Choice.Paper, Choice.Scissors, Result.Loss)]
    [InlineData(Choice.Scissors, Choice.Rock, Result.Loss)]
    [InlineData(Choice.Scissors, Choice.Paper, Result.Win)]
    [InlineData(Choice.Scissors, Choice.Scissors, Result.Draw)]
    public void Calculate_WithValidInputs_ReturnsResult(Choice yourChoice, Choice opponentChoice, Result expected)
    {
        //Arrange
        IResultCalculator calculator = new ResultCalculator(new Rules());

        //Act
        var actual = calculator.Calculate(yourChoice, opponentChoice);

        //Assert
        actual.Should().Be(expected);
    }
}