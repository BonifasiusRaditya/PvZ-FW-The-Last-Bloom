using ElementType; 
namespace MyNamespace;

public class LightZombie : Entity{
    public LightZombie(){
        Name = "Light Zombie";
        AttackDamage = 5;
        Health = 300;
        Shield = 0;
        Exp = 0;
        Level = 0;
        TypeElement = Element.Light;
        Description("A plant that shoots out darkness");
    }
}
