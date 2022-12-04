namespace AdventOfCode.Year2022.Day3.Interfaces;

public interface IDuplicateFinderService
{
    IEnumerable<char> GetCommonItems(params IEnumerable<char>[] collections);
}