public class Items
{
    public string Name { get; set; }
    public enum ItemType {
        SingleUse,
        Treasures,
        Misc
    }

    public Items(string name, ItemType type)
    {
        Name = name;
        ItemType = type;
    }

    public void showDescription()
    {
        Console.WriteLine($"{Name}: ");
    }

    //Bagian Radit buat tanamannya
}