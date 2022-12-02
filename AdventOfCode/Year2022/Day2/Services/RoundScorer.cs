using AdventOfCode.Year2022.Day2.Interfaces;
using AdventOfCode.Year2022.Day2.Models;

namespace AdventOfCode.Year2022.Day2.Services;

public class RoundScorer : IRoundScorer
{
    private readonly IChoiceScorer _choiceScorer;
    private readonly IResultScorer _resultScorer;

    public RoundScorer(IChoiceScorer choiceScorer, IResultScorer resultScorer)
    {
        _choiceScorer = choiceScorer;
        _resultScorer = resultScorer;
    }

    public int GetScore(Choice choice, Result result)
    {
        return _choiceScorer.GetScore(choice) + _resultScorer.GetScore(result);
    }
}