using AdventOfCode.Year2022.Day3.Interfaces;
using AdventOfCode.Year2022.Day3.Services;

namespace AdventOfCode.Tests.Year2022.Day3.Services;

public class ItemPriorityServiceTests
{
    [Theory]
    [MemberData(nameof(GetPriorityTestData))]
    public void GetPriority_WithValidItemValue_ReturnsAssociatedPriority(char item, int expected)
    {
        //Arrange
        IItemPriorityService service = new ItemPriorityService();

        //Act
        var actual = service.GetPriority(item);

        //Assert
        actual.Should().Be(expected);
    }

    private static IEnumerable<object[]> GetPriorityTestData()
    {
        yield return new object[] {'a', 1};
        yield return new object[] {'b', 2};
        yield return new object[] {'c', 3};
        yield return new object[] {'d', 4};
        yield return new object[] {'e', 5};
        yield return new object[] {'f', 6};
        yield return new object[] {'g', 7};
        yield return new object[] {'h', 8};
        yield return new object[] {'i', 9};
        yield return new object[] {'j', 10};
        yield return new object[] {'k', 11};
        yield return new object[] {'l', 12};
        yield return new object[] {'m', 13};
        yield return new object[] {'n', 14};
        yield return new object[] {'o', 15};
        yield return new object[] {'p', 16};
        yield return new object[] {'q', 17};
        yield return new object[] {'r', 18};
        yield return new object[] {'s', 19};
        yield return new object[] {'t', 20};
        yield return new object[] {'u', 21};
        yield return new object[] {'v', 22};
        yield return new object[] {'w', 23};
        yield return new object[] {'x', 24};
        yield return new object[] {'y', 25};
        yield return new object[] {'z', 26};
        yield return new object[] {'A', 27};
        yield return new object[] {'B', 28};
        yield return new object[] {'C', 29};
        yield return new object[] {'D', 30};
        yield return new object[] {'E', 31};
        yield return new object[] {'F', 32};
        yield return new object[] {'G', 33};
        yield return new object[] {'H', 34};
        yield return new object[] {'I', 35};
        yield return new object[] {'J', 36};
        yield return new object[] {'K', 37};
        yield return new object[] {'L', 38};
        yield return new object[] {'M', 39};
        yield return new object[] {'N', 40};
        yield return new object[] {'O', 41};
        yield return new object[] {'P', 42};
        yield return new object[] {'Q', 43};
        yield return new object[] {'R', 44};
        yield return new object[] {'S', 45};
        yield return new object[] {'T', 46};
        yield return new object[] {'U', 47};
        yield return new object[] {'V', 48};
        yield return new object[] {'W', 49};
        yield return new object[] {'X', 50};
        yield return new object[] {'Y', 51};
        yield return new object[] {'Z', 52};
    }
}