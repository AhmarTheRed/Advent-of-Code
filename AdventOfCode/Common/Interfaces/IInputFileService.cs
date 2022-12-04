namespace AdventOfCode.Common.Interfaces;

public interface IInputFileService
{
    IEnumerable<string> GetInputs(string name, string? lineSplitter = null);
}