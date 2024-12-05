using ElementType; 
namespace MyNamespace;

public class Entity {
    public string Name { get; set; }
    public int AttackDamage { get; set; }
    public int Health { get; set; }
    public int Exp { get; set; }
    public int Level { get; set; }
    public int Shield { get; set; }
    public Element TypeElement { get; set; }
    
    public int Attack(Entity target) {
        double elementMultiplier = ElementEffectiveness.GetMultiplier(this.TypeElement, target.TypeElement);
        int criticalMultiplier = Critical(); 
        int damage = (int)(this.AttackDamage * elementMultiplier * criticalMultiplier);

        target.TakeDamage(damage);

        string criticalInfo = (criticalMultiplier > 1) ? " (Critical Hit!)" : "";
        Console.WriteLine($"{this.Name} attacked {target.Name} dealing {damage} damage ({ElementEffectiveness.GetEffectivenessDescription(this.TypeElement, target.TypeElement)}){criticalInfo}.");

        return damage;
    }
    
    public virtual void TakeDamage(int damage) {
        Health -= damage;
        if (Health <= 0) {
            Console.WriteLine($"{Name} has been defeated!");
            Health = 0;
        }
    }

    // Critical hit
    public int Critical() {
        Random rand = new Random();
        int rng = rand.Next(1, 101);
        if (rng <= 21) {
            return 2; // 21% chance for critical hit
        } else {
            return 1;
        }
    }

    // Efek Buff
    public void ApplyBuff(string attribute, int value) {
        switch (attribute.ToLower()) {
            case "attackdamage":
                AttackDamage += value;
                Console.WriteLine($"{Name}'s attack damage increased by {value}!");
                break;
            case "health":
                Health += value;
                Console.WriteLine($"{Name}'s health increased by {value}!");
                break;
            case "shield":
                Shield += value;
                Console.WriteLine($"{Name}'s shield increased by {value}!");
                break;
            default:
                Console.WriteLine("Invalid attribute for buff!");
                break;
        }
    }

    // Efek Debuff
    public void ApplyDebuff(string attribute, int value) {
        switch (attribute.ToLower()) {
            case "attackdamage":
                AttackDamage = Math.Max(0, AttackDamage - value);
                Console.WriteLine($"{Name}'s attack damage decreased by {value}!");
                break;
            case "health":
                Health = Math.Max(0, Health - value);
                Console.WriteLine($"{Name}'s health decreased by {value}!");
                break;
            case "shield":
                Shield = Math.Max(0, Shield - value);
                Console.WriteLine($"{Name}'s shield decreased by {value}!");
                break;
            default:
                Console.WriteLine("Invalid attribute for debuff!");
                break;
        }
    }

    // Shield 
    public int Shielded(int health, int shield) {  
        return health + shield;
    }

    public void Description(string description) {
        Console.WriteLine(description);
    }

    // Status entity
    public virtual void Display() {
        if (this is Scientist) {
            Console.WriteLine("Your Stats:");
        } else {
            Console.WriteLine("Enemy Stats:");
        }
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Attack Damage: {AttackDamage}");
        Console.WriteLine($"Health: {Health}");
        if (this is Scientist) {
            Console.WriteLine($"Shield: {Shield}");
        }
        Console.WriteLine($"Exp: {Exp}");
        if (this is Scientist) {
            Console.WriteLine($"Level: {Level}");
        }
        Console.WriteLine($"Type Element: {TypeElement}");
        Console.WriteLine("====================================");
        Console.WriteLine("");
    }
}