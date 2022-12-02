using AdventOfCode.Year2022.Day2.Interfaces;

namespace AdventOfCode.Year2022.Day2;

public class RpsInputParser : IRpsInputParser
{
    public Rps Parse(string input)
    {
        return input switch
        {
            "A" => Rps.Rock,
            "X" => Rps.Rock,
            "B" => Rps.Paper,
            "Y" => Rps.Paper,
            "C" => Rps.Scissors,
            "Z" => Rps.Scissors,
            _ => throw new ArgumentOutOfRangeException(nameof(input), input, null)
        };
    }
}