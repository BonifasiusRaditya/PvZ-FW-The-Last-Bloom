public class Inventory<T> where T : class
{
    private List<T> items;

    public Inventory()
    {
        items = new List<T>();
    }

    public void AddItem(T item)
    {
        items.Add(item);
        Console.WriteLine("Obtained " + $"{item.GetType().Name}");
    }

    public void RemoveItem(T item)
    {
        items.Remove(item);
        Console.WriteLine($"{item.GetType().Name} removed from inventory.");
    }

    public void ShowInventory()
    {
        Console.WriteLine($"Inventory contains {typeof(T).Name}:");
        foreach (var item in items)
        {
            // Check if the item is of type Plants
            if (item is Plants plant)
            {
                Console.WriteLine(plant.Name);  // Print the Name of the plant
            }
            // Check if the item is of type Items
            else if (item is Items inventoryItem)
            {
                Console.WriteLine(inventoryItem.Name);  // Print the Name of the item
            }
            else
            {
                Console.WriteLine(item);  // Default, in case of other types
            }
            Console.WriteLine();
        }
    }
}