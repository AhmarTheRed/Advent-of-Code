using AdventOfCode.Year2022.Day2.Interfaces;

namespace AdventOfCode.Year2022.Day2;

public class ResultScorer : IResultScorer
{
    public int GetScore(Result result)
    {
        return result switch
        {
            Result.Win => 6,
            Result.Loss => 0,
            Result.Draw => 3,
            _ => throw new ArgumentOutOfRangeException(nameof(result), result, null)
        };
    }
}