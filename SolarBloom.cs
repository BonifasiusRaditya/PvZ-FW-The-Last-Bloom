using ElementType;
namespace MyNamespace;

public class SolarBloom : Entity {
    public SolarBloom() {
        Name = "SolarBloom";
        AttackDamage = 10;
        Health = 150;
        Exp = 0;
        Shield = 0;
        Level = 1;
        TypeElement = Element.Light;
        Description("A plant that provides healing light to its allies.");
    }
}