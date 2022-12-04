using AdventOfCode.Year2022.Day4.Interfaces;
using AdventOfCode.Year2022.Day4.Models;

namespace AdventOfCode.Year2022.Day4.Services;

public class AssignmentPairGenerator : IAssignmentPairGenerator
{
    public IEnumerable<Assignment> GetAssignmentPair(string input)
    {
        var inputs = input.Split(',');

        return inputs.Select(GetAssignment);
    }

    private Assignment GetAssignment(string input)
    {
        var inputs = input.Split('-');

        return new Assignment
        {
            Start = int.Parse(inputs[0]),
            End = int.Parse(inputs[1])
        };
    }
}