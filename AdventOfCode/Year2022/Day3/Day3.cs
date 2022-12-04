using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Models;
using AdventOfCode.Year2022.Day3.Interfaces;

namespace AdventOfCode.Year2022.Day3;

public class Day3 : BaseDay
{
    private readonly IDuplicateFinderService _duplicateFinderService;
    private readonly IInputFileService _inputFileService;
    private readonly IItemPriorityService _itemPriorityService;

    public Day3(IInputFileService inputFileService, IDuplicateFinderService duplicateFinderService,
        IItemPriorityService itemPriorityService) : base("Day3.txt", inputFileService)
    {
        _itemPriorityService = itemPriorityService;
        _inputFileService = inputFileService;
        _duplicateFinderService = duplicateFinderService;
    }

    public int GetBucketCommonPriorityTotal()
    {
        var inputs = GetInputs();

        var duplicates = inputs.Select(GetBucketDuplicates);

        return duplicates.SelectMany(d => d)
            .Select(_itemPriorityService.GetPriority)
            .Sum();
    }

    public int GetGroupCommonPriorityTotal()
    {
        var inputs = GetInputs();

        var duplicates = GetGroupCommon(inputs.ToList());

        return duplicates.SelectMany(d => d)
            .Select(_itemPriorityService.GetPriority)
            .Sum();
    }

    private IEnumerable<IEnumerable<char>> GetGroupCommon(IList<string> inputs)
    {
        IList<IEnumerable<char>> common = new List<IEnumerable<char>>();

        for (var i = 0; i < inputs.Count; i += 3)
        {
            var firstBucket = inputs[i];
            var secondBucket = inputs[i + 1];
            var thirdBucket = inputs[i + 2];

            common.Add(_duplicateFinderService.GetCommonItems(firstBucket, secondBucket, thirdBucket));
        }

        return common;
    }

    private IEnumerable<char> GetBucketDuplicates(string inputs)
    {
        var bucketItems = inputs.ToCharArray();

        var firstContainerItems = bucketItems.Take(bucketItems.Length / 2);

        var secondContainerItems = bucketItems.Skip(bucketItems.Length / 2);

        return _duplicateFinderService.GetCommonItems(firstContainerItems, secondContainerItems);
    }
}