namespace MyNamespace;

public static class Combat{
    public static void Fight(Entity player, Entity enemy){
        while(player.Health >= 0 || enemy.Health >= 0){
            Console.Clear();
            Console.WriteLine($"{player.Name} Health: {player.Health}");
            Console.WriteLine($"{enemy.Name} Health: {enemy.Health}");
            Console.WriteLine("--------------------");
            Console.WriteLine("Options: attack, shield, run");
            string option = Console.ReadLine();
            //player using item index 0
            if(option == "attack") enemy.Health -= player.Attack(enemy.AttackDamage);
            else if(option == "shield") player.Health += player.shielded(player.Health, 10);
            else if(option == "run"){
                Console.WriteLine("You ran away");
                break;
            }
            else Console.WriteLine("Invalid option");
            if(player.Health <= 0){
                Console.WriteLine("You died");
                break;
            }
            else{
                Console.WriteLine("You won");
                player.Exp += enemy.Exp;
                break;
            }
        }
    }
}
