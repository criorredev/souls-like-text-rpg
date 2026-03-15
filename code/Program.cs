namespace souls_like_rpg;

class Program
{
    static void Main()
    {
        Goblin goblin = new();
        Player player = new();

        Random moveSelector = new();

        while (player.health > 0 && goblin.health > 0)
        {
            int num = moveSelector.Next(2);
            string goblinMove = goblin.moves[num];

            Console.WriteLine();

            Console.WriteLine($"Goblin HP: {goblin.health}");
            Console.WriteLine($"Player HP: {player.health}");
            Console.WriteLine($"Goblin intent: {goblinMove}");

            Console.WriteLine();

            Console.WriteLine("CHOOSE A MOVE");

            Console.WriteLine();

            Console.WriteLine("Moves:");
            Array.ForEach(player.moves, Console.WriteLine);

            string input = Console.ReadLine()!;
            input = input.ToLower();

            if (input == "slash")
            {
                Console.WriteLine();
                Console.WriteLine("Slash chosen!");
            }
            else if (input == "block")
            {
                Console.WriteLine();
                Console.WriteLine("Block chosen!");
            }
        }
    }
}