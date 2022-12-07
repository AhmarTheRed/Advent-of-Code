using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Models;

namespace AdventOfCode.Year2022.Day6;

public class Day6 : BaseDay
{
    private readonly int _markerSize;

    public Day6(IInputFileService inputFileService, int markerSize) : base("Day6.txt", inputFileService)
    {
        _markerSize = markerSize;
    }

    public int GetFirstMarkerStartIndex()
    {
        var input = GetInputs().Single();

        return GetFirstMarkerStartIndex(input);
    }

    private int GetFirstMarkerStartIndex(string input)
    {
        for (var i = 0; i < input.Length; i++)
        {
            var uniqueMarker = new List<char>();

            for (var j = 0; j < _markerSize; j++)
                uniqueMarker.Add(input[i + j]);

            if (uniqueMarker.Count == uniqueMarker.Distinct().Count())
                return i + _markerSize;
        }

        return -1;
    }
}