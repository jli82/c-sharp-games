namespace math_game;

public class Menu
{
    private GameEngine _gameEngine = new GameEngine();
    private bool _quitGame;
    
    public void ShowMenu(DateTime date, string name)
    {
        while (!_quitGame)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"Date: {date}");
            Console.WriteLine($"Hello {name}, welcome to the Math Game!");
            Console.WriteLine("Which game would you like to play? Choose from the following options:");
            Console.WriteLine(
                "1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n5 - History\n6 - Quit Game " +
                "(Will Erase Game History)");
            Console.WriteLine("-----------------------------------------------------------------------");

            bool validInput;
            int gameSelected;
            do
            {
                validInput = int.TryParse(Console.ReadLine(), out gameSelected);
                if (!validInput)
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            } while (!validInput);

            switch (gameSelected)
            {
                case 1:
                    _gameEngine.AdditionGame();
                    break;
                case 2:
                    _gameEngine.SubtractionGame();
                    break;
                case 3:
                    _gameEngine.MultiplicationGame();
                    break;
                case 4:
                    _gameEngine.DivisionGame();
                    break;
                case 5:
                    // history option
                    if (Helpers.GameCount() == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine("Game History is empty, please try again.");
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Helpers.ShowGameHistory();
                    }

                    break;
                case 6:
                    // quit option
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------------------");
                    Console.WriteLine("You have quit the game, goodbye!");
                    Console.WriteLine("-----------------------------------------------------------------------");
                    _quitGame = true;
                    break;
                default:
                    Console.WriteLine("You did not enter a valid option, please try again.");
                    break;
            }
        }
    }
}