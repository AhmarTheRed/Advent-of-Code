using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Services;
using AdventOfCode.Year2022.Day1;
using AdventOfCode.Year2022.Day2;
using AdventOfCode.Year2022.Day2.Services;
using AdventOfCode.Year2022.Day3;
using AdventOfCode.Year2022.Day3.Services;
using AdventOfCode.Year2022.Day4;
using AdventOfCode.Year2022.Day4.Services;
using AdventOfCode.Year2022.Day5;
using AdventOfCode.Year2022.Day5.Services;
using AdventOfCode.Year2022.Day6;
using AdventOfCode.Year2022.Day7;
using AdventOfCode.Year2022.Day7.Services;

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

Console.WriteLine($"Day 4 1/2: {day4.GetFullOverlappingAssignmentPairsTotal()}");
Console.WriteLine($"Day 4 2/2: {day4.GetAllOverlappingAssignmentPairsTotal()}");

var day5FirstHalf = new Day5(new InputFileService(), new MoveGenerator(), new CrateMover9000(),
    new[] {'H', 'L', 'R', 'F', 'B', 'C', 'J', 'M'},
    new[] {'D', 'C', 'Z'},
    new[] {'W', 'G', 'N', 'C', 'F', 'J', 'H'},
    new[] {'B', 'S', 'T', 'M', 'D', 'J', 'P'},
    new[] {'J', 'R', 'D', 'C', 'N'},
    new[] {'Z', 'G', 'J', 'P', 'Q', 'D', 'L', 'W'},
    new[] {'H', 'R', 'F', 'T', 'Z', 'P'},
    new[] {'G', 'M', 'V', 'L'},
    new[] {'J', 'R', 'Q', 'F', 'P', 'G', 'B', 'C'});

Console.WriteLine($"Day 5 1/2: {day5FirstHalf.GetTopItems()}");

var day5SecondHalf = new Day5(new InputFileService(), new MoveGenerator(), new CrateMover9001(),
    new[] {'H', 'L', 'R', 'F', 'B', 'C', 'J', 'M'},
    new[] {'D', 'C', 'Z'},
    new[] {'W', 'G', 'N', 'C', 'F', 'J', 'H'},
    new[] {'B', 'S', 'T', 'M', 'D', 'J', 'P'},
    new[] {'J', 'R', 'D', 'C', 'N'},
    new[] {'Z', 'G', 'J', 'P', 'Q', 'D', 'L', 'W'},
    new[] {'H', 'R', 'F', 'T', 'Z', 'P'},
    new[] {'G', 'M', 'V', 'L'},
    new[] {'J', 'R', 'Q', 'F', 'P', 'G', 'B', 'C'});

Console.WriteLine($"Day 5 2/2: {day5SecondHalf.GetTopItems()}");

var day6FirstHalf = new Day6(new InputFileService(), 4);

Console.WriteLine($"Day 6 1/2: {day6FirstHalf.GetFirstMarkerStartIndex()}");

var day6SecondHalf = new Day6(new InputFileService(), 14);

Console.WriteLine($"Day 6 2/2: {day6SecondHalf.GetFirstMarkerStartIndex()}");

var day7FirstHalf = new Day7(new InputFileService(),
    new ChangeDirectoryParser(new ListDirectoryParser(new DirectoryItemParser(new FileItemParser(null)))));

Console.WriteLine($"Day 7 1/2: {day7FirstHalf.GetSumOf100KAndLessDirectories()}");
Console.WriteLine($"Day 7 2/2: {day7FirstHalf.GetDirectoryToDelete(30000000)}");