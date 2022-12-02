using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Interfaces;

public interface IChoiceCalculator
{
    Choice Calculate(Choice choice, Result result);
}