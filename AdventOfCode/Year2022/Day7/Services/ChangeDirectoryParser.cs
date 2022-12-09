using AdventOfCode.Year2022.Day7.Interfaces;
using AdventOfCode.Year2022.Day7.Models;

namespace AdventOfCode.Year2022.Day7.Services;

public class ChangeDirectoryParser : TerminalOutputParser
{
    private const string IdentifierString = "$ cd ";

    public ChangeDirectoryParser(ITerminalOutputParser? next) : base(next)
    {
        Next = next;
    }

    protected override bool CanParse(string terminalOutput)
    {
        return terminalOutput.StartsWith(IdentifierString);
    }

    protected override void ActualParse(ref Node currentNode, string input)
    {
        var targetDirectory = GetTargetDirectory(input);

        ChangeDirectory(ref currentNode, targetDirectory);
    }

    private void ChangeDirectory(ref Node currentNode, string targetDirectory)
    {
        if (targetDirectory == "..")
        {
            currentNode = currentNode.Parent;
            return;
        }

        currentNode = ((DirectoryNode) currentNode).Offsprings.Single(o => o.Name == targetDirectory);
    }

    private string GetTargetDirectory(string input)
    {
        return input.Substring(IdentifierString.Length);
    }
}