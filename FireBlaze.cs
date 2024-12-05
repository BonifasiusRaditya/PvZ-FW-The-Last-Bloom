using ElementType;
namespace MyNamespace;

public class FireBlaze : Entity {
    public FireBlaze() {
        Name = "FireBlaze";
        AttackDamage = 30;
        Health = 80;
        Exp = 0;
        Shield = 0;
        Level = 1;
        TypeElement = Element.Fire;
        Description("A fiery plant that scorches zombies with flames.");
    }

    public override void TakeDamage(int damage) {
        base.TakeDamage(damage);
        Console.WriteLine($"{Name} is burning bright despite the damage.");
    }
}