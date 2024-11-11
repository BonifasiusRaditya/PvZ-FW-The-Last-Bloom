public class Scientist
{
    private static Scientist instance;

    // Private inventories to hold plants and items
    private Inventory<Plants> PlantsInventory { get; set; }
    private Inventory<Items> ItemsInventory { get; set; }

    // Private constructor for Singleton pattern
    private Scientist()
    {
        PlantsInventory = new Inventory<Plants>();
        ItemsInventory = new Inventory<Items>();
    }

    // Singleton method to get the instance of Scientist
    public static Scientist GetInstance()
    {
        if (instance == null)
        {
            instance = new Scientist();
            Console.WriteLine("Axel has been created.");
        }
        return instance;
    }

    // Method to add a plant to the inventory
    public void AddPlant(Plants plant)
    {
        PlantsInventory.AddItem(plant);
    }

    // Method to remove a plant from the inventory
    public void RemovePlant(Plants plant)
    {
        PlantsInventory.RemoveItem(plant);
    }

    // Method to add an item to the inventory
    public void AddItem(Items item)
    {
        ItemsInventory.AddItem(item);
    }

    // Method to remove an item from the inventory
    public void RemoveItem(Items item)
    {
        ItemsInventory.RemoveItem(item);
    }

    // Method to display all items in both inventories
    public void ShowInventory()
    {
        Console.WriteLine("Plants Inventory:");
        PlantsInventory.ShowInventory();

        Console.WriteLine("Items Inventory:");
        ItemsInventory.ShowInventory();
    }
}
