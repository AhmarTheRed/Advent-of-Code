using AdventOfCode.Common.Interfaces;
using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2;

public class Day2
{
    private const string InputFileName = "Day2.txt";
    private readonly IInputFileService _inputFileService;
    private readonly string _lineSplitter = Environment.NewLine;
    private readonly IRoundCreator _roundCreator;

    public Day2(IInputFileService inputFileService, IRoundCreator roundCreator)
    {
        _inputFileService = inputFileService;
        _roundCreator = roundCreator;
    }

    public int GetTotalScore()
    {
        var input = _inputFileService.GetInput(InputFileName);

        var inputs = input
            .Split(_lineSplitter)
            .Where(i => !string.IsNullOrWhiteSpace(i));

        var rounds = inputs.Select(GetRound);

        return rounds.Sum(r => r.Score);
    }

    private Round GetRound(string input)
    {
        return _roundCreator.CreateRound(input);
    }
}