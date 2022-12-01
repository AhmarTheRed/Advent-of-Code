using AdventOfCode.Common.Interfaces;

namespace AdventOfCode.Year2022;

public class Day1
{
    private const string InputFileName = "Day1";
    private readonly string _lineSplitter = Environment.NewLine;
    private readonly IInputFileService _inputFileService;

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
        var input = _inputFileService.GetInput(InputFileName);

        var inputsPerElf = input
            .Split($"{_lineSplitter}{_lineSplitter}")
            .Where(i => !string.IsNullOrWhiteSpace(i));

        var elfCaloricTotals = inputsPerElf.Select(GetTotalCalories);
        return elfCaloricTotals;
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