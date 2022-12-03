using AdventOfCode.Year2022.Day3.Interfaces;
using AdventOfCode.Year2022.Day3.Services;

namespace AdventOfCode.Tests.Year2022.Day3.Services;

public class DuplicateFinderServiceTests
{
    [Theory]
    [MemberData(nameof(GetDuplicateItemFinderTestData))]
    public void FindDuplicates_WithValidInputs_ReturnsDuplicates(IEnumerable<char> first, IEnumerable<char> second,
        IEnumerable<char> expected)
    {
        //Arrange
        IDuplicateFinderService duplicateFinderService = new DuplicateFinderService();

        //Act
        var actual = duplicateFinderService.GetDuplicates(first, second);

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }

    private static IEnumerable<object[]> GetDuplicateItemFinderTestData()
    {
        yield return new object[]
        {
            new[] {'v', 'J', 'r', 'w', 'p', 'W', 't', 'w', 'J', 'g', 'W', 'r'},
            new[] {'h', 'c', 's', 'F', 'M', 'M', 'f', 'F', 'F', 'h', 'F', 'p'},
            new[] {'p'}
        };
        yield return new object[]
        {
            new[] {'j', 'q', 'H', 'R', 'N', 'q', 'R', 'j', 'q', 'z', 'j', 'G', 'D', 'L', 'G', 'L'},
            new[] {'r', 's', 'F', 'M', 'f', 'F', 'Z', 'S', 'r', 'L', 'r', 'F', 'Z', 's', 'S', 'L'},
            new[] {'L'}
        };
        yield return new object[]
        {
            new[] {'P', 'm', 'm', 'd', 'z', 'q', 'P', 'r', 'V'},
            new[] {'v', 'P', 'w', 'w', 'T', 'W', 'B', 'w', 'g'},
            new[] {'P'}
        };
    }
}