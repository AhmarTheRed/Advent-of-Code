using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Models;
using AdventOfCode.Year2022.Day8.Interfaces;

namespace AdventOfCode.Year2022.Day8;

public class Day8 : BaseDay
{
    private readonly IForestGenerator _forestGenerator;

    public Day8(IInputFileService inputFileService, IForestGenerator forestGenerator) : base("Day8.txt",
        inputFileService)
    {
        _forestGenerator = forestGenerator;
    }

    public int GetNumberOfVisibleTrees()
    {
        var forest = _forestGenerator.GenerateForest(GetInputs());

        var totalColumns = forest.Length;
        var totalRows = forest[0].Length;

        var total = 2 * (forest.Length - 2) + 2 * forest[0].Length;

        for (var i = 1; i < totalColumns - 1; i++)
        for (var j = 1; j < forest[i].Length - 1; j++)
            if (IsVisibleFromNorth(forest, i, j) ||
                IsVisibleFromSouth(forest, i, j, totalColumns) ||
                IsVisibleFromWest(forest, i, j) ||
                IsVisibleFromEast(forest, i, j, totalRows))
                total++;

        return total;
    }

    public int GetHighestScenicScore()
    {
        var forest = _forestGenerator.GenerateForest(GetInputs());

        var totalColumns = forest.Length;
        var totalRows = forest[0].Length;

        var highestScenicScore = 0;

        for (var i = 1; i < totalColumns - 1; i++)
        for (var j = 1; j < forest[i].Length - 1; j++)
        {
            var scenicScore = GetNorthViewingDistance(forest, i, j) *
                              GetSouthViewingDistance(forest, i, j, totalColumns) *
                              GetWestViewingDistance(forest, i, j) *
                              GetEastViewingDistance(forest, i, j, totalRows);

            if (scenicScore > highestScenicScore)
                highestScenicScore = scenicScore;
        }

        return highestScenicScore;
    }

    private bool IsVisibleFromNorth(int[][] forest, int i, int j)
    {
        for (var x = 0; x < i; x++)
            if (forest[x][j] >= forest[i][j])
                return false;

        return true;
    }

    private int GetNorthViewingDistance(int[][] forest, int i, int j)
    {
        var distance = 0;
        for (var x = i - 1; x >= 0; x--)
        {
            if (forest[x][j] >= forest[i][j])
                return ++distance;

            distance++;
        }

        return distance;
    }

    private bool IsVisibleFromSouth(int[][] forest, int i, int j, int totalColumns)
    {
        for (var x = i + 1; x < totalColumns; x++)
            if (forest[x][j] >= forest[i][j])
                return false;

        return true;
    }

    private int GetSouthViewingDistance(int[][] forest, int i, int j, int totalColumns)
    {
        var distance = 0;
        for (var x = i + 1; x < totalColumns; x++)
        {
            if (forest[x][j] >= forest[i][j])
                return ++distance;

            distance++;
        }

        return distance;
    }

    private bool IsVisibleFromWest(int[][] forest, int i, int j)
    {
        for (var x = 0; x < j; x++)
            if (forest[i][x] >= forest[i][j])
                return false;

        return true;
    }

    private int GetWestViewingDistance(int[][] forest, int i, int j)
    {
        var distance = 0;
        for (var x = j - 1; x >= 0; x--)
        {
            if (forest[i][x] >= forest[i][j])
                return ++distance;

            distance++;
        }

        return distance;
    }

    private bool IsVisibleFromEast(int[][] forest, int i, int j, int totalRows)
    {
        for (var x = j + 1; x < totalRows; x++)
            if (forest[i][x] >= forest[i][j])
                return false;

        return true;
    }

    private int GetEastViewingDistance(int[][] forest, int i, int j, int totalRows)
    {
        var distance = 0;
        for (var x = j + 1; x < totalRows; x++)
        {
            if (forest[i][x] >= forest[i][j])
                return ++distance;

            distance++;
        }

        return distance;
    }
}