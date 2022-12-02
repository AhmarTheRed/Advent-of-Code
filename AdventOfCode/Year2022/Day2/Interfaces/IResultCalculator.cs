using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Interfaces;

public interface IResultCalculator
{
    Result Calculate(Choice yourChoice, Choice opponentChoice);
}