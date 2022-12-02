using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Services;

public class RoundDecider : IRoundDecider
{
    public Result DecideRound(Choice yourChoice, Choice opponentChoice)
    {
        return yourChoice switch
        {
            Choice.Rock => opponentChoice switch
            {
                Choice.Rock => Result.Draw,
                Choice.Paper => Result.Loss,
                Choice.Scissors => Result.Win,
                _ => throw new ArgumentOutOfRangeException(nameof(opponentChoice), opponentChoice, null)
            },
            Choice.Paper => opponentChoice switch
            {
                Choice.Rock => Result.Win,
                Choice.Paper => Result.Draw,
                Choice.Scissors => Result.Loss,
                _ => throw new ArgumentOutOfRangeException(nameof(opponentChoice), opponentChoice, null)
            },
            Choice.Scissors => opponentChoice switch
            {
                Choice.Rock => Result.Loss,
                Choice.Paper => Result.Win,
                Choice.Scissors => Result.Draw,
                _ => throw new ArgumentOutOfRangeException(nameof(opponentChoice), opponentChoice, null)
            },
            _ => throw new ArgumentOutOfRangeException(nameof(yourChoice), yourChoice, null)
        };
    }
}