using AdventOfCode.Year2022.Day3.Interfaces;

namespace AdventOfCode.Year2022.Day3.Services;

public class DuplicateFinderService : IDuplicateFinderService
{
    public IEnumerable<char> GetDuplicates(IEnumerable<char> first, IEnumerable<char> second)
    {
        return first.Where(second.Contains).Distinct();
    }
}