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
            Console.Write(new string('-', Console.WindowWidth/2));
            Console.WriteLine(@$"
                   ····························································
                   :  __  __       _   _           ____                       :
                   : |  \/  | __ _| |_| |__       / ___| __ _ _ __ ___   ___  :
                   : | |\/| |/ _` | __| '_ \     | |  _ / _` | '_ ` _ \ / _ \ :
                   : | |  | | (_| | |_| | | |    | |_| | (_| | | | | | |  __/ :
                   : |_|  |_|\__,_|\__|_| |_|     \____|\__,_|_| |_| |_|\___| :
                   ····························································");
            Console.WriteLine(new string('-', Console.WindowWidth/2));
            Console.WriteLine($"Date: {date}");
            Console.WriteLine($"Hello {name}, welcome to the Math Game!\n");
            
            Console.WriteLine("Which game would you like to play? Choose from the following options:");
            Console.WriteLine(
                "1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n5 - History\n6 - Quit Game " +
                "(Will Erase Game History)");
            Console.WriteLine(new string('-', Console.WindowWidth/2));

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
                        Console.WriteLine(new string('-', Console.WindowWidth/2));
                        Console.WriteLine("Game History is empty, please try again.");
                        Console.WriteLine("Press any key to go back to main menu...");
                        Console.WriteLine(new string('-', Console.WindowWidth/2));
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
                    Console.WriteLine(new string('-', Console.WindowWidth/2));
                    Console.WriteLine("You have quit the game, goodbye!");
                    Console.WriteLine(new string('-', Console.WindowWidth/2));
                    _quitGame = true;
                    break;
            }
        }
    }
}