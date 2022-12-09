namespace AdventOfCode.Year2022.Day7.Models;

public class FileNode : Node
{
    public FileNode(string name, int size) : base(name, NodeType.File)
    {
        Size = size;
    }


    public override int Size { get; }
}