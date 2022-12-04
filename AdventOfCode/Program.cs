using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Services;
using AdventOfCode.Year2022.Day1;
using AdventOfCode.Year2022.Day2;
using AdventOfCode.Year2022.Day2.Services;
using AdventOfCode.Year2022.Day3;
using AdventOfCode.Year2022.Day3.Services;
using AdventOfCode.Year2022.Day4;
using AdventOfCode.Year2022.Day4.Services;

IInputFileService inputFileService = new InputFileService();

Console.WriteLine($"# Advent of Code 2022 - by Ahmar Tareen {Environment.NewLine}");
Console.WriteLine($"## Answers {Environment.NewLine}");

var day1 = new Day1(inputFileService);

Console.WriteLine($"Day 1 1/2: {day1.GetMostCalories()}");
Console.WriteLine($"Day 1 2/2: {day1.GetTop3MostCaloriesTotal()}");

var day2FirstHalf = new Day2(
    inputFileService,
    new RoundCreatorForFirstHalf(
        new ChoiceInputParser(),
        new ResultCalculator(new Rules()),
        new RoundScorer(
            new ChoiceScorer(),
            new ResultScorer())));

Console.WriteLine($"Day 2 1/2: {day2FirstHalf.GetTotalScore()}");

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

Console.WriteLine($"Day 2 2/2: {day2SecondHalf.GetTotalScore()}");

var day3 = new Day3(new InputFileService(), new DuplicateFinderService(), new ItemPriorityService());

Console.WriteLine($"Day 3 1/2: {day3.GetBucketCommonPriorityTotal()}");
Console.WriteLine($"Day 3 2/2: {day3.GetGroupCommonPriorityTotal()}");

var day4 = new Day4(new InputFileService(), new AssignmentPairGenerator(), new OverlapChecker());

Console.WriteLine($"Day 4 1/2: {day4.GetTotalOverlappingAssignmentPairs()}");