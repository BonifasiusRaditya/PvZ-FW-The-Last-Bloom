public class FootballZombie : Zombie
{
    public FootballZombie()
    {
        Name = "Football Zombie";
        Health = 15;
        power = 15;
    }

    public override void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Console.WriteLine("Football Zombie has been defeated!");
        }
    }

    public override void Attack()
    {
        Console.WriteLine("Football Zombie is attacking!");
        //tambahin damage calculation?
    }
}