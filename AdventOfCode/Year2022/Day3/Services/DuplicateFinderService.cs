using AdventOfCode.Year2022.Day3.Interfaces;

namespace AdventOfCode.Year2022.Day3.Services;

public class DuplicateFinderService : IDuplicateFinderService
{
    public IEnumerable<char> GetCommonItems(params IEnumerable<char>[] collections)
    {
        IList<char> duplicates = new List<char>();

        foreach (var collection in collections)
            duplicates = !duplicates.Any() ? collection.ToList() : duplicates.Intersect(collection).ToList();

        return duplicates.Distinct();
    }
}