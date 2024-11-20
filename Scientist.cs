using MyNamespace;

public class Scientist : Entity {
    public new string Name { get; private set; } // Menyembunyikan properti Name dari Entity jika perlu
    public List<Entity> Plants { get; private set; }
    
    // Konstruktor untuk kelas Scientist
    public Scientist(string name) : base(name) {
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
