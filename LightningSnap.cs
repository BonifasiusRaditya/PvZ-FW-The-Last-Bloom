using ElementType;
namespace MyNamespace;
public class LightningSnap : Entity {
    public LightningSnap() {
        Name = "LightningSnap";
        AttackDamage = 20;
        Health = 120;
        Exp = 0;
        Shield = 0;
        Level = 1;
        TypeElement = Element.Lightning;
        Description("A plant that zaps zombies with electrical energy.");
    }
}