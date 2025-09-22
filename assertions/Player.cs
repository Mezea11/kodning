namespace App;

using System.Diagnostics;
public class Player
{
    public int HP;

    public bool Alive;

    public void TakeDamage(int dmg)
    {
        HP -= dmg;

        Die();

        if (HP > 0)
        {
            Debug.Assert(Alive, $"HP: {HP}");
        }

        if (HP < 0)
        {
            HP = 0;
        }

        Debug.Assert(HP >= 0);

    }

    private void Die()
    {
        if (HP <= 0)
        {
            Alive = false;
        }
    }

}

public class Monster
{
    public int DMG;
}