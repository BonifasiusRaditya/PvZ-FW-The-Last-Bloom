using ElementType;
namespace MyNamespace;

public class NigShooter : Entity
{
    public NigShooter()
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

    // Skill khusus: Dark Energy Attack
    public void DarkEnergyAttack(Entity target)
    {
        Console.WriteLine($"{Name} shoots dark energy at {target.Name}!");
        target.TakeDamage(this.AttackDamage);
    }
}


