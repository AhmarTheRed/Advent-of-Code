using AdventOfCode.Year2022.Day5.Models;

namespace AdventOfCode.Year2022.Day5.Interface;

public interface IMoveGenerator
{
    Move GetMove(string input);
}