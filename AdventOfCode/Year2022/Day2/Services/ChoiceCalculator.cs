using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Services;

public class ChoiceCalculator : IChoiceCalculator
{
    private readonly IRules _rules;

    public ChoiceCalculator(IRules rules)
    {
        _rules = rules;
    }

    public Choice Calculate(Choice choice, Result result)
    {
        return _rules.GetRules().Single(r => r.OpponentChoice == choice && r.Result == result).YourChoice;
    }
}