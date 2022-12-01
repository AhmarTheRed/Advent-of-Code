using AdventOfCode.Common.Interfaces;

namespace AdventOfCode.Common.Services;

public class InputFileService : IInputFileService
{
    private const string BasePath = "Year2022/Inputs";
    public string GetInput(string name)
    {
        return File.ReadAllText($"{BasePath}/{name}");
    }
}