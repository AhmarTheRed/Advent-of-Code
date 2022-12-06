using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Models;
using AdventOfCode.Year2022.Day5.Interface;

namespace AdventOfCode.Year2022.Day5;

public class Day5 : BaseDay
{
    private readonly ICargoCraneService _cargoCraneService;

    private readonly IMoveGenerator _moveGenerator;
    private IList<Stack<char>> _stacks = new List<Stack<char>>();

    public Day5(IInputFileService inputFileService, IMoveGenerator moveGenerator, ICargoCraneService cargoCraneService,
        params IEnumerable<char>[] startingStacks) : base("Day5-skinny.txt", inputFileService)
    {
        _moveGenerator = moveGenerator;
        _cargoCraneService = cargoCraneService;
        InitializeStacks(startingStacks);
    }

    private void InitializeStacks(IEnumerable<char>[] startingStacks)
    {
        foreach (var startingStack in startingStacks) _stacks.Add(new Stack<char>(startingStack.Reverse()));
    }

    public string GetTopItems()
    {
        var inputs = GetInputs();

        var moves = inputs.Select(_moveGenerator.GetMove);

        _stacks = _cargoCraneService.DoMoves(_stacks, moves).ToList();

        return _stacks.Aggregate(string.Empty, (current, stack) => current + stack.Peek());
    }
}