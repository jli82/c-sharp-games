namespace MathGame;

public class Menu
{
    private GameEngine _gameEngine = new GameEngine();
    private bool _quitGame;
    
    public void ShowMenu(DateTime date, string name)
    {
        while (!_quitGame)
        {
            Console.Clear();
            Console.Write(new string('-', 100));
            Console.WriteLine(@$"
                    ····························································
                    :  __  __       _   _           ____                       :
                    : |  \/  | __ _| |_| |__       / ___| __ _ _ __ ___   ___  :
                    : | |\/| |/ _` | __| '_ \     | |  _ / _` | '_ ` _ \ / _ \ :
                    : | |  | | (_| | |_| | | |    | |_| | (_| | | | | | |  __/ :
                    : |_|  |_|\__,_|\__|_| |_|     \____|\__,_|_| |_| |_|\___| :
                    ····························································");
            Console.WriteLine(new string('-', 100));
            Console.WriteLine($"Date: {date}");
            Console.WriteLine($"Hello {name}, welcome to the Math Game!\n");
            
            Console.WriteLine("Which game would you like to play? Choose from the following options:");
            Console.WriteLine(
                "1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n5 - History\n6 - Quit Game " +
                "(Will Erase Game History)");
            Console.WriteLine(new string('-', 100));

            bool validInput;
            int gameSelected;
            do
            {
                validInput = int.TryParse(Console.ReadLine(), out gameSelected);
                if (!validInput || gameSelected < 1 || gameSelected > 6)
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            } while (!validInput || gameSelected < 1 || gameSelected > 6);

            switch (gameSelected)
            {
                case 1:
                    _gameEngine.AdditionGame(GetGameDifficulty());
                    break;
                case 2:
                    _gameEngine.SubtractionGame(GetGameDifficulty());
                    break;
                case 3:
                    _gameEngine.MultiplicationGame(GetGameDifficulty());
                    break;
                case 4:
                    _gameEngine.DivisionGame(GetGameDifficulty());
                    break;
                case 5:
                    // history option
                    if (Helpers.GameCount() == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(new string('-', 100));
                        Console.WriteLine("Game History is empty, please try again.");
                        Console.WriteLine("Press any key to go back to main menu...");
                        Console.WriteLine(new string('-', 100));
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
                    Console.WriteLine(new string('-', 100));
                    Console.WriteLine("You have quit the game, goodbye!");
                    Console.WriteLine(new string('-', 100));
                    _quitGame = true;
                    break;
            }
        }
    }

    private GameDifficulty GetGameDifficulty()
    {
        Console.Clear();
        Console.WriteLine(new string('-', 100));
        Console.WriteLine("Choose a difficulty:\n1 - Easy\n2 - Medium\n3 - Hard");
        Console.WriteLine(new string('-', 100));

        int difficultySelected;
        bool validInput;

        do
        {
            validInput = int.TryParse(Console.ReadLine(), out difficultySelected);
            if (!validInput || difficultySelected < 1 || difficultySelected > 3)
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        } while (!validInput || difficultySelected < 1 || difficultySelected > 3);

        if (difficultySelected == 1)
        {
            return GameDifficulty.Easy;
        }
        else if (difficultySelected == 2)
        {
            return GameDifficulty.Medium;
        }
        else
        {
            return GameDifficulty.Hard;
        }
    }
}