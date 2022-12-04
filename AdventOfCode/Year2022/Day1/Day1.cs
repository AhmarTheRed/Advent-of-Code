using AdventOfCode.Common.Interfaces;

namespace AdventOfCode.Year2022.Day1;

public class Day1
{
    private const string InputFileName = "Day1";
    private readonly IInputFileService _inputFileService;
    private readonly string _lineSplitter = Environment.NewLine;

    public Day1(IInputFileService inputFileService)
    {
        _inputFileService = inputFileService;
    }

    public int GetMostCalories()
    {
        var elfCaloricTotals = GetElfCaloricTotals();

        return elfCaloricTotals.Max();
    }

    public IEnumerable<int> GetTop3MostCalories()
    {
        var elfCaloricTotals = GetElfCaloricTotals();

        var orderedElfCaloricTotals = elfCaloricTotals.OrderByDescending(t => t).ToList();

        return orderedElfCaloricTotals.Take(3);
    }

    public int GetTop3MostCaloriesTotal()
    {
        return GetTop3MostCalories().Sum();
    }

    private IEnumerable<int> GetElfCaloricTotals()
    {
        var inputsPerElf = _inputFileService.GetInputs(InputFileName, $"{_lineSplitter}{_lineSplitter}");

        return inputsPerElf.Select(GetTotalCalories);
    }

    private int GetTotalCalories(string input)
    {
        var calories = input
            .Split(_lineSplitter)
            .Where(i => !string.IsNullOrWhiteSpace(i))
            .Select(int.Parse);

        return calories.Sum();
    }
}