using ElementType; 
namespace MyNamespace;

public class Entity{
    required public string Name { get; set; }
    public int AttackDamage { get; set; }
    public int Health { get; set; }
    public int Exp { get; set; }
    public int Level { get; set; }
    public Element TypeElement { get; set; }

    public int Attack(int AttackDamage){
        return AttackDamage * Critical();
    }
    
    public void TakeDamage(int damage){
        Health -= damage;
        if (Health <= 0) Console.WriteLine($"{Name} has been defeated!");
    }

    public int Critical(){
        Random rand = new Random();
        return rand.Next(1, 4);
    }

    public virtual void Description(string desc){
        Console.WriteLine($"{Name}: {desc}");
    }
}