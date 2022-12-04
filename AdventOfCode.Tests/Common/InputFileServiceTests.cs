namespace AdventOfCode.Tests.Common;

public class InputFileServiceTests
{
    [Fact]
    public void GetInputs_WithValidFilePathAndSplitterSpecified_ReturnsInput()
    {
        //Arrange
        var expected = new[]
        {
            $"1000{Environment.NewLine}2000{Environment.NewLine}3000",
            "4000",
            $"5000{Environment.NewLine}6000",
            $"7000{Environment.NewLine}8000{Environment.NewLine}9000",
            $"10000{Environment.NewLine}"
        };
        IInputFileService inputFileService = new InputFileService();

        //Act
        var actual = inputFileService.GetInputs("TestInput1", $"{Environment.NewLine}{Environment.NewLine}");

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void GetInputs_WithValidFilePathAndNoSplitterSpecified_ReturnsInput()
    {
        //Arrange
        var expected = new[]
        {
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000"
        };

        IInputFileService inputFileService = new InputFileService();

        //Act
        var actual = inputFileService.GetInputs("TestInput2");

        //Assert
        actual.Should().BeEquivalentTo(expected);
    }
}