using AdventOfCode.Year2022.Day5.Models;

namespace AdventOfCode.Year2022.Day5.Interface;

public interface ICargoCraneService
{
    IEnumerable<Stack<char>> DoMoves(IEnumerable<Stack<char>> stacks, IEnumerable<Move> moves);
}