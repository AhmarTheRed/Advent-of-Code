using AdventOfCode.Year2022.Day4.Interfaces;
using AdventOfCode.Year2022.Day4.Models;
using AdventOfCode.Year2022.Day4.Services;

namespace AdventOfCode.Tests.Year2022.Day4.Services;

public class OverlapCheckerTests
{
    [Theory]
    [InlineData(2, 8, 3, 7)]
    [InlineData(3, 7, 2, 8)]
    [InlineData(3, 9, 3, 9)]
    public void IsOverlap_WithAssignmentThatFullyContainsTheOther_ReturnsTrue(int assignment1Start, int assignment1End,
        int assignment2Start, int assignment2End)
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
        var actual = checker.IsOverlap(assignment1, assignment2);

        //Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void IsOverlap_WithAssignmentThatDoesNotFullyContainsTheOther_ReturnsFalse()
    {
        //Arrange
        var assignment1 = new Assignment
        {
            Start = 5,
            End = 7
        };
        var assignment2 = new Assignment
        {
            Start = 7,
            End = 9
        };
        IOverlapChecker checker = new OverlapChecker();

        //Act
        var actual = checker.IsOverlap(assignment1, assignment2);

        //Assert
        actual.Should().BeFalse();
    }
}