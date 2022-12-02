using AdventOfCode.Year2022.Day2.Interfaces;

namespace AdventOfCode.Year2022.Day2;

public class RoundScorer : IRoundScorer
{
    private readonly IChoiceScorer _choiceScorer;
    private readonly IResultScorer _resultScorer;

    public RoundScorer(IChoiceScorer choiceScorer, IResultScorer resultScorer)
    {
        _choiceScorer = choiceScorer;
        _resultScorer = resultScorer;
    }

    public int GetScore(Rps choice, Result result)
    {
        return _choiceScorer.GetScore(choice) + _resultScorer.GetScore(result);
    }
}