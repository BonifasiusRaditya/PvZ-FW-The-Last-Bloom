using ElementType;
namespace MyNamespace
{

    public class FireBlaze : Entity
    {
        public FireBlaze()
        {
            Name = "FireBlaze";
            AttackDamage = 30;
            Health = 80;
            Exp = 0;
            Shield = 0;
            Level = 1;
            TypeElement = Element.Fire;
            Description("A fiery plant that scorches zombies with flames.");
        }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            Console.WriteLine($"{Name} is burning bright despite the damage.");
        }

        // Menggunakan Ignite untuk memberikan burn damage selama beberapa turn
        public IgniteEffect Ignite(Entity target)
        {
            int igniteDamage = 10;  // Damage per turn
            int burnTurns = 3;      // burn effect selama 3 turn
            Console.WriteLine($"{Name} ignites {target.Name}, dealing {igniteDamage} burn damage over {burnTurns} turns!");

            return new IgniteEffect(igniteDamage, burnTurns, target);
        }
    }

    //Class IgniteEffect untuk menangani damage over time (DOT)
    public class IgniteEffect
    {
        public int DamagePerTurn { get; set; } 
        public int TurnsLeft { get; set; } 
        public Entity Target { get; set; }

        public IgniteEffect(int damagePerTurn, int turnsLeft, Entity target)
        {
            DamagePerTurn = damagePerTurn;
            TurnsLeft = turnsLeft;
            Target = target;
        }

        // Setiap kali Apply dipanggil, akan memberikan burn damage ke target
        public void Apply()
        {
            if (TurnsLeft > 0)
            {
                Target.Health -= DamagePerTurn; // Kurangi health target setiap turn
                TurnsLeft--; // Kurangi sisa turns untuk burn
                Console.WriteLine($"{Target.Name} is burning, taking {DamagePerTurn} burn damage. {TurnsLeft} turns left.");
            }
            else
            {
                Console.WriteLine($"{Target.Name} has stopped burning.");
            }
        }
    }
}
