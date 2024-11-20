namespace MyNamespace;

public static class Combat{
    public static void Fight(Entity player, Entity enemy){
        Console.WriteLine($"{player.Name} attacks {enemy.Name}!");
        enemy.TakeDamage(player.AttackDamage);
        Console.WriteLine($"{enemy.Name} has {enemy.Health} health remaining.");

        if (enemy.Health > 0){
            Console.WriteLine($"{enemy.Name} attacks back!");
            player.TakeDamage(enemy.Attack(enemy.AttackDamage));
        }
    }
}
