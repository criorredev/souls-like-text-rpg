Goblin goblin = new Goblin();
Player player = new Player();

Random moveSelector = new Random();
int num = moveSelector.Next(3);
string goblinMove = goblin.moves[num];

Console.WriteLine($"Goblin HP: {goblin.health}");
Console.WriteLine($"Player HP: {player.health}");
Console.WriteLine($"Goblin uses: {goblinMove}");

class Player
{
    public int health = 20;
}

class Goblin
{
    public int health = 12;
    public string[] moves = {"slash", "pierce", "dodge"};
}