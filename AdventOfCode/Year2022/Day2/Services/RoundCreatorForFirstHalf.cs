using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Services;

public class RoundCreatorForFirstHalf : IRoundCreator
{
    private readonly IChoiceInputParser _choiceInputParser;
    private readonly IRoundDecider _roundDecider;
    private readonly IRoundScorer _roundScorer;

    public RoundCreatorForFirstHalf(IChoiceInputParser choiceInputParser, IRoundDecider roundDecider,
        IRoundScorer roundScorer)
    {
        _choiceInputParser = choiceInputParser;
        _roundDecider = roundDecider;
        _roundScorer = roundScorer;
    }

    public Round CreateRound(string input)
    {
        var inputs = input.Split(' ');

        var opponentChoice = _choiceInputParser.Parse(inputs[0]);

        var yourChoice = _choiceInputParser.Parse(inputs[1]);

        var result = _roundDecider.DecideRound(yourChoice, opponentChoice);

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