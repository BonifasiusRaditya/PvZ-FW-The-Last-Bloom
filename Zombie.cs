namespace MyNamespace;

public abstract class Zombie{
    required public string Name { get; set; }
    public int AttackDamage { get; set; }
    public int Health { get; set; }
    public int Exp { get; set; }
    public int Level { get; set; }
    public string ? Type { get; set; }
    public abstract int Attack();
    public abstract void TakeDamage(int damage);
    public virtual void Description(string desc){
        Console.WriteLine($"{Name}: {desc}");
    }
}