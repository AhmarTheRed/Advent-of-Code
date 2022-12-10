using AdventOfCode.Year2022.Day8.Interfaces;

namespace AdventOfCode.Year2022.Day8.Services;

public class ForestGenerator : IForestGenerator
{
    public int[][] GenerateForest(IEnumerable<string> inputs)
    {
        return inputs
            .Select(input => input.ToCharArray()
                .Select(c => Convert.ToInt32(c) - 48)
                .ToArray()).ToArray();
    }
}