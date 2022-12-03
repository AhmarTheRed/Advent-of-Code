using AdventOfCode.Year2022.Day3.Interfaces;

namespace AdventOfCode.Tests.Year2022.Day3;

public class Day3Tests
{
    private readonly string _testInput =
        $"vJrwpWtwJgWrhcsFMMfFFhFp{Environment.NewLine}jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL{Environment.NewLine}PmmdzqPrVvPwwTWBwg{Environment.NewLine}wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn{Environment.NewLine}ttgJtRGJQctTZtZT{Environment.NewLine}CrZsJsPPZsGzwwsLwLmpwMDw{Environment.NewLine}";

    private Mock<IInputFileService> MockInputFileService
    {
        get
        {
            var inputFileService = new Mock<IInputFileService>();
            inputFileService
                .Setup(s => s.GetInput(It.IsAny<string>()))
                .Returns(_testInput);
            return inputFileService;
        }
    }

    private Mock<IDuplicateFinderService> MockDuplicateFinderService
    {
        get
        {
            var mockDuplicateFinderService = new Mock<IDuplicateFinderService>();
            mockDuplicateFinderService
                .Setup(s => s.GetDuplicates(It.Is<IEnumerable<char>>(f => f.First() == 'v'),
                    It.Is<IEnumerable<char>>(l => l.First() == 'h')))
                .Returns(new List<char> {'p'});
            mockDuplicateFinderService
                .Setup(s => s.GetDuplicates(It.Is<IEnumerable<char>>(f => f.First() == 'j'),
                    It.Is<IEnumerable<char>>(l => l.First() == 'r')))
                .Returns(new List<char> {'L'});
            mockDuplicateFinderService
                .Setup(s => s.GetDuplicates(It.Is<IEnumerable<char>>(f => f.First() == 'P'),
                    It.Is<IEnumerable<char>>(l => l.First() == 'v')))
                .Returns(new List<char> {'P'});
            mockDuplicateFinderService
                .Setup(s => s.GetDuplicates(It.Is<IEnumerable<char>>(f => f.First() == 'w'),
                    It.Is<IEnumerable<char>>(l => l.First() == 'j')))
                .Returns(new List<char> {'v'});
            mockDuplicateFinderService
                .Setup(s => s.GetDuplicates(It.Is<IEnumerable<char>>(f => f.First() == 't'),
                    It.Is<IEnumerable<char>>(l => l.First() == 'Q')))
                .Returns(new List<char> {'t'});
            mockDuplicateFinderService
                .Setup(s => s.GetDuplicates(It.Is<IEnumerable<char>>(f => f.First() == 'C'),
                    It.Is<IEnumerable<char>>(l => l.First() == 'w')))
                .Returns(new List<char> {'s'});

            return mockDuplicateFinderService;
        }
    }

    private Mock<IItemPriorityService> MockItemPriorityService
    {
        get
        {
            var mockItemPriorityService = new Mock<IItemPriorityService>();
            mockItemPriorityService
                .Setup(s => s.GetPriority('p'))
                .Returns(16);
            mockItemPriorityService
                .Setup(s => s.GetPriority('L'))
                .Returns(38);
            mockItemPriorityService
                .Setup(s => s.GetPriority('P'))
                .Returns(42);
            mockItemPriorityService
                .Setup(s => s.GetPriority('v'))
                .Returns(22);
            mockItemPriorityService
                .Setup(s => s.GetPriority('t'))
                .Returns(20);
            mockItemPriorityService
                .Setup(s => s.GetPriority('s'))
                .Returns(19);

            return mockItemPriorityService;
        }
    }

    [Fact]
    public void GetCommonPriorityTotal_WithValidInput_ReturnsTotal()
    {
        //Arrange
        var day3 = new AdventOfCode.Year2022.Day3.Day3(MockInputFileService.Object, MockDuplicateFinderService.Object,
            MockItemPriorityService.Object);

        //Act
        var actual = day3.GetCommonPriorityTotal();

        //Assert
        actual.Should().Be(157);
    }
}