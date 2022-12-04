namespace AdventOfCode.Year2022.Day4.Interfaces;

public interface IListGenerator
{
    IEnumerable<int> GetList(int start, int end);
}