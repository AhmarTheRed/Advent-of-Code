using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Services;
using AdventOfCode.Year2022.Day1;
using AdventOfCode.Year2022.Day2;
using AdventOfCode.Year2022.Day2.Services;

IInputFileService inputFileService = new InputFileService();

var day1 = new Day1(inputFileService);

Console.WriteLine(day1.GetMostCalories());
Console.WriteLine(day1.GetTop3MostCaloriesTotal());

var day2FirstHalf = new Day2(
    inputFileService,
    new RoundCreatorForFirstHalf(
        new ChoiceInputParser(),
        new ResultCalculator(new Rules()),
        new RoundScorer(
            new ChoiceScorer(),
            new ResultScorer())));

Console.WriteLine(day2FirstHalf.GetTotalScore());

var day2SecondHalf = new Day2(
    inputFileService,
    new RoundCreatorForSecondHalf(
        new ChoiceInputParser(),
        new ResultInputParser(),
        new ChoiceCalculator(
            new Rules()),
        new RoundScorer(
            new ChoiceScorer(),
            new ResultScorer())));

Console.WriteLine(day2SecondHalf.GetTotalScore());