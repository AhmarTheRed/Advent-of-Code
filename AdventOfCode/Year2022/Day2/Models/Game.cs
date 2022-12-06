namespace AdventOfCode.Year2022.Day2.Models;

public class Game
{
    public Choice YourChoice { get; init; }
    public Choice OpponentChoice { get; init; }
    public Result Result { get; init; }
}