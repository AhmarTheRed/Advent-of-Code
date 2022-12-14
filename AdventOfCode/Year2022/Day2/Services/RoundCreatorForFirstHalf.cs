using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Services;

public class RoundCreatorForFirstHalf : IRoundCreator
{
    private readonly IChoiceInputParser _choiceInputParser;
    private readonly IResultCalculator _resultCalculator;
    private readonly IRoundScorer _roundScorer;

    public RoundCreatorForFirstHalf(IChoiceInputParser choiceInputParser, IResultCalculator resultCalculator,
        IRoundScorer roundScorer)
    {
        _choiceInputParser = choiceInputParser;
        _resultCalculator = resultCalculator;
        _roundScorer = roundScorer;
    }

    public Round CreateRound(string input)
    {
        var inputs = input.Split(' ');

        var opponentChoice = _choiceInputParser.Parse(inputs[0]);

        var yourChoice = _choiceInputParser.Parse(inputs[1]);

        var result = _resultCalculator.Calculate(yourChoice, opponentChoice);

        return new Round
        {
            Game = new Game
            {
                OpponentChoice = opponentChoice,
                YourChoice = yourChoice,
                Result = result
            },
            Score = _roundScorer.GetScore(yourChoice, result)
        };
    }
}