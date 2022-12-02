using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Services;

public class RoundCreatorForSecondHalf : IRoundCreator
{
    private readonly IChoiceCalculator _choiceCalculator;
    private readonly IChoiceInputParser _choiceInputParser;
    private readonly IResultInputParser _resultInputParser;
    private readonly IRoundScorer _roundScorer;

    public RoundCreatorForSecondHalf(IChoiceInputParser choiceInputParser, IResultInputParser resultInputParser,
        IChoiceCalculator choiceCalculator, IRoundScorer roundScorer)
    {
        _choiceInputParser = choiceInputParser;
        _resultInputParser = resultInputParser;
        _choiceCalculator = choiceCalculator;
        _roundScorer = roundScorer;
    }

    public Round CreateRound(string input)
    {
        var inputs = input.Split(' ');

        var opponentChoice = _choiceInputParser.Parse(inputs[0]);

        var result = _resultInputParser.Parse(inputs[1]);

        var yourChoice = _choiceCalculator.Calculate(opponentChoice, result);

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