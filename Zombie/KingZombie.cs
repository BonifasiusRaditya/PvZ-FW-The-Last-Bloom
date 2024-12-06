using ElementType;
namespace MyNamespace;

public class KingZombie : Entity {
    private bool BerserkMode { get; set; } = false;

    public KingZombie() {
        Name = "King Zombie";
        AttackDamage = 50;
        Health = 1000;
        Exp = 300;
        TypeElement = Element.Dark;
        Description("The ultimate zombie king, equipped with devastating powers and immense resilience.");
    }

    public void DarkWave(List<Entity> targets) {    // Serangan area besar
        Console.WriteLine($"{Name} unleashed Dark Wave, damaging all enemies!");
        foreach (var target in targets) {
            target.TakeDamage(this.AttackDamage / 3);
        }
    }

    public void Berserk() {                        // Masuk mode berserk ketika health tinggal 30%
        if (!BerserkMode && Health <= 300) {
            Console.WriteLine($"{Name} has entered Berserk Mode, doubling its attack power!");
            BerserkMode = true;
            AttackDamage *= 2;
        }
    }

    public override void TakeDamage(int damage) {
        base.TakeDamage(damage);
        Berserk();
    }
}