using AdventOfCode.Year2022.Day8.Interfaces;

namespace AdventOfCode.Tests.Year2022.Day8;

public class Day8Tests : DayTestsBase
{
    protected override IEnumerable<string> TestInputs =>
        new[]
        {
            "30373",
            "25512",
            "65332",
            "33549",
            "35390"
        };

    [Fact]
    public void GetNumberOfVisibleTrees_ReturnsTotalTreesVisible()
    {
        //Arrange
        var mockForestGenerator = new Mock<IForestGenerator>();
        mockForestGenerator
            .Setup(g => g.GenerateForest(TestInputs))
            .Returns(new[]
            {
                new[] {3, 0, 3, 7, 3},
                new[] {2, 5, 5, 1, 2},
                new[] {6, 5, 3, 3, 2},
                new[] {3, 3, 5, 4, 9},
                new[] {3, 5, 3, 9, 0}
            });

        var day8 = new AdventOfCode.Year2022.Day8.Day8(MockInputFileService.Object, mockForestGenerator.Object);

        //Act
        var actual = day8.GetNumberOfVisibleTrees();

        //Assert
        actual.Should().Be(21);
    }

    [Fact]
    public void GetHighestScenicScore_ReturnsHighestPossibleScenicScore()
    {
        //Arrange
        var mockForestGenerator = new Mock<IForestGenerator>();
        mockForestGenerator
            .Setup(g => g.GenerateForest(TestInputs))
            .Returns(new[]
            {
                new[] {3, 0, 3, 7, 3},
                new[] {2, 5, 5, 1, 2},
                new[] {6, 5, 3, 3, 2},
                new[] {3, 3, 5, 4, 9},
                new[] {3, 5, 3, 9, 0}
            });

        var day8 = new AdventOfCode.Year2022.Day8.Day8(MockInputFileService.Object, mockForestGenerator.Object);

        //Act
        var actual = day8.GetHighestScenicScore();

        //Assert
        actual.Should().Be(8);
    }
}