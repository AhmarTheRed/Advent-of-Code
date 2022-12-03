namespace AdventOfCode.Year2022.Day3.Interfaces;

public interface IDuplicateFinderService
{
    public IEnumerable<char> GetDuplicates(IEnumerable<char> first, IEnumerable<char> second);
}