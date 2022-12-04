using AdventOfCode.Year2022.Day4.Models;

namespace AdventOfCode.Year2022.Day4.Interfaces;

public interface IOverlapChecker
{
    bool IsOverlap(Assignment assignment1, Assignment assignment2);
}