using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Services;

public class RpsChoiceInputParser : IRpsChoiceInputParser
{
    public Choice Parse(string input)
    {
        return input switch
        {
            "A" => Choice.Rock,
            "X" => Choice.Rock,
            "B" => Choice.Paper,
            "Y" => Choice.Paper,
            "C" => Choice.Scissors,
            "Z" => Choice.Scissors,
            _ => throw new ArgumentOutOfRangeException(nameof(input), input, null)
        };
    }
}