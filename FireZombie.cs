using ElementType; 
namespace MyNamespace;

public class FireZombie : Entity{
    public FireZombie(){
        Name = "FireZombie";
        AttackDamage = 30;
        Health = 50;
        Exp = 0;
        Level = 1;
        TypeElement = Element.Fire;
        Description("A plant that shoots out darkness");
    }
}
