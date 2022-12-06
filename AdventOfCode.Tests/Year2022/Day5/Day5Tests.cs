using AdventOfCode.Year2022.Day5.Interface;
using AdventOfCode.Year2022.Day5.Models;

namespace AdventOfCode.Tests.Year2022.Day5;

public class Day5Tests : DayTestsBase
{
    private Mock<IMoveGenerator> MockMoveGenerator
    {
        get
        {
            var mockMoveGenerator = new Mock<IMoveGenerator>();
            mockMoveGenerator
                .Setup(g => g.GetMove("move 1 from 2 to 1"))
                .Returns(new Move {Amount = 1, From = 2, To = 1});
            mockMoveGenerator
                .Setup(g => g.GetMove("move 3 from 1 to 3"))
                .Returns(new Move {Amount = 3, From = 1, To = 3});
            mockMoveGenerator
                .Setup(g => g.GetMove("move 2 from 2 to 1"))
                .Returns(new Move {Amount = 2, From = 2, To = 1});
            mockMoveGenerator
                .Setup(g => g.GetMove("move 1 from 1 to 2"))
                .Returns(new Move {Amount = 1, From = 1, To = 2});

            return mockMoveGenerator;
        }
    }

    private Mock<ICargoCraneService> MockCargoCraneService
    {
        get
        {
            var mockCargoCraneService = new Mock<ICargoCraneService>();
            mockCargoCraneService
                .Setup(s => s.DoMoves(It.IsAny<IList<Stack<char>>>(), It.IsAny<IEnumerable<Move>>()))
                .Returns(new List<Stack<char>>
                {
                    new(new[] {'C'}),
                    new(new[] {'M'}),
                    new(new[] {'P', 'D', 'N', 'Z'})
                });

            return mockCargoCraneService;
        }
    }

    protected override IEnumerable<string> TestInputs => new[]
    {
        "move 1 from 2 to 1",
        "move 3 from 1 to 3",
        "move 2 from 2 to 1",
        "move 1 from 1 to 2"
    };

    [Fact]
    public void GetTopItems_ReturnsTopItemsInStacksAfterApplyingMoves()
    {
        //Arrange
        var day5 = new AdventOfCode.Year2022.Day5.Day5(
            MockInputFileService.Object,
            MockMoveGenerator.Object,
            MockCargoCraneService.Object,
            new[] {'N', 'Z'},
            new[] {'D', 'C', 'M'},
            new[] {'P'});

        //Act
        var actual = day5.GetTopItems();

        //Assert
        actual.Should().Be("CMZ");
    }
}