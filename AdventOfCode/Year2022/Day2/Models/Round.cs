namespace AdventOfCode.Year2022.Day2.Models;

public class Round
{
    public Choice YourChoice { get; set; }
    public Choice OpponentChoice { get; set; }
    public Result Result { get; set; }
    public int Score { get; set; }
}