using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Models;
using AdventOfCode.Year2022.Day4.Interfaces;
using AdventOfCode.Year2022.Day4.Models;

namespace AdventOfCode.Year2022.Day4;

public class Day4 : BaseDay
{
    private readonly IAssignmentPairGenerator _assignmentPairGenerator;
    private readonly IOverlapChecker _overlapChecker;

    public Day4(IInputFileService inputFileService, IAssignmentPairGenerator assignmentPairGenerator,
        IOverlapChecker overlapChecker) : base("Day4.txt", inputFileService)
    {
        _assignmentPairGenerator = assignmentPairGenerator;
        _overlapChecker = overlapChecker;
    }

    public int GetFullOverlappingAssignmentPairsTotal()
    {
        return GetInputs()
            .Select(i => _assignmentPairGenerator.GetAssignmentPair(i).ToList())
            .Count(p => _overlapChecker.CheckOverlap(p[0], p[1]) == OverlapType.Full);
    }

    public int GetAllOverlappingAssignmentPairsTotal()
    {
        return GetInputs()
            .Select(i => _assignmentPairGenerator.GetAssignmentPair(i).ToList())
            .Count(p => _overlapChecker.CheckOverlap(p[0], p[1]) != OverlapType.None);
    }
}