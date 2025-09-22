using System.Diagnostics;
using App;

Player player = new Player();
player.HP = 100;

Monster monster = new Monster();
monster.DMG = 3;

while (true)
{
    player.TakeDamage(monster.DMG);
    if (player.HP == 0)
    {
        break;
    }
}

Console.WriteLine($"You died");
