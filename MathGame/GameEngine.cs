namespace MathGame;

public class GameEngine
{
    private Random _random = new Random();
    
    public void AdditionGame(GameDifficulty difficulty)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the Addition Game (Difficulty: {difficulty})! Press q to quit.");
        Console.WriteLine(new string('-', 100));
        
        int questionNumber = 1;
        int correctAnswers = 0;
        int wrongAnswers = 0;

        while (true)
        {
            int a = _random.Next(-50, 50) * (int)difficulty;
            int b = _random.Next(-50, 50)  * (int)difficulty;
            Console.WriteLine($"Question #{questionNumber}: {a} + {b}");
            Console.Write("Enter your answer (q to quit): ");
            string? userAnswer = Console.ReadLine();
            
            if (userAnswer?.ToLower().Trim() == "q")
            {
                break;
            }
            
            while (string.IsNullOrEmpty(userAnswer) || !int.TryParse(userAnswer, out _))
            {
                Console.WriteLine("Invalid answer. Please try again.");
                Console.WriteLine($"Question #{questionNumber}: {a} + {b}");
                Console.Write("Enter your answer (q to quit): ");
                userAnswer = Console.ReadLine();
                
                if (userAnswer?.ToLower().Trim() == "q")
                {
                    Helpers.AddGameResult(GameType.Addition, difficulty, correctAnswers, wrongAnswers);
                    Helpers.ShowLastGameResult();
                    return;
                }
            }
            
            if (Convert.ToInt32(userAnswer) == (a + b))
            {
                Console.WriteLine("Correct!");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine("Wrong!");
                wrongAnswers++;
            }
                
            questionNumber++;
            Console.WriteLine(new string('-', 100));
        }
        
        Helpers.AddGameResult(GameType.Addition, difficulty, correctAnswers, wrongAnswers);
        Helpers.ShowLastGameResult();
    }

    public void SubtractionGame(GameDifficulty difficulty) 
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Subtraction Game! Press q to quit.");
        Console.WriteLine(new string('-', 100));
        
        int questionNumber = 1;
        int correctAnswers = 0;
        int wrongAnswers = 0;

        while (true)
        {
            int a = _random.Next(-50, 50) * (int)difficulty;
            int b = _random.Next(-50, 50) * (int)difficulty;
            Console.WriteLine($"Question #{questionNumber}: {a} - {b}");
            Console.Write("Enter your answer (q to quit): ");
            string? userAnswer = Console.ReadLine();

            if (userAnswer?.ToLower().Trim() == "q")
            {
                break;
            }
            
            while (string.IsNullOrEmpty(userAnswer) || !int.TryParse(userAnswer, out _))
            {
                Console.WriteLine("Invalid answer. Please try again.");
                Console.WriteLine($"Question #{questionNumber}: {a} - {b}");
                Console.Write("Enter your answer (q to quit): ");
                userAnswer = Console.ReadLine();
                
                if (userAnswer?.ToLower().Trim() == "q")
                {
                    Helpers.AddGameResult(GameType.Subtraction, difficulty, correctAnswers, wrongAnswers);
                    Helpers.ShowLastGameResult();
                    return;
                }
            }
            
            if (Convert.ToInt32(userAnswer) == (a - b))
            {
                Console.WriteLine("Correct!");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine("Wrong!");
                wrongAnswers++;
            }
                
            questionNumber++;
            Console.WriteLine(new string('-', 100));
        }
        
        Helpers.AddGameResult(GameType.Subtraction, difficulty, correctAnswers, wrongAnswers);
        Helpers.ShowLastGameResult();
    }

    public void MultiplicationGame(GameDifficulty difficulty) 
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Multiplication Game! Press q to quit.");
        Console.WriteLine(new string('-', 100));
        
        int questionNumber = 1;
        int correctAnswers = 0;
        int wrongAnswers = 0;

        while (true)
        {
            int a = _random.Next(-81, 81) * (int)difficulty;
            int b = _random.Next(-9, 9) * (int)difficulty;
            Console.WriteLine($"Question #{questionNumber}: {a} x {b}");
            Console.Write("Enter your answer (q to quit): ");
            string? userAnswer = Console.ReadLine();

            if (userAnswer?.ToLower().Trim() == "q")
            {
                break;
            }
            
            while (string.IsNullOrEmpty(userAnswer) || !int.TryParse(userAnswer, out _))
            {
                Console.WriteLine("Invalid answer. Please try again.");
                Console.WriteLine($"Question #{questionNumber}: {a} x {b}");
                Console.Write("Enter your answer (q to quit): ");
                userAnswer = Console.ReadLine();
                
                if (userAnswer?.ToLower().Trim() == "q")
                {
                    Helpers.AddGameResult(GameType.Multiplication, difficulty, correctAnswers, wrongAnswers);
                    Helpers.ShowLastGameResult();
                    return;
                }
            }
            
            if (Convert.ToInt32(userAnswer) == (a * b))
            {
                Console.WriteLine("Correct!");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine("Wrong!");
                wrongAnswers++;
            }
                
            questionNumber++;
            Console.WriteLine(new string('-', 100));
        }
        
        Helpers.AddGameResult(GameType.Multiplication, difficulty, correctAnswers, wrongAnswers);
        Helpers.ShowLastGameResult();;
    }

    public void DivisionGame(GameDifficulty difficulty) 
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Division Game! Press q to quit.");
        Console.WriteLine(new string('-', 100));
        
        int questionNumber = 1;
        int correctAnswers = 0;
        int wrongAnswers = 0;

        while (true)
        {
            int a, b;
            do
            {
                a = _random.Next(-81, 81) * (int)difficulty;
                b = _random.Next(-9, 9) * (int)difficulty;
            } while (b == 0 || a % b != 0);
            
            Console.WriteLine($"Question #{questionNumber}: {a} / {b}");
            Console.Write("Enter your answer (q to quit): ");
            string? userAnswer = Console.ReadLine();

            if (userAnswer?.ToLower().Trim() == "q")
            {
                break;
            }
            
            while (string.IsNullOrEmpty(userAnswer) || !int.TryParse(userAnswer, out _))
            {
                Console.WriteLine("Invalid answer. Please try again.");
                Console.WriteLine($"Question #{questionNumber}: {a} / {b}");
                Console.Write("Enter your answer (q to quit): ");
                userAnswer = Console.ReadLine();
                
                if (userAnswer?.ToLower().Trim() == "q")
                {
                    Helpers.AddGameResult(GameType.Division, difficulty, correctAnswers, wrongAnswers);
                    Helpers.ShowLastGameResult();
                    return;
                }
            }
            
            if (Convert.ToInt32(userAnswer) == (a / b))
            {
                Console.WriteLine("Correct!");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine("Wrong!");
                wrongAnswers++;
            }
            
            questionNumber++;
            Console.WriteLine(new string('-', 100));
        }
        
        Helpers.AddGameResult(GameType.Division, difficulty, correctAnswers, wrongAnswers);
        Helpers.ShowLastGameResult();;
    }
}