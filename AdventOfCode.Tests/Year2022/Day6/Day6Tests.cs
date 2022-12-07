namespace AdventOfCode.Tests.Year2022.Day6;

public class Day6Tests
{
    [Theory]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 4, 5)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 4, 6)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 4, 10)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 4, 11)]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 14, 19)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 14, 23)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 14, 23)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 14, 29)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 14, 26)]
    public void GetFirstMarkerStartIndex_WithValidInputAndMarkerSize_ReturnsFirstIndexAfterMarker(string input,
        int markerSize, int expected)
    {
        //Arrange
        var mockInputFileService = new Mock<IInputFileService>();
        mockInputFileService
            .Setup(s => s.GetInputs(It.IsAny<string>(), null))
            .Returns(new[] {input});

        var day6 = new AdventOfCode.Year2022.Day6.Day6(mockInputFileService.Object, markerSize);

        //Act
        var actual = day6.GetFirstMarkerStartIndex();

        //Assert
        actual.Should().Be(expected);
    }
}