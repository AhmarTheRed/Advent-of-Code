using AdventOfCode.Year2022.Day2.Interfaces;

namespace AdventOfCode.Year2022.Day2;

public class ChoiceScorer : IChoiceScorer
{
    public int GetScore(Rps choice)
    {
        return choice switch
        {
            Rps.Rock => 1,
            Rps.Paper => 2,
            Rps.Scissors => 3,
            _ => throw new ArgumentOutOfRangeException(nameof(choice), choice, null)
        };
    }
}