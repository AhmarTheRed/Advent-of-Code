using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Tests.Year2022.Day2;

public class Day2Tests : DayPuzzleTestsBase
{
    protected override IEnumerable<string> TestInputs => new[] {"A Y", "B X", "C Z"};

    [Fact]
    public void GetTotalScore_WithValidInputString_ReturnsTotalScore()
    {
        //Arrange
        var mockRoundCreator = new Mock<IRoundCreator>();
        mockRoundCreator
            .Setup(c => c.CreateRound("A Y"))
            .Returns(new Round
            {
                Score = 8
            });
        mockRoundCreator
            .Setup(c => c.CreateRound("B X"))
            .Returns(new Round
            {
                Score = 1
            });
        mockRoundCreator
            .Setup(c => c.CreateRound("C Z"))
            .Returns(new Round
            {
                Score = 6
            });

        var day2 = new AdventOfCode.Year2022.Day2.Day2(MockInputFileService.Object, mockRoundCreator.Object);

        //Act
        var actual = day2.GetTotalScore();

        //Assert
        actual.Should().Be(15);
    }
}