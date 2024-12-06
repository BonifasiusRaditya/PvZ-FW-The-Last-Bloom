using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public class Inventory<T> where T : Item
    {
        private List<T> items;
        private int capacity;

        public Inventory(int capacity)
        {
            this.capacity = capacity;
            items = new List<T>();
        }

        // Menambahkan item ke inventory
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

        // Mengambil item berdasarkan index
        public T GetItemAt(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];  // Mengembalikan item pada index tertentu
            }
            else
            {
                return null;  // Jika index tidak valid
            }
        }

        // Menampilkan semua item di inventory
        public void DisplayInventory()
        {
            Console.WriteLine("Inventory List:");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].Name}");
            }
        }

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

        // Mendapatkan jumlah item di inventory
        public int Count => items.Count;
    }
}
