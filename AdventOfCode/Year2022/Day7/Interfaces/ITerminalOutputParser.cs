using AdventOfCode.Year2022.Day7.Models;

namespace AdventOfCode.Year2022.Day7.Interfaces;

public interface ITerminalOutputParser
{
    void Parse(ref Node currentNode, string input);
}