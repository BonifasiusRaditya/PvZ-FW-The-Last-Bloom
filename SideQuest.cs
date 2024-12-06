using System;
using ElementType;
using MyNamespace;

class SideQuest
{
    public static void Start(Scientist player)
    {
        Console.Clear();
        Console.WriteLine("You chose a Side Quest!");
        Console.WriteLine("Your task is to collect rare plant seeds guarded by zombies.");
        Console.WriteLine("Prepare yourself for battle!");
        Thread.Sleep(1000);

        // Contoh encounter di side quest
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("You've encountered a Swarm of Basic Zombies!");
        Console.WriteLine("--------------------------------------");
        Combat.Fight(player, new ());
        
        Console.WriteLine("You successfully completed the Side Quest and collected rare seeds!");
        Thread.Sleep(1000);
    }
}
