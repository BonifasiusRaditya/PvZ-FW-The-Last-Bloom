using ElementType; 
namespace MyNamespace;

public class WaterZombie : Entity{
    public WaterZombie(){
        Name = "WaterShooter";
        AttackDamage = 10;
        Health = 50;
        Exp = 0;
        Level = 1;
        TypeElement = Element.Water;
        Description("A plant that shoots out darkness");
    }
}
