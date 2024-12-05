using ElementType;
namespace MyNamespace;

public class ThornyCactus : Entity {
    public ThornyCactus() {
        Name = "ThornyCactus";
        AttackDamage = 25;
        Health = 130;
        Exp = 0;
        Shield = 10;
        Level = 1;
        TypeElement = Element.Normal;
        Description("A tough plant with sharp thorns that counterattacks.");
    }
}