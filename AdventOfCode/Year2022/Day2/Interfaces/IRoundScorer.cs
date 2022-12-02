namespace AdventOfCode.Year2022.Day2.Interfaces;

public interface IRoundScorer
{
    public int GetScore(Rps choice, Result result);
}