namespace App;

class Player
{
    public int HP;
    public Weapon MainHand;

    public void PrintStats()
    {
        Console.WriteLine($"HP: {HP}");
    }

    public void TakeDamage(Weapon weapon)
    {
        HP -= weapon.DMG;
    }
}