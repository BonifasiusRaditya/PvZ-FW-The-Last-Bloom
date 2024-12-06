using ElementType;
namespace MyNamespace;
public class LightningSnap : Entity {
    public LightningSnap() {
        Name = "LightningSnap";
        AttackDamage = 20;
        Health = 120;
        Exp = 0;
        Shield = 0;
        Level = 1;
        TypeElement = Element.Lightning;
        Description("A plant that zaps zombies with electrical energy.");
    }

    public int ChainLightning(Entity[] enemies) {
    int totalDamage = 0;
    Console.WriteLine($"{Name} unleashes a chain lightning attack!");
    foreach (var enemy in enemies) {
        // Menghitung damage 
        int damage = this.AttackDamage;
        Console.WriteLine($"Chain lightning hits {enemy.Name}, dealing {damage} damage.");
        enemy.TakeDamage(damage);  // Memberikan damage kepada musuh
        totalDamage += damage;
    }
    return totalDamage;
}

}