namespace AdventOfCode.Year2022.Day8.Interfaces;

public interface IForestGenerator
{
    int[][] GenerateForest(IEnumerable<string> inputs);
}