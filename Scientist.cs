using MyNamespace;
using ElementType;

public class Scientist : Entity {
    public List<Entity> Plants { get; private set; } 
    public Inventory<Item> Inventory { get; private set; } 

    public Scientist(string name) {
        Name = name; 
        Plants = new List<Entity>(4); //batas kapasitas plants 4
        Inventory = new Inventory<Item>(2); //kapsistas untuk healing potion dan shield upgrade

        AttackDamage = 1;
        Health = 200;
        Shield = 10;
        Exp = 0;
        Level = 1;
        TypeElement = Element.Normal;
    }

    public void AddPlant(Entity plant) {
        if (Plants.Count >= 4) {  // maksimal 4 tanaman
            Console.WriteLine("You cannot carry more than 4 plants into battle.");
            return;
        }
        Plants.Add(plant);
        Console.WriteLine($"{plant.Name} added to your plant inventory.");
    }

    public void AddItem(Item item) {
        if (Inventory.AddItem(item)) {
            Console.WriteLine($"{item.Name} added to your item inventory.");
        }
    }

    public void RemovePlant(Entity plant) {
        if (Plants.Contains(plant)) {
            Plants.Remove(plant);
            Console.WriteLine($"{plant.Name} removed from your plant inventory.");
        } else {
            Console.WriteLine($"{plant.Name} is not in your plant inventory.");
        }
    }

    public void LevelUp() {
        Level++;
        Health += 10;
        AttackDamage += 3;
        Shield += 3;
        Console.WriteLine($"Level up! You are now level {Level}.");
    }

    public void AddXP(int xp) {
        Exp += xp;
        Console.WriteLine($"{Name} gained {xp} XP.");
        if (Exp >= 100 * Level) {
            Exp = 0;
            LevelUp();
        }
    }

    public override void Display() {
        Console.WriteLine("Scientist Stats:");
        base.Display();
        Console.WriteLine($"{Name}'s Plants:");
        foreach (var plant in Plants) {
            Console.WriteLine($"- {plant.Name} (Element: {plant.TypeElement}, Damage: {plant.AttackDamage})");
        }
    }
}