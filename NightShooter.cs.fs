using ElementType;
namespace MyNamespace;

public class NightShooter : Entity
{
    public NightShooter()
    {
        Name = "NightShooter";
        AttackDamage = 20;
        Health = 100;
        Shield = 0;
        Exp = 0;
        Level = 1;
        TypeElement = Element.Normal;
        Description("A plant that shoots dark energy to attack enemies.");
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        Console.WriteLine($"{Name} is hit but remains strong.");
    }

    // Skill khusus: Dark Energy Attack
    public void DarkEnergyAttack(Entity target)
    {
        Console.WriteLine($"{Name} shoots dark energy at {target.Name}!");
        target.TakeDamage(this.AttackDamage);
    }
}


