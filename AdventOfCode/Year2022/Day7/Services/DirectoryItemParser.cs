using AdventOfCode.Year2022.Day7.Interfaces;
using AdventOfCode.Year2022.Day7.Models;

namespace AdventOfCode.Year2022.Day7.Services;

public class DirectoryItemParser : TerminalOutputParser
{
    private const string IdentifierString = "dir ";

    public DirectoryItemParser(ITerminalOutputParser? next) : base(next)
    {
    }

    protected override bool CanParse(string terminalOutput)
    {
        return terminalOutput.StartsWith(IdentifierString);
    }

    protected override void ActualParse(ref Node currentNode, string input)
    {
        var directoryName = GetSubjectName(input);

        ((DirectoryNode) currentNode).Offsprings.Add(new DirectoryNode(directoryName)
        {
            Parent = currentNode
        });
    }

    private string GetSubjectName(string input)
    {
        return input.Substring(IdentifierString.Length);
    }
}