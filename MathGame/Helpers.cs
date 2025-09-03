namespace math_game;

public static class Helpers
{
    private static List<Game> _gameHistory = new List<Game>() ;

    public static int GameCount()
    {
        return _gameHistory.Count;
    }
    
    public static void AddGameResult(GameType gameType, int correctAnswers, int wrongAnswers)
    {
        _gameHistory.Add(new Game
        {
            GameType = gameType,
            CorrectAnswers = correctAnswers,
            WrongAnswers = wrongAnswers,
        });
    }
    public static void ShowLastGameResult(string gameType, int correctAnswers, int wrongAnswers)
    {
        Console.Clear();
        Console.WriteLine(gameType);
        Console.WriteLine($"Correct answers: {correctAnswers}\tWrong answers: {wrongAnswers}");
        Console.WriteLine("Thank you for playing!");
    }

    public static void ShowGameHistory()
    {
        Console.Clear();
        Console.WriteLine("Game History:");
        Console.WriteLine("-----------------------------------------------------------------------");
        foreach (Game game in _gameHistory)
        {
            Console.WriteLine(game);
        }
        Console.WriteLine("-----------------------------------------------------------------------");
        
        Console.WriteLine("Press any key to go back to main menu");
        Console.ReadKey();
    }
}