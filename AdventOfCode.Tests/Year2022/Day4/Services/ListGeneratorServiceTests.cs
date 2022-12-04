using AdventOfCode.Year2022.Day4.Interfaces;
using AdventOfCode.Year2022.Day4.Services;

namespace AdventOfCode.Tests.Year2022.Day4.Services;

public class ListGeneratorServiceTests
{
    [Theory]
    [MemberData(nameof(GetListGeneratorTestData))]
    public void GenerateList_WithValidStartAndEndParameters_ReturnsList(int start, int end, IEnumerable<int> expected)
    {
        //Arrange
        IListGenerator generator = new ListGenerator();

        //Act
        var actual = generator.GetList(start, end);

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }

    private static IEnumerable<object[]> GetListGeneratorTestData()
    {
        yield return new object[]
        {
            6,
            6,
            new[] {6}
        };
        yield return new object[]
        {
            2,
            3,
            new[] {2, 3}
        };
        yield return new object[]
        {
            6,
            8,
            new[] {6, 7, 8}
        };
        yield return new object[]
        {
            2,
            8,
            new[] {2, 3, 4, 5, 6, 7, 8}
        };
    }
}