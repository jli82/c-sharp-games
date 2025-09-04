namespace MathGame;

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
    public static void ShowGameResult(string gameType, int correctAnswers, int wrongAnswers)
    {
        Console.Clear();
        Console.WriteLine(gameType);
        Console.WriteLine($"Correct answers: {correctAnswers}\tWrong answers: {wrongAnswers}");
        Console.WriteLine("Press any key to go back to main menu...");
        Console.ReadKey();
    }

    public static void ShowGameHistory()
    {
        Console.Clear();
        Console.WriteLine("Game History:");
        Console.WriteLine(new string('-', Console.WindowWidth/2));
        foreach (Game game in _gameHistory)
        {
            Console.WriteLine(game);
        }
        Console.WriteLine(new string('-', Console.WindowWidth/2));
        
        Console.WriteLine("Press any key to go back to main menu...");
        Console.ReadKey();
    }
}