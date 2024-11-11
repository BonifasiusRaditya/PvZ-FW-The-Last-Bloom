public class Items
{
    public string Name { get; set; }
    public ItemType Type { get; set; }

    public enum ItemType {
        SingleUse,
        Treasures,
        Misc
    }

    public Items(string name, ItemType type)
    {
        Type = type;
        Name = name;
    }

    public void showDescription()
    {
        Console.WriteLine($"{Name}: ");
    }

    //Bagian Radit buat tanamannya
}