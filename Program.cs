using System;
using System.Threading;

class Program
{
    static bool exit = false;
    public Program()
    {

    }

    static void Main(string[] args)
    {
        Start();
        if(exit == true)
        {
            return;
        }
        else
        {
            Console.WriteLine("Game Started");
        }
    }
    
    static void Start()
    {
        Scientist AxelAdrialPazaKalembang = Scientist.GetInstance();
    

        AxelAdrialPazaKalembang.AddPlant(PlantFactory.CreatePlant("Sunflower"));

        AxelAdrialPazaKalembang.ShowInventory();

        Thread.Sleep(3000);
        
            Console.Clear();
            Thread.Sleep(1300);
            Console.WriteLine("The name that will save the world: " + AxelAdrialPazaKalembang.name);
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
                    exit = false;
                    break;
                case "2":
                    Console.WriteLine("Exiting Game...");
                    Thread.Sleep(1300);
                    Console.WriteLine("Thanks For Playing!!");
                    exit = true;
                    break;
            }
        
    }
    
}
