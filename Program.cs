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
                    Console.WriteLine("Name cannot be empty");
                    return;
                }
                Scientist player = new Scientist(name);  // Menyediakan nama pada konstruktor
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
                switch(path) {
                    case "A":
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("You've encountered a Football Zombie!");
                        Console.WriteLine("--------------------------------------");
                        Combat.Fight(player, new FootballZombie()); 
                        break;
                    case "B":
                        Console.WriteLine("You've encountered a Basketball Zombie!");
                        Combat.Fight(player, new FireZombie());
                        break;
                    case "C":
                        Console.WriteLine("You've encountered a Baseball Zombie!");
                        Combat.Fight(player, new WaterZombie());
                        break;
                    case "D":
                        Console.WriteLine("You've encountered a Volleyball Zombie!");
                        Combat.Fight(player, new LightZombie());
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
}
