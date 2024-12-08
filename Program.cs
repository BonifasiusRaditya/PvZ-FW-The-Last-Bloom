using System;
using ElementType;
using MyNamespace;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("====================================");
        Console.WriteLine("| Welcome to PvZ: The Last Bloom   |");
        Console.WriteLine("====================================");
        Console.WriteLine("| 1. Start                         |");
        Console.WriteLine("| 2. Load                          |");
        Console.WriteLine("| 3. Option                        |");
        Console.WriteLine("| 4. Exit                          |");
        Console.WriteLine("====================================");
        Console.Write("Choose: ");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Console.WriteLine("Starting new game...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name cannot be empty. You died before you were even born.");
                    return;
                }
                Scientist player = new Scientist(name);
                // Menambahkan 2 item ke inventory item
                player.AddItem(new HealingPotion()); // Tambahkan HealthPotion
                player.AddItem(new ShieldUpgrade()); // Tambahkan ShieldUpgrade
                Console.WriteLine($"Welcome, {player.Name}!");
                Thread.Sleep(1000);
                Story();
                Console.Clear();

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("====================================");
                    Console.WriteLine("| 1. Main Mission                  |");
                    Console.WriteLine("| 2. Side Quest                    |");
                    Console.WriteLine("| 3. Exit to Main Menu             |");
                    Console.WriteLine("====================================");
                    Console.Write("Choose: ");
                    string Choice = Console.ReadLine();

                    switch (Choice)
                    {
                        case "1":
                            MainMission.Start(player); // Memanggil MainMission
                        break;
                        case "2":
                            SideQuest.Start(player); // Memanggil SideQuest
                        break; // Keluar dari loop setelah Main Mission
                        case "3":
                            Console.WriteLine("Returning to the main menu...");
                            Thread.Sleep(1000);
                        return; // Kembali ke menu utama
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                        break;
                    }
                }
            case "2":
                Console.WriteLine("Loading game...");
                Scientist loadedPlayer = GameSaveLoad.LoadGame();
                if (loadedPlayer != null)
                {
                    Console.WriteLine($"Welcome back, {loadedPlayer.Name}!");
                }
                Console.Clear();
                    Console.WriteLine("====================================");
                    Console.WriteLine("| 1. Main Mission                  |");
                    Console.WriteLine("| 2. Side Quest                    |");
                    Console.WriteLine("| 3. Use Rare Seed                 |");
                    Console.WriteLine("| 4. Exit to Main Menu             |");
                    Console.WriteLine("====================================");
                    Console.Write("Choose: ");
                    string questChoice = Console.ReadLine();

                    switch (questChoice)
                    {
                        case "1":
                            MainMission.Start(loadedPlayer); // Memanggil MainMission
                        break;
                        case "2":
                            SideQuest.Start(loadedPlayer); // Memanggil SideQuest
                        return; // Keluar dari loop setelah Main Mission
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Opening inventory...");
                            Thread.Sleep(500);
            break;
                        case "4":
                            Console.WriteLine("Returning to the main menu...");
                            Thread.Sleep(1000);
                        return; // Kembali ke menu utama
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                        break;
                    }
                break;
            case "4":
                Console.WriteLine("Exiting game...");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
    public static void Story()
    {
        Console.WriteLine("You are the last human, a scientist who is trying to save the world from the zombie apocalypse");
        Thread.Sleep(1000);
        Console.WriteLine("Having no weapons, you realized that you have to make your own weapon to fight the zombies");
        Thread.Sleep(1000);
        Console.WriteLine("Kill all the zombies, and purge the world from evil!");
        Thread.Sleep(1000);
        Console.WriteLine("Good luck!");
        Thread.Sleep(1000);
    }
}