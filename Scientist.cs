using MyNamespace;

public class Scientist : Entity {
    public string Name;
    public List<Entity> Plants;
    
    // Konstruktor untuk kelas Scientist
    public Scientist(string name) {
        Name = name;  // Mengatur properti Name yang diwarisi dari Entity
        Plants = new List<Entity>();
    }

    // Fungsi untuk menambahkan item
    public void AddItem(Entity item) {
        Plants.Add(item);
    }

    // Fungsi untuk menghapus item
    public void RemoveItem(Entity item) {
        Plants.Remove(item);
    }
}
