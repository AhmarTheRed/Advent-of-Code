namespace AdventOfCode.Tests.Common;

public class InputFileServiceTests
{
    [Fact]
    public void GetInput_WithValidFilePath_ReturnsInput()
    {
        //Arrange
        var expected =
            $"1000{Environment.NewLine}2000{Environment.NewLine}3000{Environment.NewLine}{Environment.NewLine}4000{Environment.NewLine}{Environment.NewLine}5000{Environment.NewLine}6000{Environment.NewLine}{Environment.NewLine}7000{Environment.NewLine}8000{Environment.NewLine}9000{Environment.NewLine}{Environment.NewLine}10000{Environment.NewLine}";
        IInputFileService inputFileService = new InputFileService();

        //Act
        var actual = inputFileService.GetInput("TestInput1");

        //Assert
        actual.Should().Be(expected);
    }
}