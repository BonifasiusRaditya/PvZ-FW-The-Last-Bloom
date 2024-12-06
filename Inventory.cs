using System;
using System.Collections.Generic;
namespace MyNamespace;

// Generic Inventory class for storing items
public class Inventory<T> where T : Item
{
    private List<T> items;
    private int capacity;

    public Inventory(int capacity)
    {
        this.capacity = capacity;
        items = new List<T>();
    }

    // Add item to inventory
    public bool AddItem(T item)
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

    // Remove item from inventory
    public bool RemoveItem(T item)
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

    // Display all items in the inventory
    public void DisplayInventory()
    {
        Console.WriteLine("Inventory List:");
        foreach (var item in items)
        {
            Console.WriteLine($"- {item.Name} (Type: {item.GetType().Name})");
        }
    }

    // Use an item from the inventory
    public void UseItem(int index, Entity target)
    {
        if (index >= 0 && index < items.Count)
        {
            T item = items[index];
            item.Use(target);  
        }
        else
        {
            Console.WriteLine("Invalid item index.");
        }
    }
}

