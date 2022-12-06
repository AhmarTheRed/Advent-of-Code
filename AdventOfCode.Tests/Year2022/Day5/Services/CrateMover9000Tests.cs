using AdventOfCode.Year2022.Day5.Interface;
using AdventOfCode.Year2022.Day5.Models;
using AdventOfCode.Year2022.Day5.Services;

namespace AdventOfCode.Tests.Year2022.Day5.Services;

public class CrateMover9000Tests
{
    [Fact]
    public void DoMoves_WithValidInputAndMoves_ReturnsListWithMovesApplied()
    {
        //Arrange
        var expected = new List<Stack<char>>
        {
            new(new[] {'C'}),
            new(new[] {'M'}),
            new(new[] {'P', 'D', 'N', 'Z'})
        };

        var input = new List<Stack<char>>
        {
            new(new[] {'Z', 'N'}),
            new(new[] {'M', 'C', 'D'}),
            new(new[] {'P'})
        };

        IEnumerable<Move> moves = new[]
        {
            new Move {Amount = 1, From = 2, To = 1},
            new Move {Amount = 3, From = 1, To = 3},
            new Move {Amount = 2, From = 2, To = 1},
            new Move {Amount = 1, From = 1, To = 2}
        };

        ICargoCraneService service = new CrateMover9000();

        //Act
        var actual = service.DoMoves(input, moves);

        //Assert
        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
}