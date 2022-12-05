using AdventOfCode.Year2022.Day4.Interfaces;
using AdventOfCode.Year2022.Day4.Models;
using AdventOfCode.Year2022.Day4.Services;

namespace AdventOfCode.Tests.Year2022.Day4.Services;

public class OverlapCheckerTests
{
    [Theory]
    [InlineData(2, 8, 3, 7, OverlapType.Full)]
    [InlineData(3, 7, 2, 8, OverlapType.Full)]
    [InlineData(3, 9, 3, 9, OverlapType.Full)]
    [InlineData(5, 7, 7, 9, OverlapType.Partial)]
    [InlineData(7, 9, 5, 7, OverlapType.Partial)]
    [InlineData(2, 4, 6, 8, OverlapType.None)]
    [InlineData(2, 4, 5, 7, OverlapType.None)]
    [InlineData(6, 8, 2, 4, OverlapType.None)]
    [InlineData(5, 7, 2, 4, OverlapType.None)]
    public void CheckOverlap_WithAssignmentThatOverlap_ReturnsOverlapType(int assignment1Start, int assignment1End,
        int assignment2Start, int assignment2End, OverlapType overlapType)
    {
        //Arrange
        var assignment1 = new Assignment
        {
            Start = assignment1Start,
            End = assignment1End
        };
        var assignment2 = new Assignment
        {
            Start = assignment2Start,
            End = assignment2End
        };
        IOverlapChecker checker = new OverlapChecker();

        //Act
        var actual = checker.CheckOverlap(assignment1, assignment2);

        //Assert
        actual.Should().Be(overlapType);
    }
}