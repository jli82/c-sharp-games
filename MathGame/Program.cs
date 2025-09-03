using math_game;

DateTime date = DateTime.Now;
string name = GetName();

// Game start
Menu menu = new Menu();
menu.ShowMenu(date, name);


string GetName()
{
    Console.Write("Enter your name (Press enter to use default name \"Player\"): ");
    string? s = Console.ReadLine();
    if (s.Equals(""))
    {
        s = "Player";
    }

    return s;
}


