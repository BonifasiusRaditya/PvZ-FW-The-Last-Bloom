namespace MyNamespace;

public static class Combat{
    public static void Fight(Entity player, Entity enemy){
        while(player.Health >= 0 || enemy.Health >= 0){
            Random rand = new Random();
            int randomMessage = rand.Next(1, 4);
            Console.Clear();
            // player.Display(); //debug -wesley
            // enemy.Display();  //debug
            switch(randomMessage){
                case 1:
                    Console.WriteLine("The wind is howling....");
                    break;
                case 2:
                    Console.WriteLine("The ground is shaking....");
                    break;
                case 3:
                    Console.WriteLine("The sky is darkening....");
                    break;
                default:
                    Console.WriteLine("The zombie stares at you....");
                    break;
            }
            Console.WriteLine($"{player.Name} Health: {player.Health}");
            Console.WriteLine($"{enemy.Name}'s Health: {enemy.Health}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("     Attack, Shield      ");
            Console.WriteLine("          Run            ");
            Console.WriteLine("     ShowInformation     ");
            Console.WriteLine("-------------------------");
            if(player.Health < 0){
                Console.WriteLine("You died");
                break;
            }

            if(enemy.Health < 0){
                Console.WriteLine("You win");
                player.Exp += enemy.Exp;
                break;
            }
            
            string option = Console.ReadLine();
            //player using item index 0
            if(option == "attack") enemy.Health -= player.Attack(player.AttackDamage);
            else if(option == "shield") player.Health = player.shielded(player.Health, player.Shield);
            else if(option == "run"){
                Console.WriteLine("You ran away");
                break;
            }
            else if(option == "showinformation"){
                player.Display();
                enemy.Display();
                Thread.Sleep(1000);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else Console.WriteLine("Invalid option");

            Console.Clear();
            Console.WriteLine($"The zombie attacks you, received {enemy.AttackDamage} damage");
            player.Health -= enemy.Attack(enemy.AttackDamage);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
