namespace AdventOfCode.Year2022.Day7.Models;

public class DirectoryNode : Node
{
    public DirectoryNode(string name) : base(name, NodeType.Directory)
    {
    }

    public IList<Node> Offsprings { get; init; } = new List<Node>();
    public override int Size => Offsprings.Sum(o => o.Size);
}