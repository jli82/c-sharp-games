namespace MathGame;

public class Game
{
    public GameType GameType  { get; init; }
    public int CorrectAnswers { get; init; }
    public int WrongAnswers { get; init; }

    public override string ToString()
    {
        return $"{GameType, -20}-{CorrectAnswers, 7} correct\t{WrongAnswers} wrong";
    }
}