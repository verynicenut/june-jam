public static class Program
{
    public static void Main()
    {
        string playerName = GetPlayerName();
        Character player = CreatePlayer(playerName);
        Enemy enemy = new Enemy("Goblin", 100);
        Battle battle = new Battle(player, enemy);
        Console.WriteLine($"\nWelcome, {player.Name} the {player.GetType().Name}!");
        Console.WriteLine("\nPress ENTER to begin...");
        Console.ReadLine();
        battle.Start();
        Console.WriteLine("\nPress ENTER to exit...");
        Console.ReadLine();
    }
    private static string GetPlayerName()
    {
        while (true)
        {
            Console.Write("Enter your name: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input.Trim();
            }
            Console.WriteLine("Name cannot be empty.");
        }
    }
    private static Character CreatePlayer(string name)
    {
        while (true)
        {
            Console.WriteLine("\nChoose your class:");
            Console.WriteLine("1. Knight");
            Console.WriteLine("2. Dragon");
            Console.WriteLine("3. Robot");
            Console.Write("Choice: ");
            string? input = Console.ReadLine();
            if (input == "1")
            {
                return new Knight(name);
            }
            else if (input == "2")
            {
                return new Dragon(name);
            }
            else if (input == "3")
            {
                return new Robot(name);
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
    }
}