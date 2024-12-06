﻿using System;
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

                Console.WriteLine("Choose your weapons: (Maximum 4)");
                int weaponCount = 0;
                Console.WriteLine("1. NigShooter");
                Console.WriteLine("2. FreezePea");
                Console.WriteLine("3. FireBlaze");
                Console.WriteLine("4. LightningSnap");
                Console.WriteLine("5. SolarBloom");
                Console.WriteLine("6. ThornyCactus");

                while (weaponCount < 4)
                {
                    Console.Write("Choose a weapon: ");
                    string choiceWeapon = Console.ReadLine();

                    // Menggunakan switch case untuk memilih senjata
                    switch (choiceWeapon)
                    {
                        case "1":
                            player.AddPlant(new NigShooter());
                            break;
                        case "2":
                            player.AddPlant(new FreezePea());
                            break;
                        case "3":
                            player.AddPlant(new FireBlaze());
                            break;
                        case "4":
                            player.AddPlant(new LightningSnap());
                            break;
                        case "5":
                            player.AddPlant(new SolarBloom());
                            break;
                        case "6":
                            player.AddPlant(new ThornyCactus());
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please select a valid weapon.");
                            break;
                    }
                    weaponCount++;
                }

                Console.Clear();
                Console.WriteLine("                STAGE 1               ");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("|      A                             |");
                Console.WriteLine("|                              D     |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|              B                     |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                           C        |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|                                    |");
                Console.WriteLine("|               -you-                |");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Choose your path: ");
                string path = Console.ReadLine();
                path = path.ToUpper();

                switch (path)
                {
                    case "A":
                        Console.Clear();
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("You've encountered a Football Zombie!");
                        Console.WriteLine("--------------------------------------");
                        Thread.Sleep(1000);
                        Combat.Fight(player, new FootballZombie());
                        break;
                    case "B":
                        Console.Clear();
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("You've encountered a Fire Zombie!");
                        Combat.Fight(player, new FireZombie());
                        Console.WriteLine("--------------------------------------");
                        Thread.Sleep(1000);
                        break;
                    case "C":
                        Console.Clear();
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("You've encountered a Water Zombie!");
                        Console.WriteLine("--------------------------------------");
                        Combat.Fight(player, new WaterZombie());
                        Thread.Sleep(1000);
                        break;
                    case "D":
                        Console.Clear();
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("You've encountered a Light Zombie!");
                        Console.WriteLine("--------------------------------------");
                        Combat.Fight(player, new LightZombie());
                        Thread.Sleep(1000);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                GameSaveLoad.SaveGame(player); break;
            case "2":
                Console.WriteLine("Loading game...");
                Scientist loadedPlayer = GameSaveLoad.LoadGame();
                if (loadedPlayer != null)
                {
                    Console.WriteLine($"Welcome back, {loadedPlayer.Name}!");
                }
                break;
            case "3":
                Console.WriteLine("Option...");
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
