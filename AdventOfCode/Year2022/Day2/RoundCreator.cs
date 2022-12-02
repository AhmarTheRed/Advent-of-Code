using AdventOfCode.Year2022.Day2.Interfaces;

namespace AdventOfCode.Year2022.Day2;

public class RoundCreator : IRoundCreator
{
    private readonly IRoundDecider _roundDecider;
    private readonly IRoundScorer _roundScorer;
    private readonly IRpsInputParser _rpsInputParser;

    public RoundCreator(IRpsInputParser rpsInputParser, IRoundDecider roundDecider, IRoundScorer roundScorer)
    {
        _rpsInputParser = rpsInputParser;
        _roundDecider = roundDecider;
        _roundScorer = roundScorer;
    }

    public Round CreateRound(string input)
    {
        var inputs = input.Split(' ');

        var opponentChoice = _rpsInputParser.Parse(inputs[0]);

        var yourChoice = _rpsInputParser.Parse(inputs[1]);

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