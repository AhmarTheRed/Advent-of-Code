using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;
using AdventOfCode.Year2022.Day2.Services;

namespace AdventOfCode.Tests.Year2022.Day2.Services;

public class ChoiceCalculatorTests
{
    [Theory]
    [InlineData(Choice.Rock, Result.Draw, Choice.Rock)]
    [InlineData(Choice.Paper, Result.Loss, Choice.Rock)]
    [InlineData(Choice.Scissors, Result.Win, Choice.Rock)]
    [InlineData(Choice.Rock, Result.Win, Choice.Paper)]
    [InlineData(Choice.Paper, Result.Draw, Choice.Paper)]
    [InlineData(Choice.Scissors, Result.Loss, Choice.Paper)]
    [InlineData(Choice.Rock, Result.Loss, Choice.Scissors)]
    [InlineData(Choice.Paper, Result.Win, Choice.Scissors)]
    [InlineData(Choice.Scissors, Result.Draw, Choice.Scissors)]
    public void Calculate_WithValidInputs_ReturnsChoice(Choice opponentChoice, Result result, Choice expected)
    {
        //Arrange
        IChoiceCalculator calculator = new ChoiceCalculator(new Rules());

        //Act
        var actual = calculator.Calculate(opponentChoice, result);

        //Assert
        actual.Should().Be(expected);
    }
}