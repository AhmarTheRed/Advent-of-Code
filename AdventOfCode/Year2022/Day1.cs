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
        var elfCaloricTotals = GetElfCaloricTotals();

        return elfCaloricTotals.Max();
    }

    public IEnumerable<int> GetTop3MostCalories()
    {
        var elfCaloricTotals = GetElfCaloricTotals();

        var orderedElfCaloricTotals = elfCaloricTotals.OrderByDescending(t => t).ToList();

        for (var i = 0; i < orderedElfCaloricTotals.Count && i < 3; i++)
            yield return orderedElfCaloricTotals[i];
    }

    public int GetTop3MostCaloriesTotal()
    {
        return GetTop3MostCalories().Sum();
    }

    private IEnumerable<int> GetElfCaloricTotals()
    {
        var input = _inputFileService.GetInput(InputFileName);

        var inputsPerElf = input
            .Split($"{NewLineSplitter}{NewLineSplitter}")
            .Where(i => !string.IsNullOrWhiteSpace(i));

        var elfCaloricTotals = inputsPerElf.Select(GetTotalCalories);
        return elfCaloricTotals;
    }

    private static int GetTotalCalories(string input)
    {
        var calories = input
            .Split(NewLineSplitter)
            .Where(i => !string.IsNullOrWhiteSpace(i))
            .Select(int.Parse);

        return calories.Sum();
    }
}