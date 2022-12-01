using AdventOfCode.Common.Interfaces;

namespace AdventOfCode.Year2022;

public class Day1
{
    private const string InputFileName = "Day1";
    private const string NewLineSplitter = "\n";
    private readonly IInputFileService _inputFileService;

    public Day1(IInputFileService inputFileService)
    {
        _inputFileService = inputFileService;
    }

    public int GetMostCalories()
    {
        var input = _inputFileService.GetInput(InputFileName);

        var inputsPerElf = input.Split($"{NewLineSplitter}{NewLineSplitter}");

        var elfCaloricTotals = inputsPerElf.Select(GetTotalCalories);

        return elfCaloricTotals.Max();
    }

    private static int GetTotalCalories(string input)
    {
        var calories = input.Split(NewLineSplitter).Where(i => !string.IsNullOrWhiteSpace(i)).Select(int.Parse);

        return calories.Sum();
    }
}