using AdventOfCode.Year2022.Day7.Interfaces;
using AdventOfCode.Year2022.Day7.Models;

namespace AdventOfCode.Year2022.Day7.Services;

public class ListDirectoryParser : TerminalOutputParser
{
    private const string IdentifierString = "$ ls";

    public ListDirectoryParser(ITerminalOutputParser next) : base(next)
    {
    }

    protected override bool CanParse(string terminalOutput)
    {
        return terminalOutput.StartsWith(IdentifierString);
    }

    protected override void ActualParse(ref Node currentNode, string input)
    {
        //Do nothing
    }
}