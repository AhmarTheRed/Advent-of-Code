using System.Text.RegularExpressions;
using AdventOfCode.Year2022.Day7.Interfaces;
using AdventOfCode.Year2022.Day7.Models;

namespace AdventOfCode.Year2022.Day7.Services;

public class FileItemParser : TerminalOutputParser
{
    public FileItemParser(ITerminalOutputParser? next) : base(next)
    {
    }

    protected override bool CanParse(string terminalOutput)
    {
        return Regex.IsMatch(terminalOutput, @"^\d");
    }

    protected override void ActualParse(ref Node currentNode, string input)
    {
        var inputs = input.Split(' ');

        ((DirectoryNode) currentNode).Offsprings.Add(new FileNode(inputs[1], int.Parse(inputs[0]))
        {
            Parent = currentNode
        });
    }
}