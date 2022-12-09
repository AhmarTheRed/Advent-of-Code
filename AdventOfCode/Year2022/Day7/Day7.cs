using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Models;
using AdventOfCode.Year2022.Day7.Interfaces;
using AdventOfCode.Year2022.Day7.Models;

namespace AdventOfCode.Year2022.Day7;

public class Day7 : BaseDay
{
    private const int SizeCap = 100000;
    private const int TotalSpace = 70000000;
    private readonly ITerminalOutputParser _parserChain;

    public Day7(IInputFileService inputFileService, ITerminalOutputParser parserChain) : base("Day7.txt",
        inputFileService)
    {
        _parserChain = parserChain;
    }

    public int GetSumOf100KAndLessDirectories()
    {
        var baseNode = GetBaseNode();

        return GetTotal(baseNode);
    }

    private DirectoryNode GetBaseNode()
    {
        var inputs = GetInputs().ToList();

        Node startNode = new DirectoryNode("/");

        for (var i = 1; i < inputs.Count; i++) _parserChain.Parse(ref startNode, inputs[i]);

        var baseNode = GetBaseNode(startNode);

        return baseNode;
    }

    public int GetDirectoryToDelete(int freeSpaceRequired)
    {
        var baseNode = GetBaseNode();

        var directories = new List<DirectoryNode> {baseNode}.Concat(GetSubDirectories(baseNode));

        var spaceToFreeUp = freeSpaceRequired - (TotalSpace - baseNode.Size);

        return directories.Where(d => d.Size >= spaceToFreeUp).Min(d => d.Size);
    }

    private IEnumerable<DirectoryNode> GetSubDirectories(DirectoryNode baseNode)
    {
        var directories = baseNode.Offsprings.OfType<DirectoryNode>().ToList();

        foreach (var directory in directories) directories = directories.Concat(GetSubDirectories(directory)).ToList();

        return directories;
    }

    private static DirectoryNode GetBaseNode(Node node)
    {
        var baseNode = node.Parent;

        while (baseNode?.Parent != null)
            baseNode = baseNode.Parent;

        return (DirectoryNode) baseNode;
    }

    private int GetTotal(DirectoryNode node)
    {
        return (node.Size <= SizeCap ? node.Size : 0) +
               node.Offsprings.OfType<DirectoryNode>().Sum(GetTotal);
    }
}