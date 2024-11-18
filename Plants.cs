public class Plants
{
    public string Name = "Entity Null";
    public int AttackPower = 1;

    public int health = 1;
    public int Exp= 1;

    public string Type = "Normal";

    public int Level = 1;

    public Plants(string name, int attackpower, int hp, int exp, int level, string type, string description)
    {
        Name = name;
        AttackPower = attackpower;
        health = hp;
        Exp = exp;
        Type = type;
        Level = level;
        Description(description);
    }

    public string Description(string description)
    {
        return description;
    }
}