using AdventOfCode.Year2022.Day4.Interfaces;
using AdventOfCode.Year2022.Day4.Models;

namespace AdventOfCode.Year2022.Day4.Services;

public class OverlapChecker : IOverlapChecker
{
    public bool IsOverlap(Assignment assignment1, Assignment assignment2)
    {
        return (assignment1.Start <= assignment2.Start && assignment1.End >= assignment2.End) ||
               (assignment2.Start <= assignment1.Start && assignment2.End >= assignment1.End);
    }
}