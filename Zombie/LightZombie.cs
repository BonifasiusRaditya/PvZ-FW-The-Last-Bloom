using ElementType; 
namespace MyNamespace;

public class LightZombie : Entity{
    public LightZombie(){
        Name = "Light Zombie";
        AttackDamage = 5;
        Health = 300;
        Exp = 10;
        TypeElement = Element.Light;
        Description("A radiant zombie with immense health, strong against darkness but weak against dark-type attacks.");
    }

    public void RadiantShield() {                 // Memberikan perlindungan tambahan
        Console.WriteLine($"{Name} activated Radiant Shield, increasing its protection!");
        Shield += 50;
    }

    public void BlindingLight(Entity target) {    // Mengurangi akurasi serangan lawan 
        Console.WriteLine($"{Name} used Blinding Light on {target.Name}, reducing their accuracy!");
        target.ApplyDebuff("attackdamage", 10);
    }
}