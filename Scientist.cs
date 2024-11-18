public class Scientist
{
    private static Scientist? instance;

    private Inventory<Plants> PlantsInventory { get; set; }
    private Inventory<Items> ItemsInventory { get; set; }

    public string name;

    private Scientist(string name)
    {
        this.name = name;
        PlantsInventory = new Inventory<Plants>();
        ItemsInventory = new Inventory<Items>();
    }

    public static Scientist GetInstance()
    {
        if (instance == null)
        {
            Console.WriteLine("Enter Scientist's name: ");
            string scientistName = Console.ReadLine();
            instance = new Scientist(scientistName);
            Console.WriteLine($"Welcome, {scientistName}!");
        }
        return instance ?? throw new InvalidOperationException("Scientist instance could not be created.");
    }

    public void AddPlant(Plants plant)
    {
        PlantsInventory.AddItem(plant);
    }

    public void RemovePlant(Plants plant)
    {
        PlantsInventory.RemoveItem(plant);
    }

    public void AddItem(Items item)
    {
        ItemsInventory.AddItem(item);
    }
    public void RemoveItem(Items item)
    {
        ItemsInventory.RemoveItem(item);
    }

    public void ShowInventory()
    {
        Console.WriteLine("Plants Inventory:");
        PlantsInventory.ShowInventory();

        Console.WriteLine("Items Inventory:");
        ItemsInventory.ShowInventory();
    }
}
