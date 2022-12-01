using AdventOfCode.Common.Interfaces;
using AdventOfCode.Common.Services;
using AdventOfCode.Year2022;

IInputFileService inputFileService = new InputFileService();

var day1 = new Day1(inputFileService);

Console.WriteLine(day1.GetMostCalories());
Console.WriteLine(day1.GetTop3MostCaloriesTotal());