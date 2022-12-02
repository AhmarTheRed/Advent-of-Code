using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Services;

public class RoundCreator : IRoundCreator
{
    private readonly IRoundDecider _roundDecider;
    private readonly IRoundScorer _roundScorer;
    private readonly IRpsChoiceInputParser _rpsChoiceInputParser;

    public RoundCreator(IRpsChoiceInputParser rpsChoiceInputParser, IRoundDecider roundDecider,
        IRoundScorer roundScorer)
    {
        _rpsChoiceInputParser = rpsChoiceInputParser;
        _roundDecider = roundDecider;
        _roundScorer = roundScorer;
    }

    public Round CreateRound(string input)
    {
        var inputs = input.Split(' ');

        var opponentChoice = _rpsChoiceInputParser.Parse(inputs[0]);

        var yourChoice = _rpsChoiceInputParser.Parse(inputs[1]);

        var result = _roundDecider.DecideRound(yourChoice, opponentChoice);

        return new Round
        {
            OpponentChoice = opponentChoice,
            YourChoice = yourChoice,
            Result = result,
            Score = _roundScorer.GetScore(yourChoice, result)
        };
    }
}