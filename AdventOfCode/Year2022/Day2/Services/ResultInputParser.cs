using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Services;

public class ResultInputParser : IResultInputParser
{
    public Result Parse(string input)
    {
        return input switch
        {
            "X" => Result.Loss,
            "Y" => Result.Draw,
            "Z" => Result.Win,
            _ => throw new ArgumentOutOfRangeException(nameof(input), input, null)
        };
    }
}