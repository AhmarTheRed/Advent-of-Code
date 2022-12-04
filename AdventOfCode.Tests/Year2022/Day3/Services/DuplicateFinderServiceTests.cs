using AdventOfCode.Year2022.Day3.Interfaces;
using AdventOfCode.Year2022.Day3.Services;

namespace AdventOfCode.Tests.Year2022.Day3.Services;

public class DuplicateFinderServiceTests
{
    [Theory]
    [MemberData(nameof(GetTwoDuplicateItemFinderTestData))]
    public void GetCommonItems_WithTwoValidInputs_ReturnsDuplicates(IEnumerable<char> first, IEnumerable<char> second,
        IEnumerable<char> expected)
    {
        //Arrange
        IDuplicateFinderService duplicateFinderService = new DuplicateFinderService();

        //Act
        var actual = duplicateFinderService.GetCommonItems(first, second);

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Theory]
    [MemberData(nameof(GetThreeDuplicateItemFinderTestData))]
    public void GetCommonItems_WithThreeValidInputs_ReturnsDuplicates(IEnumerable<char> first, IEnumerable<char> second,
        IEnumerable<char> third, IEnumerable<char> expected)
    {
        //Arrange
        IDuplicateFinderService duplicateFinderService = new DuplicateFinderService();

        //Act
        var actual = duplicateFinderService.GetCommonItems(first, second, third);

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }

    private static IEnumerable<object[]> GetTwoDuplicateItemFinderTestData()
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

    private static IEnumerable<object[]> GetThreeDuplicateItemFinderTestData()
    {
        yield return new object[]
        {
            new[]
            {
                'v', 'J', 'r', 'w', 'p', 'W', 't', 'w', 'J', 'g', 'W', 'r', 'h', 'c', 's', 'F', 'M', 'M', 'f', 'F', 'F',
                'h', 'F', 'p'
            },
            new[]
            {
                'j', 'q', 'H', 'R', 'N', 'q', 'R', 'j', 'q', 'z', 'j', 'G', 'D', 'L', 'G', 'L', 'r', 's', 'F', 'M', 'f',
                'F', 'Z', 'S', 'r', 'L', 'r', 'F', 'Z', 's', 'S', 'L'
            },
            new[] {'P', 'm', 'm', 'd', 'z', 'q', 'P', 'r', 'V', 'v', 'P', 'w', 'w', 'T', 'W', 'B', 'w', 'g'},
            new[] {'r'}
        };
        yield return new object[]
        {
            new[]
            {
                'w', 'M', 'q', 'v', 'L', 'M', 'Z', 'H', 'h', 'H', 'M', 'v', 'w', 'L', 'H', 'j', 'b', 'v', 'c', 'j', 'n',
                'n', 'S', 'B', 'n', 'v', 'T', 'Q', 'F', 'n'
            },
            new[] {'t', 't', 'g', 'J', 't', 'R', 'G', 'J', 'Q', 'c', 't', 'T', 'Z', 't', 'Z', 'T'},
            new[]
            {
                'C', 'r', 'Z', 's', 'J', 's', 'P', 'P', 'Z', 's', 'G', 'z', 'w', 'w', 's', 'L', 'w', 'L', 'm', 'p', 'w',
                'M', 'D', 'w'
            },
            new[] {'Z'}
        };
    }
}