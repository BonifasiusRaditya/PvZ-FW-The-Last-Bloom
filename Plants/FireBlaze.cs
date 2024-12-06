using ElementType;
namespace MyNamespace;

public class FireBlaze : Entity
{
    public FireBlaze()
    {
        Name = "FireBlaze";
        AttackDamage = 30;
        Health = 80;
        Exp = 0;
        Shield = 0;
        Level = 1;
        TypeElement = Element.Fire;
        Description("A fiery plant that scorches zombies with flames.");
    }

    // Skill khusus: Ignite Enemy (damage overtime)
    public int Ignite(Entity target)
    {
        int igniteDamage = 10;
        Console.WriteLine($"{Name} ignites {target.Name}, dealing {igniteDamage} burn damage over time!");
        target.TakeDamage(igniteDamage);
        return igniteDamage; // Mengembalikan damage burn yang diberikan
    }
}