namespace MathGame;

public class GameEngine
{
    private Random _random = new Random();
    
    public void AdditionGame()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Addition Game! Press q to quit.");
        Console.WriteLine(new string('-', 100));
        
        int questionNumber = 1;
        int correctAnswers = 0;
        int wrongAnswers = 0;

        while (true)
        {
            int a = _random.Next(20);
            int b = _random.Next(20);
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
                    Helpers.AddGameResult(GameType.Addition, correctAnswers, wrongAnswers);
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
        
        Helpers.AddGameResult(GameType.Addition, correctAnswers, wrongAnswers);
        Helpers.ShowLastGameResult();
    }

    public void SubtractionGame() 
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Subtraction Game! Press q to quit.");
        Console.WriteLine(new string('-', 100));
        
        int questionNumber = 1;
        int correctAnswers = 0;
        int wrongAnswers = 0;

        while (true)
        {
            int a = _random.Next(20);
            int b = _random.Next(20);
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
        
        Helpers.AddGameResult(GameType.Subtraction, correctAnswers, wrongAnswers);
        Helpers.ShowLastGameResult();
    }

    public void MultiplicationGame() 
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Multiplication Game! Press q to quit.");
        Console.WriteLine(new string('-', 100));
        
        int questionNumber = 1;
        int correctAnswers = 0;
        int wrongAnswers = 0;

        while (true)
        {
            int a = _random.Next(10);
            int b = _random.Next(10);
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
        
        Helpers.AddGameResult(GameType.Multiplication, correctAnswers, wrongAnswers);
        Helpers.ShowLastGameResult();;
    }

    public void DivisionGame() 
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
                a = _random.Next(100);
                b = _random.Next(1, 10);
            } while (a % b != 0);
            
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
        
        Helpers.AddGameResult(GameType.Division, correctAnswers, wrongAnswers);
        Helpers.ShowLastGameResult();;
    }
}