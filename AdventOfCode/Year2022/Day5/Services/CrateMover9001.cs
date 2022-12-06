using AdventOfCode.Year2022.Day5.Interface;
using AdventOfCode.Year2022.Day5.Models;

namespace AdventOfCode.Year2022.Day5.Services;

public class CrateMover9001 : ICargoCraneService
{
    public IEnumerable<Stack<char>> DoMoves(IEnumerable<Stack<char>> stacks, IEnumerable<Move> moves)
    {
        var enumeratedStacks = stacks.ToList();

        foreach (var move in moves) DoMoveOnList(enumeratedStacks, move);

        return enumeratedStacks;
    }

    private void DoMoveOnList(IList<Stack<char>> stacks, Move move)
    {
        var tempStack = new Stack<char>();

        for (var i = 0; i < move.Amount; i++) tempStack.Push(stacks[move.From - 1].Pop());

        while (tempStack.Count > 0) stacks[move.To - 1].Push(tempStack.Pop());
    }
}