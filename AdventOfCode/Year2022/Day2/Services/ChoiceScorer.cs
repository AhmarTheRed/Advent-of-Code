using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Services;

public class ChoiceScorer : IChoiceScorer
{
    public int GetScore(Choice choice)
    {
        return choice switch
        {
            Choice.Rock => 1,
            Choice.Paper => 2,
            Choice.Scissors => 3,
            _ => throw new ArgumentOutOfRangeException(nameof(choice), choice, null)
        };
    }
}