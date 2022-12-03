using AdventOfCode.Year2022.Day3.Interfaces;

namespace AdventOfCode.Year2022.Day3.Services;

public class ItemPriorityService : IItemPriorityService
{
    public int GetPriority(char item)
    {
        var asciiValue = (int) item;

        return asciiValue <= 90 ? asciiValue - 38 : asciiValue - 96;
    }
}