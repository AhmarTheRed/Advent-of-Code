using AdventOfCode.Year2022.Day8.Services;

namespace AdventOfCode.Tests.Year2022.Day8.Services;

public class ForestGeneratorTests
{
    [Fact]
    public void GenerateForest_WithValidInputs_ReturnsForest()
    {
        //Arrange
        var expected = new[]
        {
            new[] {3, 0, 3, 7, 3},
            new[] {2, 5, 5, 1, 2},
            new[] {6, 5, 3, 3, 2},
            new[] {3, 3, 5, 4, 9},
            new[] {3, 5, 3, 9, 0}
        };

        var inputs = new[]
        {
            "30373",
            "25512",
            "65332",
            "33549",
            "35390"
        };

        var generator = new ForestGenerator();

        //Act
        var actual = generator.GenerateForest(inputs);

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }
}