namespace MyNamespace {
    public static class Combat {       // janlup tambahin yg element effectiveness
        public static void Fight(Entity player, Entity enemy) {
            while (player.Health > 0 && enemy.Health > 0) {
                Random rand = new Random();
                int randomMessage = rand.Next(1, 4);
                Console.Clear();

                // Random weather messages
                switch (randomMessage) {
                    case 1: Console.WriteLine("The wind is howling...."); break;
                    case 2: Console.WriteLine("The ground is shaking...."); break;
                    case 3: Console.WriteLine("The sky is darkening...."); break;
                    default: Console.WriteLine("The zombie stares at you...."); break;
                }

                // Display player and enemy health
                Console.WriteLine($"{player.Name} Health: {player.Health}");
                Console.WriteLine($"{enemy.Name}'s Health: {enemy.Health}");
                Console.WriteLine("-------------------------");
                Console.WriteLine("     Attack, Shield      ");
                Console.WriteLine("          Run            ");
                Console.WriteLine("     ShowInformation     ");
                Console.WriteLine("-------------------------");

                // Check if player is dead
                if (player.Health <= 0) {
                    Console.WriteLine("You died");
                    break;
                }

                // Check if enemy is dead
                if (enemy.Health <= 0) {
                    Console.WriteLine("You win");
                    player.Exp += enemy.Exp;
                    break;
                }

                // Player choice
                string option = Console.ReadLine();
                if (option.ToLower() == "attack") {
                    if (player is Scientist scientist) {
                        if (scientist.Plants.Count > 0) {
                            Entity plant = scientist.Plants[0];
                            int damage = player.Attack(plant.AttackDamage); 
                            enemy.Health -= damage; 
                            Console.WriteLine($"You attacked the zombie with {plant.Name}, dealing {plant.AttackDamage} damage");
                            Thread.Sleep(1000);
                        } else {
                            Console.WriteLine("No plants in inventory!");
                            break;
                        }
                    } else {
                        Console.WriteLine("Player is not a scientist and has no plants!");
                        break;
                    }
                } else if (option == "shield") {
                    player.Health = player.shielded(player.Health, player.Shield);
                } else if (option == "run") {
                    Console.WriteLine("You ran away");
                    break;
                } else if (option == "showinformation") {
                    player.Display();
                    enemy.Display();
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                } else {
                    Console.WriteLine("Invalid option");
                    Thread.Sleep(1000);
                }

                if(option != "showinformation") {
                    player.Health -= enemy.AttackDamage;
                    Console.WriteLine($"{enemy.Name} attacked you, dealing {enemy.AttackDamage} damage");
                    Thread.Sleep(1000);
                }
            }

            if (enemy.Health <= 0) {
                    Console.WriteLine("You win");
                    player.Exp += enemy.Exp;
                    if(player.Exp >= 100*player.Level){ {
                        player.Level++;
                        player.Exp = 0;
                        player.Health += 50;
                        player.AttackDamage += 5;
                        player.Shield += 5;
                    }
                }
            }
        }
    }
}
