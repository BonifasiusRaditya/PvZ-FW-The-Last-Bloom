using System;
using ElementType;
using MyNamespace; 

class Program {
    static void Main(string[] args) {
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
        switch(input) {
            case "1":
                Console.WriteLine("Starting new game...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name)) {
                    Console.WriteLine("Name cannot be empty. You died before you were even born.");
                    return;
                }
                Scientist player = new Scientist(name);  // Menyediakan nama pada konstruktor
                Console.WriteLine($"Welcome, {player.Name}!");
                Thread.Sleep(2000);
                Story();
                Console.Clear();
                Console.WriteLine("Choose your weapon: ");
                Console.WriteLine("1. NigShooter");
                string choiceWeapon = Console.ReadLine();
                if(choiceWeapon == "1") player.AddItem(new NigShooter());  
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

                switch(path) {
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
                break;
            case "2":
                Console.WriteLine("Loading game...");
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

    public static void Story(){
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
