using System.Text.RegularExpressions;
using AdventOfCode.Year2022.Day5.Interface;
using AdventOfCode.Year2022.Day5.Models;

namespace AdventOfCode.Year2022.Day5.Services;

public class MoveGenerator : IMoveGenerator
{
    private const string RegexMatchPattern = @"([0-9]+)";

    public Move GetMove(string input)
    {
        var regex = new Regex(RegexMatchPattern);

        var matches = regex.Matches(input);

        return new Move
        {
            Amount = int.Parse(matches[0].Value),
            From = int.Parse(matches[1].Value),
            To = int.Parse(matches[2].Value)
        };
    }
}