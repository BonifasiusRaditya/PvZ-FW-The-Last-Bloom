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
        Console.WriteLine($"Inventory contains {typeof(T).Name}s:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}