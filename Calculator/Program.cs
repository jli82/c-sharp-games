using System.Text.RegularExpressions;

namespace Calculator;

class Program
{
    static void Main()
    {
        bool endApp = false;
        
        // Display title of app.
        Console.WriteLine(new string('-', 100));
        Console.WriteLine("Console Calculator in C#");
        Console.WriteLine(new string('-', 100));
        Console.WriteLine();

        CalculatorLibrary.Calculator calculator = new CalculatorLibrary.Calculator();
        
        while (!endApp)
        {
            // Ask for 1st number.
            Console.Write("Type a number, and then press Enter: ");
            string? numberInput1 = Console.ReadLine();

            // Value validation for 1st number
            double cleanedNumber1 = 0;
            while (!double.TryParse(numberInput1, out cleanedNumber1))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numberInput1 = Console.ReadLine();
            }

            // Ask for 2nd number.
            Console.Write("Type another number, and then press Enter: ");
            string? numberInput2 = Console.ReadLine();

            // Value validation for 2nd number
            double cleanedNumber2 = 0;
            while (!double.TryParse(numberInput2, out cleanedNumber2))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numberInput2 = Console.ReadLine();
            }

            // Ask for operator.
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("a - Add");
            Console.WriteLine("s - Subtract");
            Console.WriteLine("m - Multiply");
            Console.WriteLine("d - Divide");
            Console.WriteLine(new string('-', 100));
            Console.Write("Option: ");

            string? userOperator = Console.ReadLine();

            // Validate userOperator is not null, and is one of the four operaators (a, s, m, d)
            while (userOperator == null || ! Regex.IsMatch(userOperator, "[a|s|m|d]"))
            {
                Console.WriteLine("Error: invalid option. Please choose an operator from the list.");
                Console.Write("Option: ");
                userOperator = Console.ReadLine();
            }
            
            Console.WriteLine();

            // Calculate and print result
            double result = calculator.DoOperation(cleanedNumber1,cleanedNumber2, userOperator);
            if (double.IsNaN(result))
            {
                Console.WriteLine("This operation will result in a mathematical error. Please restart and try again.");
            }
            else Console.WriteLine($"Result = {result}");
            
            Console.WriteLine(new string('-', 100));

            // Wait for the user to respond before closing.
            Console.Write("Press 'q' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "q")
            {
                endApp = true;
            }

            Console.Clear();
        }
        
        calculator.Finish();
    }
}
