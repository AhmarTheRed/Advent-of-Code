using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Services;
using AdventOfCode.Year2022.Day1;
using AdventOfCode.Year2022.Day2;
using AdventOfCode.Year2022.Day2.Services;

IInputFileService inputFileService = new InputFileService();

var day1 = new Day1(inputFileService);

Console.WriteLine(day1.GetMostCalories());
Console.WriteLine(day1.GetTop3MostCaloriesTotal());

var day2 = new Day2(
    inputFileService,
    new RoundCreator(
        new RpsChoiceInputParser(),
        new RoundDecider(),
        new RoundScorer(
            new ChoiceScorer(),
            new ResultScorer())));

Console.WriteLine(day2.GetTotalScore());