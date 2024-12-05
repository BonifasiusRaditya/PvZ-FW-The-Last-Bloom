using ElementType; 
namespace MyNamespace;

public class FootballZombie : Entity {
    private bool IsResilient { get; set; }

    public FootballZombie() {
        Name = "Football Zombie";
        AttackDamage = 15;
        Health = 100;
        Exp = 40;
        TypeElement = Element.Normal;
        Description("A strong zombie wearing football gear, with no elemental strength or weakness.");
    }

    public void ChargeAttack(Entity target) {    // Menyerang sebanyak dua kali
        Console.WriteLine($"{Name} used Charge Attack!");
        for (int i = 0; i < 2; i++) {
            this.Attack(target); 
        }
    }

    public void Resilience() {                  // Mengurangi damage sebesar 50%
        Console.WriteLine($"{Name} activated Resilience, reducing incoming damage by 50% for the next attack!");
        IsResilient = true; 
    }

    public override void TakeDamage(int damage) {
        if (IsResilient) {
            damage /= 2; 
            Console.WriteLine($"{Name} resisted the attack, taking only {damage} damage!");
            IsResilient = false;
        }

        Health -= damage;
        if (Health <= 0) {
            Console.WriteLine($"{Name} has been defeated!");
            Health = 0;
        } else {
            Console.WriteLine($"{Name} took {damage} damage! Remaining health: {Health}");
        }
    }
}