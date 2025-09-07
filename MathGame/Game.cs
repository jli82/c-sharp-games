namespace MathGame;

public class Game
{
    internal GameType GameType;
    internal int CorrectAnswers;
    internal int WrongAnswers;
    internal int TotalQuestions;

    public Game(GameType gameType, int correctAnswers, int wrongAnswers,  int totalQuestions)
    {
        GameType = gameType;
        CorrectAnswers = correctAnswers;
        WrongAnswers = wrongAnswers;
        TotalQuestions = totalQuestions;
    }

    public override string ToString()
    {
        return $"{GameType, -20}-{CorrectAnswers, 7} correct \t {WrongAnswers} wrong \t Correct Percentage: {((float)CorrectAnswers / TotalQuestions):P2}";
    }
}