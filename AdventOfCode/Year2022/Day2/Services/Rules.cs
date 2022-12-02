using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Services;

public class Rules : IRules
{
    public IEnumerable<Game> GetRules()
    {
        return new List<Game>
        {
            new()
            {
                YourChoice = Choice.Rock,
                OpponentChoice = Choice.Rock,
                Result = Result.Draw
            },
            new()
            {
                YourChoice = Choice.Rock,
                OpponentChoice = Choice.Paper,
                Result = Result.Loss
            },
            new()
            {
                YourChoice = Choice.Rock,
                OpponentChoice = Choice.Scissors,
                Result = Result.Win
            },
            new()
            {
                YourChoice = Choice.Paper,
                OpponentChoice = Choice.Rock,
                Result = Result.Win
            },
            new()
            {
                YourChoice = Choice.Paper,
                OpponentChoice = Choice.Paper,
                Result = Result.Draw
            },
            new()
            {
                YourChoice = Choice.Paper,
                OpponentChoice = Choice.Scissors,
                Result = Result.Loss
            },
            new()
            {
                YourChoice = Choice.Scissors,
                OpponentChoice = Choice.Rock,
                Result = Result.Loss
            },
            new()
            {
                YourChoice = Choice.Scissors,
                OpponentChoice = Choice.Paper,
                Result = Result.Win
            },
            new()
            {
                YourChoice = Choice.Scissors,
                OpponentChoice = Choice.Scissors,
                Result = Result.Draw
            }
        };
    }
}