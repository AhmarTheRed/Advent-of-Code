namespace AdventOfCode.Tests.Common;

public class InputFileServiceTests
{
    [Fact]
    public void GetInput_WithValidFilePath_ReturnsInput()
    {
        //Arrange
        var expected = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000\n";
        IInputFileService inputFileService = new InputFileService();

        //Act
        var actual = inputFileService.GetInput("TestInput1");

        //Assert
        actual.Should().Be(expected);
    }
}