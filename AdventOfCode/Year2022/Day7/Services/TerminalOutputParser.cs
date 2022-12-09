using AdventOfCode.Year2022.Day7.Interfaces;
using AdventOfCode.Year2022.Day7.Models;

namespace AdventOfCode.Year2022.Day7.Services;

public abstract class TerminalOutputParser : ITerminalOutputParser
{
    protected ITerminalOutputParser? Next;

    protected TerminalOutputParser(ITerminalOutputParser? next)
    {
        Next = next;
    }

    public void Parse(ref Node currentNode, string input)
    {
        if (CanParse(input))
            ActualParse(ref currentNode, input);
        else
            Next?.Parse(ref currentNode, input);
    }

    protected abstract bool CanParse(string terminalOutput);

    protected abstract void ActualParse(ref Node currentNode, string input);
}