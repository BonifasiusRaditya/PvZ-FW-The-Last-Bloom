using System;
using ElementType;
namespace MyNamespace;

public abstract class Item : Entity
{
    public abstract void Use(Entity target);
}

// HealingPotion - item for restoring health
public class HealingPotion : Item
{
    public int HealAmount { get; private set; }

    public HealingPotion()
    {
        Name = "Healing Potion";
        TypeElement = Element.Normal;
        HealAmount = 50;
        Description("A potion that restores health.");
    }

    public override void Use(Entity target)
    {
        target.Health += HealAmount;
        Console.WriteLine($"{Name} used on {target.Name}, restoring {HealAmount} health.");
    }
}

// AttackBoost - item for increasing attack damage
public class AttackBoost : Item
{
    public int BoostAmount { get; private set; }
    public int Duration { get; private set; }

    public AttackBoost()
    {
        Name = "Attack Boost";
        TypeElement = Element.Normal;
        BoostAmount = 10;
        Duration = 3;
        Description("A boost that temporarily increases attack damage.");
    }

    public override void Use(Entity target)
    {
        target.AttackDamage += BoostAmount;
        Console.WriteLine($"{Name} used on {target.Name}, increasing attack damage by {BoostAmount} for {Duration} turns.");
    }
}

// ShieldUpgrade - item for increasing shield
public class ShieldUpgrade : Item
{
    public int ShieldAmount { get; private set; }

    public ShieldUpgrade()
    {
        Name = "Shield Upgrade";
        TypeElement = Element.Normal;
        ShieldAmount = 20;
        Description("An upgrade that increases shield.");
    }

    public override void Use(Entity target)
    {
        target.Shield += ShieldAmount;
        Console.WriteLine($"{Name} used on {target.Name}, increasing shield by {ShieldAmount}.");
    }
}

// RareSeed - item for growing a random plant
public class RareSeed : Item
{
    private static Random random = new Random();

    private static List<Func<Entity>> plantFactories = new List<Func<Entity>> {
            () => new FreezePea(),
            () => new FireBlaze(),
            () => new LightningSnap(),
            () => new SolarBloom(),
            () => new ThornyCactus()
        };

    public RareSeed()
    {
        Name = "Rare Seed";
        TypeElement = Element.Normal;
        Description("A rare seed that grows into a random plant.");
    }

    public override void Use(Entity target)
    {
        if (target is Scientist scientist)
        {
            
            // Membuat tanaman baru secara acak
            Entity newPlant = plantFactories[random.Next(plantFactories.Count)]();
            scientist.AddPlant(newPlant); // Menambahkan tanaman ke koleksi pemain
            Console.WriteLine($"{Name} sprouted into {newPlant.Name}!");
        }
        else
        {
            Console.WriteLine($"{Name} can only be used by a Scientist.");
        }
    }

}

