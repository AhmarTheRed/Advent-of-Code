using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Models;
using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2;

public class Day2Puzzle : BaseDayPuzzle
{
    private readonly IRoundCreator _roundCreator;

    public Day2Puzzle(IInputFileService inputFileService, IRoundCreator roundCreator) : base("Day2.txt",
        inputFileService)
    {
        _roundCreator = roundCreator;
    }

    public int GetTotalScore()
    {
        var inputs = GetInputs();

        var rounds = inputs.Select(GetRound);

        return rounds.Sum(r => r.Score);
    }

    private Round GetRound(string input)
    {
        return _roundCreator.CreateRound(input);
    }
}