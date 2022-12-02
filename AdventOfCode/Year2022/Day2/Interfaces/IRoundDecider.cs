using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Interfaces;

public interface IRoundDecider
{
    Result DecideRound(Choice yourChoice, Choice opponentChoice);
}