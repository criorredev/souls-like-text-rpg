Goblin goblin = new Goblin();
Player player = new Player();

Console.WriteLine($"Goblin HP: {goblin.health}");
Console.WriteLine($"Player HP: {player.health}");

class Player
{
    public int health = 20;
}

class Goblin
{
    public int health = 12;
}
