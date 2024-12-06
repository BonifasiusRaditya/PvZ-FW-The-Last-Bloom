using System;
using ElementType;
using MyNamespace;
using System.Collections.Generic;


class MainMission
{
    public static void Start(Scientist player)
    {
        Console.Clear();
        Console.WriteLine("Your journey to save the world begins!");
        Thread.Sleep(1000);

        // Pemilihan senjata
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

                Dictionary<string, bool> enemyStatus = new Dictionary<string, bool>
                {
                    { "A", false },
                    { "B", false },
                    { "C", false },
                    { "D", false }
                };

                while (enemyStatus.ContainsValue(false))
                {
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

                    if (!enemyStatus.ContainsKey(path))
                    {
                        Console.WriteLine("Invalid input, please select a valid path.");
                        Thread.Sleep(1000);
                        continue;
                    }

                    if (enemyStatus[path])
                    {
                        Console.WriteLine("You have already defeated the enemy in this location.");
                        Thread.Sleep(1000);
                        continue;
                    }

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
                Console.WriteLine("Enemy defeated!");
                Thread.Sleep(1000);
                enemyStatus[path] = true; // Tandai lokasi ini sebagai selesai
                GameSaveLoad.SaveGame(player);
            }
            Console.WriteLine("Stage 1 Completed!");
            GameSaveLoad.SaveGame(player);
        }
    }