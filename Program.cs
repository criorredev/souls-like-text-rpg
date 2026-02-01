using System;
using System.Runtime.CompilerServices;

class Player
{
    public int health = 20;
}

class Goblin
{
    public int health = 12;
    public string[] moves = { "slash", "pierce", "dodge" };
}

class Program
{
    static void Main()
    {
        Goblin goblin = new();
        Player player = new();

        Random moveSelector = new();
        int num = moveSelector.Next(3);
        string goblinMove = goblin.moves[num];

        while (player.health >= 0 && goblin.health >= 0)
        {
            Console.WriteLine($"Goblin HP: {goblin.health}");
            Console.WriteLine($"Player HP: {player.health}");
            Console.WriteLine($"Goblin uses: {goblinMove}");
        }
    }
}