using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Interfaces;

public interface IRoundScorer
{
    int GetScore(Choice choice, Result result);
}