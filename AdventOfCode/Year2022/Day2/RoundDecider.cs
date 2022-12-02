using AdventOfCode.Year2022.Day2.Interfaces;

namespace AdventOfCode.Year2022.Day2;

public class RoundDecider : IRoundDecider
{
    public Result DecideRound(Rps yourChoice, Rps opponentChoice)
    {
        return yourChoice switch
        {
            Rps.Rock => opponentChoice switch
            {
                Rps.Rock => Result.Draw,
                Rps.Paper => Result.Loss,
                Rps.Scissors => Result.Win,
                _ => throw new ArgumentOutOfRangeException(nameof(opponentChoice), opponentChoice, null)
            },
            Rps.Paper => opponentChoice switch
            {
                Rps.Rock => Result.Win,
                Rps.Paper => Result.Draw,
                Rps.Scissors => Result.Loss,
                _ => throw new ArgumentOutOfRangeException(nameof(opponentChoice), opponentChoice, null)
            },
            Rps.Scissors => opponentChoice switch
            {
                Rps.Rock => Result.Loss,
                Rps.Paper => Result.Win,
                Rps.Scissors => Result.Draw,
                _ => throw new ArgumentOutOfRangeException(nameof(opponentChoice), opponentChoice, null)
            },
            _ => throw new ArgumentOutOfRangeException(nameof(yourChoice), yourChoice, null)
        };
    }
}