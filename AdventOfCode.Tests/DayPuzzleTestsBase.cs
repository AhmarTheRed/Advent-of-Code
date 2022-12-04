namespace AdventOfCode.Tests;

public abstract class DayPuzzleTestsBase
{
    protected abstract IEnumerable<string> TestInputs { get; }

    protected Mock<IInputFileService> MockInputFileService
    {
        get
        {
            var inputFileService = new Mock<IInputFileService>();
            inputFileService
                .Setup(s => s.GetInputs(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(TestInputs);
            return inputFileService;
        }
    }
}