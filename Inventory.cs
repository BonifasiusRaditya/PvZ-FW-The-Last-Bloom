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
        Console.Clear();
        Console.WriteLine("Obtained " + $"{item.GetType().Name}.");
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
            if (item is Plants plant)
            {
                Console.WriteLine(plant.Name);  
            }
            else if (item is Items inventoryItem)
            {
                Console.WriteLine(inventoryItem.Name);  
            }
            else
            {
                Console.WriteLine(item);  
            }
            Console.WriteLine();
        }
    }
}