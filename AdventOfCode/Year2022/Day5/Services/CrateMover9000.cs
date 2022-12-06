using AdventOfCode.Year2022.Day5.Interface;
using AdventOfCode.Year2022.Day5.Models;

namespace AdventOfCode.Year2022.Day5.Services;

public class CrateMover9000 : ICargoCraneService
{
    public IEnumerable<Stack<char>> DoMoves(IEnumerable<Stack<char>> stacks, IEnumerable<Move> moves)
    {
        var enumeratedStacks = stacks.ToList();

        foreach (var move in moves) DoMoveOnList(enumeratedStacks, move);

        return enumeratedStacks;
    }

    private void DoMoveOnList(IList<Stack<char>> stacks, Move move)
    {
        for (var i = 0; i < move.Amount; i++)
            MoveItem(stacks, move.From, move.To);
    }

    private void MoveItem(IList<Stack<char>> stacks, int moveFrom, int moveTo)
    {
        var item = stacks[moveFrom - 1].Pop();
        stacks[moveTo - 1].Push(item);
    }
}