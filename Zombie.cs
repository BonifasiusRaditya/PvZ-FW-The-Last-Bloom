// Abstract class defining common properties and methods for all enemies
public abstract class Zombie
{
    required public string Name { get; set; }
    public int Health { get; set; }
    public int power { get; set; }

    public string ? Type { get; set; }

    public abstract void Attack();
    public abstract void TakeDamage(int damage);
}
