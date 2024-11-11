public class Scientist
{
    private static Scientist? instance;

    private Inventory<Plants> PlantsInventory { get; set; }
    private Inventory<Items> ItemsInventory { get; set; }

    private Scientist()
    {
        PlantsInventory = new Inventory<Plants>();
        ItemsInventory = new Inventory<Items>();
    }

    public static Scientist GetInstance()
    {
        if (instance == null)
        {
            instance = new Scientist();
            Console.WriteLine("Axel has been created.");
        }
        return instance;
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
