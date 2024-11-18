using System;
using System.Threading;

class Program
{
    public Program()
    {

    }

    static void Main(string[] args)
    {
        Scientist Axel = Scientist.GetInstance();
        
        bool running = true;

        Axel.AddPlant(PlantFactory.CreatePlant("Sunflower"));

        Axel.ShowInventory();

        Thread.Sleep(3000);

        while(running)
        {
            Console.Clear();
            Console.WriteLine("Plants vs Zombies: The Last Bloom" + "\n");
            Thread.Sleep(1300);
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Exit");
            Console.Write("> ");

            string userinput = Console.ReadLine();
            
            switch(userinput)
            {
                case "1":
                    Console.WriteLine("\nStarting Game...");
                    Thread.Sleep(1300);
                    break;
                case "2":
                    Console.WriteLine("Exiting Game...");
                    Thread.Sleep(1300);
                    running = false;
                    break;
            }
        }
    }
    
    
}
