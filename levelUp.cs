using System.Dynamic;
using System.Runtime.CompilerServices;

class levelUp{
    private int level { get; set; }
    private int exp { get; set; }
    int expNeeded = 100;

    public levelUp(int expGained){
        leveling(expGained);
        System.Console.WriteLine("Level: " + level);
        System.Console.WriteLine("Exp: " + exp);
        System.Console.WriteLine("Exp Needed: " + expNeeded);
    }

    int getLevel(){
        return level;
    }

    int getExp(){
        return exp;
    }

    void setLevel(int level){
        this.level = level;
    }

    void setExp(int exp){
        this.exp = exp;
    }

    public void leveling(int expGained){
        if(expGained >= expNeeded){
            setLevel(getLevel() + 1);
            setExp(getExp() - expNeeded);
        }
        if(getLevel() % 5 == 0) expNeeded += 50;
    }
}