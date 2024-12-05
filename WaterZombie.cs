using ElementType; 
namespace MyNamespace;

public class WaterZombie : Entity{
    public WaterZombie(){
        Name = "Water Zombie";
        AttackDamage = 10;
        Health = 50;
        Exp = 20;
        TypeElement = Element.Water;
        Description("A zombie infused with water energy, strong against fire but weak against lightning.");
    }

    public void Drench(Entity target) {   // Mengurangi AttackDamage target
        Console.WriteLine($"{Name} used Drench on {target.Name}, reducing their attack power!");
        target.ApplyDebuff("attackdamage", 5); 
    }

    public void WaterShield() {          // Memberikan perlindungan tambahan
        Console.WriteLine($"{Name} used Water Shield, increasing its defense!");
        Shield += 20;
    }
}