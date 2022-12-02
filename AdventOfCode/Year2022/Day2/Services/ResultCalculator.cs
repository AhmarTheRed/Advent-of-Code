using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Services;

public class ResultCalculator : IResultCalculator
{
    private readonly IRules _rules;

    public ResultCalculator(IRules rules)
    {
        _rules = rules;
    }

    public Result Calculate(Choice yourChoice, Choice opponentChoice)
    {
        return _rules.GetRules().Single(g => g.YourChoice == yourChoice && g.OpponentChoice == opponentChoice).Result;
    }
}