using ElementType;
namespace MyNamespace;

public class BossZombie : Entity {
    public BossZombie(int level) {
        Name = "Boss Zombie"; 
        AttackDamage = 30 + (10 * (Level - 1)); 
        Health = 500 + (200 * (Level - 1));    
        Exp = 80 + (20 * (Level - 1));     
        Level = level;
        TypeElement = Element.Lightning;
        Description($"A formidable boss zombie at level {Level}, stronger and more resilient.");
    }

    public void StormStrike(Entity target) {  // Serangan dengan damage tinggi
        Console.WriteLine($"{Name} used Storm Strike on {target.Name}, dealing massive damage!");
        target.TakeDamage(this.AttackDamage * 2);
    }

    public void Regenerate() {               // Memulihkan kesehatan saat battle
        int regenAmount = 50 + (20 * (Level - 1));
        Console.WriteLine($"{Name} regenerated {regenAmount} health!");
        Health += regenAmount;
        if (Health < 150) {
            Health = 70 + (50 * (Level - 1));
        }
    }

    public override void TakeDamage(int damage) {
        base.TakeDamage(damage);
        Console.WriteLine($"{Name} took {damage} damage! Remaining health: {Health}");
        if (Health <= 0) {
            Console.WriteLine($"{Name} has been defeated!");
        }
    }
}