using ElementType; 
namespace MyNamespace;

public class NigShooter : Entity{
    public NigShooter(){
        Name = "NigShooter";
        AttackDamage = 20;
        Health = 150;
        Exp = 0;
        Level = 0;
        TypeElement = Element.Dark;
        Description("A plant that shoots out darkness");
    }
}
