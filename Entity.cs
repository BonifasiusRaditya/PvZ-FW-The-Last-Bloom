using ElementType; 
namespace MyNamespace;

public class Entity{
    public string Name { get; set; }
    public int AttackDamage { get; set; }
    public int Health { get; set; }
    public int Exp { get; set; }
    public int Level { get; set; }

    public int Shield { get; set; }
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

    public void Description(string description){
        Console.WriteLine(description);
    }

    public virtual void Display(){
        if(this is Scientist)
        {
            Console.WriteLine("Your Stats: ");
        } 
        else if(!(this is Scientist))
        {
            Console.WriteLine("Enemy Stats: ");
        }
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Attack Damage: {AttackDamage}");
        Console.WriteLine($"Health: {Health}");
        if(this is Scientist)
        {
            Console.WriteLine($"Shield: {Shield}");
        }
        Console.WriteLine($"Exp: {Exp}");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"Type Element: {TypeElement}");
        Console.WriteLine("====================================");
        Console.WriteLine("");
    }

    public int shielded(int Health, int shield){
        return Health + shield;
    }
}