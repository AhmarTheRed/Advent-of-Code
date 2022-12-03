using AdventOfCode.Common.Interfaces;
using AdventOfCode.Year2022.Day3.Interfaces;

namespace AdventOfCode.Year2022.Day3;

public class Day3
{
    private const string InputFileName = "Day3.txt";
    private readonly IDuplicateFinderService _duplicateFinderService;
    private readonly IInputFileService _inputFileService;
    private readonly IItemPriorityService _itemPriorityService;
    private readonly string _lineSplitter = Environment.NewLine;

    public Day3(IInputFileService inputFileService, IDuplicateFinderService duplicateFinderService,
        IItemPriorityService itemPriorityService)
    {
        _itemPriorityService = itemPriorityService;
        _inputFileService = inputFileService;
        _duplicateFinderService = duplicateFinderService;
    }

    public int GetCommonPriorityTotal()
    {
        var input = _inputFileService.GetInput(InputFileName);

        var inputs = input
            .Split(_lineSplitter)
            .Where(i => !string.IsNullOrWhiteSpace(i));

        var duplicates = inputs.Select(GetDuplicates);

        return duplicates.SelectMany(d => d).Select(_itemPriorityService.GetPriority).Sum();
    }

    private IEnumerable<char> GetDuplicates(string inputs)
    {
        var bucketItems = inputs.ToCharArray();

        var firstContainerItems = bucketItems.Take(bucketItems.Length / 2);

        var secondContainerItems = bucketItems.Skip(bucketItems.Length / 2);

        return _duplicateFinderService.GetDuplicates(firstContainerItems, secondContainerItems);
    }
}