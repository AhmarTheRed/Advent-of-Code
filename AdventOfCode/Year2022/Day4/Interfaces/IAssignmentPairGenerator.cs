using AdventOfCode.Year2022.Day4.Models;

namespace AdventOfCode.Year2022.Day4.Interfaces;

public interface IAssignmentPairGenerator
{
    IEnumerable<Assignment> GetAssignmentPair(string input);
}