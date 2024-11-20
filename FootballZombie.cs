using ElementType; 
namespace MyNamespace;

public class FootballZombie : Entity{
    public FootballZombie(){
        Name = "NigShooter";
        AttackDamage = 15;
        Health = 100;
        Exp = 0;
        Level = 2;
        TypeElement = Element.Normal;
        Description("A plant that shoots out darkness");
    }
}
