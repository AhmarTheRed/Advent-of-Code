using AdventOfCode.Year2022.Day4.Interfaces;
using AdventOfCode.Year2022.Day4.Models;

namespace AdventOfCode.Tests.Year2022.Day4;

public class Day4Tests : DayPuzzleTestsBase
{
    protected override IEnumerable<string> TestInputs => new[]
    {
        "2-4,6-8",
        "2-3,4-5",
        "5-7,7-9",
        "2-8,3-7",
        "6-6,4-6",
        "2-6,4-8"
    };

    private static Mock<IAssignmentPairGenerator> MockAssignmentPairGenerator
    {
        get
        {
            var mockAssignmentPairGenerator = new Mock<IAssignmentPairGenerator>();
            mockAssignmentPairGenerator
                .Setup(g => g.GetAssignmentPair("2-4,6-8"))
                .Returns(new List<Assignment>
                {
                    GetAssignment(2, 4),
                    GetAssignment(6, 8)
                });
            mockAssignmentPairGenerator
                .Setup(g => g.GetAssignmentPair("2-3,4-5"))
                .Returns(new List<Assignment>
                {
                    GetAssignment(2, 3),
                    GetAssignment(4, 5)
                });
            mockAssignmentPairGenerator
                .Setup(g => g.GetAssignmentPair("5-7,7-9"))
                .Returns(new List<Assignment>
                {
                    GetAssignment(5, 7),
                    GetAssignment(7, 9)
                });
            mockAssignmentPairGenerator
                .Setup(g => g.GetAssignmentPair("2-8,3-7"))
                .Returns(new List<Assignment>
                {
                    GetAssignment(2, 8),
                    GetAssignment(3, 7)
                });
            mockAssignmentPairGenerator
                .Setup(g => g.GetAssignmentPair("6-6,4-6"))
                .Returns(new List<Assignment>
                {
                    GetAssignment(6, 6),
                    GetAssignment(4, 6)
                });
            mockAssignmentPairGenerator
                .Setup(g => g.GetAssignmentPair("2-6,4-8"))
                .Returns(new List<Assignment>
                {
                    GetAssignment(2, 6),
                    GetAssignment(4, 8)
                });
            return mockAssignmentPairGenerator;
        }
    }

    private static Mock<IOverlapChecker> MockOverlapChecker
    {
        get
        {
            var mockOverlapChecker = new Mock<IOverlapChecker>();
            mockOverlapChecker.SetReturnsDefault(OverlapType.None);
            mockOverlapChecker
                .Setup(c => c.CheckOverlap(
                    It.Is<Assignment>(a => a.Start == 2 && a.End == 8),
                    It.Is<Assignment>(a => a.Start == 3 && a.End == 7)))
                .Returns(OverlapType.Full);
            mockOverlapChecker
                .Setup(c => c.CheckOverlap(
                    It.Is<Assignment>(a => a.Start == 6 && a.End == 6),
                    It.Is<Assignment>(a => a.Start == 4 && a.End == 6)))
                .Returns(OverlapType.Full);
            mockOverlapChecker
                .Setup(c => c.CheckOverlap(
                    It.Is<Assignment>(a => a.Start == 5 && a.End == 7),
                    It.Is<Assignment>(a => a.Start == 7 && a.End == 9)))
                .Returns(OverlapType.Partial);
            mockOverlapChecker
                .Setup(c => c.CheckOverlap(
                    It.Is<Assignment>(a => a.Start == 2 && a.End == 6),
                    It.Is<Assignment>(a => a.Start == 4 && a.End == 8)))
                .Returns(OverlapType.Partial);
            return mockOverlapChecker;
        }
    }

    [Fact]
    public void GetFullOverlappingAssignmentPairsTotal_WithValidInput_ReturnsNumberOfFullyOverlappingPairs()
    {
        //Arrange
        var day4 = new AdventOfCode.Year2022.Day4.Day4(MockInputFileService.Object, MockAssignmentPairGenerator.Object,
            MockOverlapChecker.Object);

        //Act
        var actual = day4.GetFullOverlappingAssignmentPairsTotal();

        //Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void GetAllOverlappingAssignmentPairsTotal_WithValidInput_ReturnsNumberOfAllTypesOfOverlappingPairs()
    {
        //Arrange
        var day4 = new AdventOfCode.Year2022.Day4.Day4(MockInputFileService.Object, MockAssignmentPairGenerator.Object,
            MockOverlapChecker.Object);

        //Act
        var actual = day4.GetAllOverlappingAssignmentPairsTotal();

        //Assert
        actual.Should().Be(4);
    }

    private static Assignment GetAssignment(int start, int end)
    {
        return new Assignment
        {
            Start = start,
            End = end
        };
    }
}