using MyNamespace;
using ElementType;

public class Scientist : Entity {
    public List<Entity> Plants;
    
    // Konstruktor untuk kelas Scientist
    public Scientist(string name) {
        Name = name;  // Mengatur properti Name yang diwarisi dari Entity
        Plants = new List<Entity>();
        AttackDamage = 1;
        Health = 100;
        Shield = 5;
        Exp = 0;
        Level = 2;
        TypeElement = Element.Normal;
    }

    // Fungsi untuk menambahkan item
    public void AddItem(Entity item) {
        Plants.Add(item);
        Console.WriteLine($"{item.Name} added to inventory");
        Thread.Sleep(2000);
    }

    // Fungsi untuk menghapus item
    public void RemoveItem(Entity item) {
        Plants.Remove(item);
    }
}
