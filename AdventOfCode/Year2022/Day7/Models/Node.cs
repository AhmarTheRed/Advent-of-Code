namespace AdventOfCode.Year2022.Day7.Models;

public abstract class Node
{
    private readonly NodeType _nodeType;

    protected Node(string name, NodeType nodeType)
    {
        Name = name;
        _nodeType = nodeType;
    }

    public Node? Parent { get; set; }

    public string? Name { get; init; }

    public abstract int Size { get; }
}