using ElementType;
namespace MyNamespace;

public class FreezePea : Entity
{
    public FreezePea()
    {
        Name = "FreezePea";
        AttackDamage = 15;
        Health = 100;
        Exp = 0;
        Shield = 0;
        Level = 1;
        TypeElement = Element.Water;
        Description("A plant that slows enemies by shooting frozen peas.");
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        Console.WriteLine($"{Name} is hit but remains icy cool.");
    }

    // Skill khusus: Slow Enemy
    public void FreezeAttack(Entity target)
    {
        Console.WriteLine($"{Name} uses Freeze Attack on {target.Name}, slowing them down!");
        target.TakeDamage(this.AttackDamage);

    }
}
