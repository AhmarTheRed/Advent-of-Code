using AdventOfCode.Year2022.Day4.Interfaces;

namespace AdventOfCode.Year2022.Day4.Services;

public class ListGenerator : IListGenerator
{
    public IEnumerable<int> GetList(int start, int end)
    {
        for (var i = start; i <= end; i++)
            yield return i;
    }
}