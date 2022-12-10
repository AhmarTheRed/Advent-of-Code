using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Models;

namespace AdventOfCode.Year2022.Day10;

public class Day10 : BaseDay
{
    public Day10(IInputFileService inputFileService) : base("Day10.txt", inputFileService)
    {
    }

    public int GetSignalStrengthTotal()
    {
        var signalStrengths = GetSignalStrengths();

        var total = 0;
        for (var j = 19; j < signalStrengths.Count; j += 40) total += signalStrengths[j];

        return total;
    }

    public string GetCrtImage()
    {
        var image = "";
        var signalStrengths = GetSignalStrengths();

        for (var h = 0; h < 6; h++)
        {
            image += "#";
            for (var i = 1; i < 40; i++)
            {
                var location = i + h * 40;
                var x = signalStrengths[location] / (location + 1);

                if (i == x - 1 || i == x || i == x + 1)
                    image += "#";
                else
                    image += ".";
            }

            image += Environment.NewLine;
        }

        return image;
    }

    private IList<int> GetSignalStrengths()
    {
        var x = 1;
        IList<int> signalStrength = new List<int>();

        var inputs = GetInputs().ToList();

        foreach (var input in inputs)
            if (input == "noop")
            {
                signalStrength.Add(x * (signalStrength.Count + 1));
            }
            //signalStrength.Add(x);
            else if (input.StartsWith("addx"))
            {
                var instructionParts = input.Split(' ');

                var value = int.Parse(instructionParts[1]);

                signalStrength.Add((signalStrength.Count + 1) * x);
                signalStrength.Add((signalStrength.Count + 1) * x);
                /*signalStrength.Add(x);
                signalStrength.Add(x);*/
                x += value;
            }

        return signalStrength;
    }
}