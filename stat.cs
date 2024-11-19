using System;
using System.Collections.Generic;

class Program{
    enum Type{
        Water,
        Fire,
        Lightning,
        Dark,
        Light,
        Normal
    }

    static double GetEffectiveness(Type attacker, Type defender){
        double[,] matchupTable = {
            // Water, Fire, Lightning, Dark, Light, Normal
            { 1.0, 2.0, 0.5, 1.0, 1.0, 1.0 }, // Water
            { 0.5, 1.0, 2.0, 1.0, 1.0, 1.0 }, // Fire
            { 2.0, 0.5, 1.0, 1.0, 1.0, 1.0 }, // Lightning
            { 1.0, 1.0, 1.0, 1.0, 2.0, 1.0 }, // Dark
            { 1.0, 1.0, 1.0, 2.0, 1.0, 1.0 }, // Light
            { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0 }  // Normal
        };
        return matchupTable[(int)attacker, (int)defender];
    } 

    static void PrintEffectiveness(Type attacker){
        Console.WriteLine($"Effectiveness of {attacker} attack:");
        foreach (Type defender in Enum.GetValues(typeof(Type))){
            double effectiveness = GetEffectiveness(attacker, defender);
            Console.WriteLine($"Against {defender}: {effectiveness}x");
        }
        Console.WriteLine();
    }

    static void Main(string[] args){
        PrintEffectiveness(Type.Water);
        PrintEffectiveness(Type.Fire);
        PrintEffectiveness(Type.Lightning);
        PrintEffectiveness(Type.Dark);
        PrintEffectiveness(Type.Light);
        PrintEffectiveness(Type.Normal);
        Type attacker = Type.Fire;
        Type defender = Type.Water;
        double multiplier = GetEffectiveness(attacker, defender);
        Console.WriteLine($"{attacker} attacking {defender} results in a multiplier of {multiplier}x damage.");
    }
}
