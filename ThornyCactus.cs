using ElementType;
namespace MyNamespace;

public class ThornyCactus : Entity {
    public ThornyCactus() {
        Name = "ThornyCactus";
        AttackDamage = 25;
        Health = 130;
        Exp = 0;
        Shield = 10;
        Level = 1;
        TypeElement = Element.Normal;
        Description("A tough plant with sharp thorns that counterattacks.");
    }

    // Skill setelah menerima serangan, plant memberikan counterattacks
    public override void TakeDamage(int damage) {
        base.TakeDamage(damage);
        int counterDamage = 10;
        Console.WriteLine($"{Name} counterattacks, dealing {counterDamage} damage to its attacker.");
    }
}