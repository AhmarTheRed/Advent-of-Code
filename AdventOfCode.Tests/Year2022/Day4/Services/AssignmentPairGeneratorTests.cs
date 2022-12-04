using AdventOfCode.Year2022.Day4.Interfaces;
using AdventOfCode.Year2022.Day4.Models;
using AdventOfCode.Year2022.Day4.Services;

namespace AdventOfCode.Tests.Year2022.Day4.Services;

public class AssignmentPairGeneratorTests
{
    [Fact]
    public void GetAssignmentPair_WithValidInput_ReturnsAssignmentPair()
    {
        //Arrange
        var expected = new List<Assignment>
        {
            new()
            {
                Start = 2,
                End = 8
            },
            new()
            {
                Start = 3,
                End = 7
            }
        };
        IAssignmentPairGenerator generator = new AssignmentPairGenerator();

        //Act
        var actual = generator.GetAssignmentPair("2-8,3-7");

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }
}