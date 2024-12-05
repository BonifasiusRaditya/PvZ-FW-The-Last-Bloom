using System;
namespace MyNamespace;

public class Inventory
{
    private List<Entity> items;
    private int capacity;

    public Inventory(int capacity)
    {
        this.capacity = capacity;
        items = new List<Entity>();
    }

    public bool AddItem(Entity item)
    {
        if (items.Count < capacity)
        {
            items.Add(item);
            Console.WriteLine($"{item.Name} added to inventory.");
            return true;
        }
        else
        {
            Console.WriteLine("Inventory is full! Cannot add item.");
            return false;
        }
    }

    public bool RemoveItem(Entity item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Console.WriteLine($"{item.Name} removed from inventory.");
            return true;
        }
        else
        {
            Console.WriteLine("Item not found in inventory.");
            return false;
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Inventory List:");
        foreach (var item in items)
        {
            Console.WriteLine($"- {item.Name} (Type: {item.GetType().Name})");
        }
    }
}