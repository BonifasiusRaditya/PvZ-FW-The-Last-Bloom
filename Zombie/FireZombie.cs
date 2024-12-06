using ElementType;
namespace MyNamespace;

public class FireZombie : Entity
{
    public FireZombie()
    {
        Name = "Fire Zombie";
        AttackDamage = 30;
        Health = 50;
        Exp = 30;
        TypeElement = Element.Fire;
        Description("A fiery zombie with destructive power, strong against lightning but weak against water.");
    }

    public void FlameBurst(Entity target) {                // Menyerang dengan damage tinggi
        Console.WriteLine($"{Name} used Flame Burst on {target.Name}, dealing massive damage!");
        target.TakeDamage(this.AttackDamage * 2);
    }

    public void InfernalFrenzy(List<Entity> enemies) {    // Menyerang secara acak
        Console.WriteLine($"{Name} entered Infernal Frenzy, attacking randomly!");
        Random rand = new Random();
        for (int i = 0; i < 3; i++)  // Serangan sebanyak tiga kali
        {                  
            var target = enemies[rand.Next(enemies.Count)];
            Console.WriteLine($"{Name} attacked {target.Name} in a frenzy!");
            target.TakeDamage(this.AttackDamage);
        }
    }
}